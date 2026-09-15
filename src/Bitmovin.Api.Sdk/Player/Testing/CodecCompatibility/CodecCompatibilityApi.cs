using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.Testing.CodecCompatibility
{
    /// <summary>
    /// API for CodecCompatibilityApi
    /// </summary>
    public class CodecCompatibilityApi
    {
        private readonly ICodecCompatibilityApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the CodecCompatibilityApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CodecCompatibilityApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICodecCompatibilityApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CodecCompatibilityApi
        /// </summary>
        public static BitmovinApiBuilder<CodecCompatibilityApi> Builder => new BitmovinApiBuilder<CodecCompatibilityApi>();

        /// <summary>
        /// Get Codec Compatibility Report
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PccReport> GetAsync(params Func<GetQueryParams, GetQueryParams>[] queryParams)
        {
            GetQueryParams q = new GetQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.GetAsync(q);
        }

        internal interface ICodecCompatibilityApiClient
        {
            [Get("/player/testing/codec-compatibility")]
            [AllowAnyStatusCode]
            Task<Models.PccReport> GetAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for Get
        /// </summary>
        public class GetQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Include pools with only prerelease browser evidence. Available to every report reader. Literal true or false.
            /// </summary>
            public GetQueryParams IncludePrerelease(bool? includePrerelease) => SetQueryParam("includePrerelease", includePrerelease);

            /// <summary>
            /// Keep pools with a device answer in at least one selected cell. Literal true or false.
            /// </summary>
            public GetQueryParams ReportedOnly(bool? reportedOnly) => SetQueryParam("reportedOnly", reportedOnly);

            /// <summary>
            /// Select only HDR columns. Literal true or false.
            /// </summary>
            public GetQueryParams HdrOnly(bool? hdrOnly) => SetQueryParam("hdrOnly", hdrOnly);

            /// <summary>
            /// Trimmed case-insensitive substring of the codec identifier.
            /// </summary>
            public GetQueryParams Codec(string codec) => SetQueryParam("codec", codec);

            /// <summary>
            /// Trimmed case-insensitive substring of the published device name and qualifier.
            /// </summary>
            public GetQueryParams Device(string device) => SetQueryParam("device", device);

            private GetQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
