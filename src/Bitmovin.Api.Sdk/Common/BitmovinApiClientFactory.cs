using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestEase;

using Bitmovin.Api.Sdk.Common.Logging;

namespace Bitmovin.Api.Sdk.Common
{
    public class BitmovinApiClientFactory : IBitmovinApiClientFactory
    {
        protected readonly string ApiKey;
        protected readonly string TenantOrgId;
        protected readonly RestClient RestClient;
        protected readonly IBitmovinApiLogger Logger;

        protected internal BitmovinApiClientFactory(
            string apiKey,
            string tenantOrgId,
            string baseUrl,
            IBitmovinApiLogger logger)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(nameof(apiKey));
            }

            ApiKey = apiKey;
            TenantOrgId = tenantOrgId;
            Logger = logger ?? new NullLogger();

            if (string.IsNullOrEmpty(baseUrl))
            {
                baseUrl = "https://api.bitmovin.com/v1";
            }

            var jsonSettings = CreateJsonSettings();

            RestClient = new RestClient(baseUrl, CreateRequestModifier)
            {
                RequestBodySerializer = CreateRequestBodySerializer(jsonSettings, logger),
                ResponseDeserializer = CreateResponseDeserializer(jsonSettings, logger)
            };
        }

        protected virtual JsonSerializerSettings CreateJsonSettings()
        {
            return new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = {new StringEnumConverter()},
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        protected virtual JsonRequestBodySerializer CreateRequestBodySerializer(
            JsonSerializerSettings jsonSettings,
            IBitmovinApiLogger logger)
        {
            return new JsonRequestBodySerializer {JsonSerializerSettings = jsonSettings};
        }

        protected virtual BitmovinResponseDeserializer CreateResponseDeserializer(
            JsonSerializerSettings jsonSettings,
            IBitmovinApiLogger logger)
        {
            return new BitmovinResponseDeserializer(jsonSettings, logger);
        }

        protected virtual async Task CreateRequestModifier(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("X-Api-Client", "bitmovin-api-sdk-dotnet");
            request.Headers.Add("X-Api-Client-Version", "1.17.0-alpha.0");

            if (!string.IsNullOrEmpty(ApiKey))
            {
                request.Headers.Add("X-Api-Key", ApiKey);
            }

            if (!string.IsNullOrEmpty(TenantOrgId))
            {
                request.Headers.Add("X-Tenant-Org-Id", TenantOrgId);
            }

            await Logger.LogRequest(request);
        }

        public virtual T CreateClient<T>()
        {
            return RestClient.For<T>();
        }
    }
}
