using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Testing.CodecCompatibility;

namespace Bitmovin.Api.Sdk.Player.Testing
{
    /// <summary>
    /// API for TestingApi
    /// </summary>
    public class TestingApi
    {
        /// <summary>
        /// Initializes a new instance of the TestingApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public TestingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            CodecCompatibility = new CodecCompatibilityApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TestingApi
        /// </summary>
        public static BitmovinApiBuilder<TestingApi> Builder => new BitmovinApiBuilder<TestingApi>();

        /// <summary>
        /// Gets the CodecCompatibility API
        /// </summary>
        public CodecCompatibilityApi CodecCompatibility { get; }
    }
}
