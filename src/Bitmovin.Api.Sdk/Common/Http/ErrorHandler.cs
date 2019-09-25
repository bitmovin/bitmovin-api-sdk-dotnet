using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bitmovin.Api.Sdk.Models;
using Newtonsoft.Json;

namespace Bitmovin.Api.Sdk.Common.Http
{
    class ErrorHandler : DelegatingHandler
    {
        private readonly JsonSerializerSettings _jsonSettings;

        public ErrorHandler(JsonSerializerSettings jsonSettings)
        {
            _jsonSettings = jsonSettings;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            try
            {
                var response = await base.SendAsync(request, cancellationToken);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                throw await ConstructBitmovinApiException(request, response);
            }
            catch (HttpRequestException ex)
            {
                throw await ConstructBitmovinApiExceptionAsync(request, ex);
            }
        }

        private async Task<BitmovinApiException> ConstructBitmovinApiExceptionAsync(HttpRequestMessage request, HttpRequestException exception)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(exception.Message);

            if (exception.InnerException != null && !string.IsNullOrEmpty(exception.InnerException.Message))
            {
                sb.AppendLine("developerMessage:");
                sb.AppendLine("  " + exception.InnerException.Message);
            }

            sb.AppendLine("request:");
            sb.Append(await ConstructRequestMessage(request));

            throw new BitmovinApiException(sb.ToString(), 0, null, exception);
        }

        private async Task<BitmovinApiException> ConstructBitmovinApiException(
            HttpRequestMessage request,
            HttpResponseMessage response)
        {
            StringBuilder sb = new StringBuilder();

            var responseBody = await response.Content.ReadAsStringAsync() ?? "";
            var responseError = DeserializeResponse(responseBody);

            var message = ConstructMessage(responseError, responseBody);

            sb.AppendLine(message);

            var data = responseError?.Data;
            if (data != null)
            {
                if (data.Code != null)
                {
                    sb.AppendLine($"errorCode: {data.Code}");
                }

                if (data.Details?.Count > 0)
                {
                    sb.AppendLine("details:");
                    sb.Append(ConstructDetails(data.Details));
                }

                if (data.Links?.Count > 0)
                {
                    sb.AppendLine("links:");
                    sb.Append(ConstructLinks(data.Links));
                }
            }

            sb.AppendLine("request:");
            sb.Append(await ConstructRequestMessage(request));

            sb.AppendLine("response:");
            sb.Append(ConstructResponseMessage(responseBody, response));

            return new BitmovinApiException(sb.ToString(), response.StatusCode, responseError);
        }

        private static string ConstructMessage(ResponseError responseError, string responseBody)
        {
            if (!string.IsNullOrWhiteSpace(responseError?.Data?.Message))
            {
                return responseError.Data.Message;
            }

            return "Request failed";
        }

        private ResponseError DeserializeResponse(string responseBody)
        {
            var responseError = JsonConvert.DeserializeObject<ResponseError>(responseBody, _jsonSettings);
            return responseError?.Data != null ? responseError : null;
        }

        private async Task<string> ConstructRequestMessage(HttpRequestMessage request)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  method: {request.Method}");
            sb.AppendLine($"  url: {request.RequestUri}");

            if (request.Content != null)
            {
                var requestBody = await request.Content?.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(requestBody))
                {
                    sb.AppendLine($"  body: {requestBody}");
                }
            }

            return sb.ToString();
        }

        private string ConstructResponseMessage(string responseBody, HttpResponseMessage response)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"  httpStatusCode: {(int) response.StatusCode}");
            if (!string.IsNullOrWhiteSpace(responseBody))
            {
                sb.AppendLine($"  body: {responseBody}");
            }

            return sb.ToString();
        }

        private string ConstructDetails(List<Message> details)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var message in details)
            {
                sb.AppendLine($"  - id: {message.Id}");
                if (message.Date != null)
                {
                    sb.AppendLine($"    date: {message.Date?.ToString(_jsonSettings.DateFormatString)}");
                }
                sb.AppendLine($"    type: {message.Type}");
                sb.AppendLine($"    text: {message.Text}");
                sb.AppendLine($"    field: {message.Field}");
            }

            return sb.ToString();
        }

        private string ConstructLinks(List<Link> links)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var link in links)
            {
                sb.AppendLine($"  {link.Title}: {link.Href}");
            }

            return sb.ToString();
        }
    }
}
