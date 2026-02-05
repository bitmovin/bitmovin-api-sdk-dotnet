using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.PrewarmedEncoderPools.Schedules
{
    /// <summary>
    /// API for SchedulesApi
    /// </summary>
    public class SchedulesApi
    {
        private readonly ISchedulesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SchedulesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SchedulesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISchedulesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SchedulesApi
        /// </summary>
        public static BitmovinApiBuilder<SchedulesApi> Builder => new BitmovinApiBuilder<SchedulesApi>();

        /// <summary>
        /// Create prewarmed encoder pool schedule
        /// </summary>
        /// <param name="poolId">Id of the scheduled encoder pool (required)</param>
        /// <param name="prewarmedEncoderPoolSchedule">The prewarmed encoder pool schedule to be created</param>
        public async Task<Models.PrewarmedEncoderPoolSchedule> CreateAsync(string poolId, Models.PrewarmedEncoderPoolSchedule prewarmedEncoderPoolSchedule)
        {
            return await _apiClient.CreateAsync(poolId, prewarmedEncoderPoolSchedule);
        }

        /// <summary>
        /// Delete prewarmed encoder pool schedule
        /// </summary>
        /// <param name="poolId">Id of the scheduled encoder pool (required)</param>
        /// <param name="scheduleId">Id of the prewarmed encoder pool schedule (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string poolId, string scheduleId)
        {
            return await _apiClient.DeleteAsync(poolId, scheduleId);
        }

        /// <summary>
        /// Prewarmed encoder pool schedule details
        /// </summary>
        /// <param name="poolId">Id of the scheduled encoder pool (required)</param>
        /// <param name="scheduleId">Id of the prewarmed encoder pool schedule (required)</param>
        public async Task<Models.PrewarmedEncoderPoolSchedule> GetAsync(string poolId, string scheduleId)
        {
            return await _apiClient.GetAsync(poolId, scheduleId);
        }

        /// <summary>
        /// List prewarmed encoder pool schedules
        /// </summary>
        /// <param name="poolId">Id of the scheduled encoder pool (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PrewarmedEncoderPoolSchedule>> ListAsync(string poolId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(poolId, q);
        }

        internal interface ISchedulesApiClient
        {
            [Post("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}/schedules")]
            [AllowAnyStatusCode]
            Task<Models.PrewarmedEncoderPoolSchedule> CreateAsync([Path("pool_id")] string poolId, [Body] Models.PrewarmedEncoderPoolSchedule prewarmedEncoderPoolSchedule);

            [Delete("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}/schedules/{schedule_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("pool_id")] string poolId, [Path("schedule_id")] string scheduleId);

            [Get("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}/schedules/{schedule_id}")]
            [AllowAnyStatusCode]
            Task<Models.PrewarmedEncoderPoolSchedule> GetAsync([Path("pool_id")] string poolId, [Path("schedule_id")] string scheduleId);

            [Get("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}/schedules")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PrewarmedEncoderPoolSchedule>> ListAsync([Path("pool_id")] string poolId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
