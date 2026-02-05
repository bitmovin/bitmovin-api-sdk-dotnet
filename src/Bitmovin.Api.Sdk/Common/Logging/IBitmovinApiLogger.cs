using System.Net.Http;
using System.Threading.Tasks;

namespace Bitmovin.Api.Sdk.Common.Logging
{
    /// <summary>
    /// Logger interface for Bitmovin API requests and responses
    /// </summary>
    public interface IBitmovinApiLogger
    {
        /// <summary>
        /// Logs an HTTP request
        /// </summary>
        /// <param name="request">The HTTP request message</param>
        Task LogRequest(HttpRequestMessage request);

        /// <summary>
        /// Logs an HTTP response
        /// </summary>
        /// <param name="response">The HTTP response message</param>
        Task LogResponse(HttpResponseMessage response);
    }
}
