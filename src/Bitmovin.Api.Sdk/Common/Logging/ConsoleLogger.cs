using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bitmovin.Api.Sdk.Common.Logging
{
    /// <summary>
    /// Logger implementation that writes to the console
    /// </summary>
    public class ConsoleLogger : IBitmovinApiLogger
    {
        /// <summary>
        /// Logs an HTTP request to the console
        /// </summary>
        /// <param name="request">The HTTP request message</param>
        public async Task LogRequest(HttpRequestMessage request)
        {
            Console.WriteLine("Request: " + request);

            if (request.Content != null)
            {
                Console.WriteLine("Request Body: " + await request.Content.ReadAsStringAsync());   
            }
        }

        /// <summary>
        /// Logs an HTTP response to the console
        /// </summary>
        /// <param name="response">The HTTP response message</param>
        public async Task LogResponse(HttpResponseMessage response)
        {
            Console.WriteLine("Response: " + response);

            if (response.Content != null)
            {
                Console.WriteLine("Response Body: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
