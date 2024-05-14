using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Bitmovin.Api.Sdk.Common.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
        protected readonly JsonSerializerSettings JsonSettings;

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
            Logger = logger;

            if (string.IsNullOrEmpty(baseUrl))
            {
                baseUrl = "https://api.bitmovin.com/v1";
            }

            JsonSettings = CreateJsonSettings();
            RestClient = CreateRestClient(baseUrl);
        }

        public virtual T CreateClient<T>()
        {
            return RestClient.For<T>();
        }

        protected virtual HttpClient CreateHttpClient(string baseUrl)
        {
            HttpMessageHandler nextHandler = new HttpClientHandler();

            foreach (var handler in CreateHttpMessageHandlers().Reverse())
            {
                handler.InnerHandler = nextHandler;
                nextHandler = handler;
            }

            return new HttpClient(nextHandler)
            {
                BaseAddress = new Uri(baseUrl),
            };
        }

        protected virtual IEnumerable<DelegatingHandler> CreateHttpMessageHandlers()
        {
            yield return new HeadersHandler(GetHeaders());
            yield return new ErrorHandler(JsonSettings);

            if (Logger != null)
            {
                yield return new LoggingHandler(Logger);
            }
        }

        protected virtual JsonRequestBodySerializer CreateRequestBodySerializer()
        {
            return new JsonRequestBodySerializer {JsonSerializerSettings = JsonSettings};
        }

        protected virtual ResponseDeserializer CreateResponseDeserializer()
        {
            return new BitmovinResponseDeserializer(JsonSettings);
        }

        protected virtual RequestQueryParamSerializer CreateQueryParamSerializer()
        {
            return new BitmovinQueryParamSerializer();
        }

        protected virtual Dictionary<string, string> GetHeaders()
        {
            var headers = new Dictionary<string, string>
            {
                {"X-Api-Client", "bitmovin-api-sdk-dotnet"},
                {"X-Api-Client-Version", "1.192.0"}
            };

            if (!string.IsNullOrEmpty(ApiKey))
            {
                headers.Add("X-Api-Key", ApiKey);
            }

            if (!string.IsNullOrEmpty(TenantOrgId))
            {
                headers.Add("X-Tenant-Org-Id", TenantOrgId);
            }

            return headers;
        }

        private JsonSerializerSettings CreateJsonSettings()
        {
            return new JsonSerializerSettings
            {
                ContractResolver = new EmptyCollectionContractResolver(),
                Converters = {new TolerantEnumConverter()},
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        private RestClient CreateRestClient(string baseUrl)
        {
            return new RestClient(CreateHttpClient(baseUrl))
            {
                RequestBodySerializer = CreateRequestBodySerializer(),
                ResponseDeserializer = CreateResponseDeserializer(),
                RequestQueryParamSerializer = CreateQueryParamSerializer()
            };
        }

        private class TolerantEnumConverter : StringEnumConverter
        {
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                try
                {
                    return base.ReadJson(reader, objectType, existingValue, serializer);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}

