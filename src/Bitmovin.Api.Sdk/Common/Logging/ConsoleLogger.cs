using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bitmovin.Api.Sdk.Common.Logging
{
    public class ConsoleLogger : IBitmovinApiLogger
    {
        public async Task LogRequest(HttpRequestMessage request)
        {
            Console.WriteLine("Request: " + request);

            if (request.Content != null)
            {
                Console.WriteLine("Request Body: " + await request.Content.ReadAsStringAsync());   
            }
        }

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
