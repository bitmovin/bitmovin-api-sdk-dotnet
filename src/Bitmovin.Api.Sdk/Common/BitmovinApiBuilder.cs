using System;
using Bitmovin.Api.Sdk.Common.Logging;

namespace Bitmovin.Api.Sdk.Common
{
    public class BitmovinApiBuilder<T>
    {
        private string _apiKey;
        private string _tenantOrgId;
        private IBitmovinApiLogger _loggerFactory;
        private string _baseUrl;

        protected internal BitmovinApiBuilder()
        {
        }

        public BitmovinApiBuilder<T> WithApiKey(string apiKey)
        {
            _apiKey = apiKey;

            return this;
        }

        public BitmovinApiBuilder<T> WithTenantOrgIdKey(string tenantOrgId)
        {
            _tenantOrgId = tenantOrgId;

            return this;
        }

        public BitmovinApiBuilder<T> WithLogger(IBitmovinApiLogger loggerFactory)
        {
            _loggerFactory = loggerFactory;

            return this;
        }

        public BitmovinApiBuilder<T> WithBaseUrl(string baseUrl)
        {
            _baseUrl = baseUrl;

            return this;
        }

        public T Build()
        {
            BitmovinApiClientFactory apiClientFactory = new BitmovinApiClientFactory(_apiKey, _tenantOrgId, _baseUrl, _loggerFactory);

            return (T) Activator.CreateInstance(typeof(T), apiClientFactory);
        }
    }
}
