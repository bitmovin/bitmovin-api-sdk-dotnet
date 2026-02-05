using System;
using Bitmovin.Api.Sdk.Common.Logging;

namespace Bitmovin.Api.Sdk.Common
{
    /// <summary>
    /// Fluent builder for creating Bitmovin API instances
    /// </summary>
    /// <typeparam name="T">The API type to build</typeparam>
    public class BitmovinApiBuilder<T>
    {
        private string _apiKey;
        private string _tenantOrgId;
        private IBitmovinApiLogger _loggerFactory;
        private string _baseUrl;

        /// <summary>
        /// Initializes a new instance of the BitmovinApiBuilder class
        /// </summary>
        protected internal BitmovinApiBuilder()
        {
        }

        /// <summary>
        /// Sets the API key for authentication
        /// </summary>
        /// <param name="apiKey">The API key</param>
        /// <returns>The builder instance for method chaining</returns>
        public BitmovinApiBuilder<T> WithApiKey(string apiKey)
        {
            _apiKey = apiKey;

            return this;
        }

        /// <summary>
        /// Sets the tenant organization ID for multi-tenant accounts
        /// </summary>
        /// <param name="tenantOrgId">The tenant organization ID</param>
        /// <returns>The builder instance for method chaining</returns>
        public BitmovinApiBuilder<T> WithTenantOrgIdKey(string tenantOrgId)
        {
            _tenantOrgId = tenantOrgId;

            return this;
        }

        /// <summary>
        /// Sets the logger for API requests and responses
        /// </summary>
        /// <param name="loggerFactory">The logger instance</param>
        /// <returns>The builder instance for method chaining</returns>
        public BitmovinApiBuilder<T> WithLogger(IBitmovinApiLogger loggerFactory)
        {
            _loggerFactory = loggerFactory;

            return this;
        }

        /// <summary>
        /// Sets a custom base URL for the API (defaults to https://api.bitmovin.com/v1)
        /// </summary>
        /// <param name="baseUrl">The custom base URL</param>
        /// <returns>The builder instance for method chaining</returns>
        public BitmovinApiBuilder<T> WithBaseUrl(string baseUrl)
        {
            _baseUrl = baseUrl;

            return this;
        }

        /// <summary>
        /// Builds and returns the configured API instance
        /// </summary>
        /// <returns>The configured API instance</returns>
        public T Build()
        {
            BitmovinApiClientFactory apiClientFactory = new BitmovinApiClientFactory(_apiKey, _tenantOrgId, _baseUrl, _loggerFactory);

            return (T) Activator.CreateInstance(typeof(T), apiClientFactory);
        }
    }
}
