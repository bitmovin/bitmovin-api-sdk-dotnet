using System.Net.Http;
using Newtonsoft.Json;
using RestEase;

using Bitmovin.Api.Sdk.Common.Logging;

namespace Bitmovin.Api.Sdk.Common
{
    public class BitmovinResponseDeserializer : ResponseDeserializer
    {
        private readonly JsonSerializerSettings _jsonSerializerSettings;
        private readonly IBitmovinApiLogger _logger;

        public BitmovinResponseDeserializer(JsonSerializerSettings settings, IBitmovinApiLogger logger)
        {
            _jsonSerializerSettings = settings;
            _logger = logger;
        }

        public override T Deserialize<T>(string content, HttpResponseMessage response, ResponseDeserializerInfo info)
        {
            _logger.LogResponse(response);

            if (response.IsSuccessStatusCode)
            {
                var responseEnvelope =
                    JsonConvert.DeserializeObject<Models.ResponseEnvelope<T>>(content, _jsonSerializerSettings);

                return responseEnvelope.Data.Result;
            }

            Models.ResponseError responseError = null;
            if (!string.IsNullOrWhiteSpace(content))
            {
                responseError = JsonConvert.DeserializeObject<Models.ResponseError>(content, _jsonSerializerSettings);
            }

            throw new BitmovinApiException(response.StatusCode, responseError);
        }
    }
}
