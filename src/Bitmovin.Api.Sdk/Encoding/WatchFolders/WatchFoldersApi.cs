using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.WatchFolders
{
    /// <summary>
    /// API for WatchFoldersApi
    /// </summary>
    public class WatchFoldersApi
    {
        private readonly IWatchFoldersApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the WatchFoldersApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public WatchFoldersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWatchFoldersApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of WatchFoldersApi
        /// </summary>
        public static BitmovinApiBuilder<WatchFoldersApi> Builder => new BitmovinApiBuilder<WatchFoldersApi>();

        /// <summary>
        /// Create Watch Folder
        /// </summary>
        /// <param name="watchFolder">The Watch Folder to be created</param>
        public async Task<Models.WatchFolder> CreateAsync(Models.WatchFolder watchFolder)
        {
            return await _apiClient.CreateAsync(watchFolder);
        }

        /// <summary>
        /// Delete Watch Folder
        /// </summary>
        /// <param name="watchFolderId">Id of the Watch Folder (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string watchFolderId)
        {
            return await _apiClient.DeleteAsync(watchFolderId);
        }

        /// <summary>
        /// Watch Folder details
        /// </summary>
        /// <param name="watchFolderId">Id of the Watch Folder (required)</param>
        public async Task<Models.WatchFolder> GetAsync(string watchFolderId)
        {
            return await _apiClient.GetAsync(watchFolderId);
        }

        /// <summary>
        /// List all Watch Folders
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WatchFolder>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start Watch Folder
        /// </summary>
        /// <param name="watchFolderId">Id of the Watch Folder (required)</param>
        public async Task<Models.BitmovinResponse> StartAsync(string watchFolderId)
        {
            return await _apiClient.StartAsync(watchFolderId);
        }

        /// <summary>
        /// Stop Watch Folder
        /// </summary>
        /// <param name="watchFolderId">Id of the Watch Folder (required)</param>
        public async Task<Models.BitmovinResponse> StopAsync(string watchFolderId)
        {
            return await _apiClient.StopAsync(watchFolderId);
        }

        internal interface IWatchFoldersApiClient
        {
            [Post("/encoding/watch-folders")]
            [AllowAnyStatusCode]
            Task<Models.WatchFolder> CreateAsync([Body] Models.WatchFolder watchFolder);

            [Delete("/encoding/watch-folders/{watch_folder_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("watch_folder_id")] string watchFolderId);

            [Get("/encoding/watch-folders/{watch_folder_id}")]
            [AllowAnyStatusCode]
            Task<Models.WatchFolder> GetAsync([Path("watch_folder_id")] string watchFolderId);

            [Get("/encoding/watch-folders")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WatchFolder>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/watch-folders/{watch_folder_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("watch_folder_id")] string watchFolderId);

            [Post("/encoding/watch-folders/{watch_folder_id}/stop")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StopAsync([Path("watch_folder_id")] string watchFolderId);
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
