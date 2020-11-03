using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.UdpMulticast.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.UdpMulticast
{
    public class UdpMulticastApi
    {
        private readonly IUdpMulticastApiClient _apiClient;

        public UdpMulticastApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IUdpMulticastApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of UdpMulticastApi
        /// </summary>
        public static BitmovinApiBuilder<UdpMulticastApi> Builder => new BitmovinApiBuilder<UdpMulticastApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create UDP multicast input
        /// </summary>
        /// <param name="udpMulticastInput">The UdpMulticastInput to be created</param>
        public async Task<Models.UdpMulticastInput> CreateAsync(Models.UdpMulticastInput udpMulticastInput)
        {
            return await _apiClient.CreateAsync(udpMulticastInput);
        }

        /// <summary>
        /// Delete UDP multicast input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.UdpMulticastInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// UDP multicast Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.UdpMulticastInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List UDP multicast inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.UdpMulticastInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IUdpMulticastApiClient
        {
            [Post("/encoding/inputs/udp-multicast")]
            [AllowAnyStatusCode]
            Task<Models.UdpMulticastInput> CreateAsync([Body] Models.UdpMulticastInput udpMulticastInput);

            [Delete("/encoding/inputs/udp-multicast/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.UdpMulticastInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/udp-multicast/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.UdpMulticastInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/udp-multicast")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.UdpMulticastInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// Filter inputs by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

            private ListQueryParams SetQueryParam<T>(string key, T value)
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
