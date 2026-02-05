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
    /// <summary>
    /// Factory for creating Bitmovin API client instances
    /// </summary>
    public class BitmovinApiClientFactory : IBitmovinApiClientFactory
    {
        /// <summary>
        /// Gets the API key used for authentication
        /// </summary>
        protected readonly string ApiKey;

        /// <summary>
        /// Gets the tenant organization ID for multi-tenant accounts
        /// </summary>
        protected readonly string TenantOrgId;

        /// <summary>
        /// Gets the REST client instance
        /// </summary>
        protected readonly RestClient RestClient;

        /// <summary>
        /// Gets the logger instance
        /// </summary>
        protected readonly IBitmovinApiLogger Logger;

        /// <summary>
        /// Gets the JSON serializer settings
        /// </summary>
        protected readonly JsonSerializerSettings JsonSettings;

        /// <summary>
        /// Initializes a new instance of the BitmovinApiClientFactory class
        /// </summary>
        /// <param name="apiKey">The API key for authentication</param>
        /// <param name="tenantOrgId">The tenant organization ID (optional)</param>
        /// <param name="baseUrl">The base URL for the API</param>
        /// <param name="logger">The logger instance (optional)</param>
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

        /// <summary>
        /// Creates a typed REST client instance
        /// </summary>
        /// <typeparam name="T">The client interface type</typeparam>
        /// <returns>The typed client instance</returns>
        public virtual T CreateClient<T>()
        {
            return RestClient.For<T>();
        }

        /// <summary>
        /// Creates an HTTP client with configured message handlers
        /// </summary>
        /// <param name="baseUrl">The base URL for the client</param>
        /// <returns>The configured HTTP client</returns>
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

        /// <summary>
        /// Creates the HTTP message handler pipeline
        /// </summary>
        /// <returns>The collection of message handlers</returns>
        protected virtual IEnumerable<DelegatingHandler> CreateHttpMessageHandlers()
        {
            yield return new HeadersHandler(GetHeaders());
            yield return new ErrorHandler(JsonSettings);

            if (Logger != null)
            {
                yield return new LoggingHandler(Logger);
            }
        }

        /// <summary>
        /// Creates a JSON request body serializer
        /// </summary>
        /// <returns>The request body serializer</returns>
        protected virtual JsonRequestBodySerializer CreateRequestBodySerializer()
        {
            return new JsonRequestBodySerializer {JsonSerializerSettings = JsonSettings};
        }

        /// <summary>
        /// Creates a response deserializer
        /// </summary>
        /// <returns>The response deserializer</returns>
        protected virtual ResponseDeserializer CreateResponseDeserializer()
        {
            return new BitmovinResponseDeserializer(JsonSettings);
        }

        /// <summary>
        /// Creates a query parameter serializer
        /// </summary>
        /// <returns>The query parameter serializer</returns>
        protected virtual RequestQueryParamSerializer CreateQueryParamSerializer()
        {
            return new BitmovinQueryParamSerializer();
        }

        /// <summary>
        /// Gets the HTTP headers to include in requests
        /// </summary>
        /// <returns>The dictionary of headers</returns>
        protected virtual Dictionary<string, string> GetHeaders()
        {
            var headers = new Dictionary<string, string>
            {
                {"X-Api-Client", "bitmovin-api-sdk-dotnet"},
                {"X-Api-Client-Version", "1.255.1"}
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

