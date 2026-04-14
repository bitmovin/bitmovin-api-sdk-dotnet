using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Agents.Assistant.Sessions
{
    /// <summary>
    /// API for SessionsApi
    /// </summary>
    public class SessionsApi
    {
        private readonly ISessionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SessionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SessionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISessionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SessionsApi
        /// </summary>
        public static BitmovinApiBuilder<SessionsApi> Builder => new BitmovinApiBuilder<SessionsApi>();

        /// <summary>
        /// Create Agent Session
        /// </summary>
        public async Task<Models.AgentSessionResponse> CreateAsync()
        {
            return await _apiClient.CreateAsync();
        }

        /// <summary>
        /// Delete Agent Session
        /// </summary>
        /// <param name="sessionId">Id of the session (required)</param>
        public async Task<Models.AgentSessionResponse> DeleteAsync(string sessionId)
        {
            return await _apiClient.DeleteAsync(sessionId);
        }

        /// <summary>
        /// Get Agent Session Details
        /// </summary>
        /// <param name="sessionId">Id of the session (required)</param>
        public async Task<Models.AgentSessionHistoryResponse> GetAsync(string sessionId)
        {
            return await _apiClient.GetAsync(sessionId);
        }

        /// <summary>
        /// List Agent Sessions
        /// </summary>
        public async Task<Models.AgentSessionListResponse> ListAsync()
        {
            return await _apiClient.ListAsync();
        }

        internal interface ISessionsApiClient
        {
            [Post("/agents/assistant/sessions")]
            [AllowAnyStatusCode]
            Task<Models.AgentSessionResponse> CreateAsync();

            [Delete("/agents/assistant/sessions/{session_id}")]
            [AllowAnyStatusCode]
            Task<Models.AgentSessionResponse> DeleteAsync([Path("session_id")] string sessionId);

            [Get("/agents/assistant/sessions/{session_id}")]
            [AllowAnyStatusCode]
            Task<Models.AgentSessionHistoryResponse> GetAsync([Path("session_id")] string sessionId);

            [Get("/agents/assistant/sessions")]
            [AllowAnyStatusCode]
            Task<Models.AgentSessionListResponse> ListAsync();
        }
    }
}
