using System.Net.Http;
using System.Threading.Tasks;
using Bitmovin.Api.Sdk.Common.Logging;
using Xunit.Abstractions;

namespace Bitmovin.Api.Sdk.Tests
{
    public class XunitLogger : IBitmovinApiLogger
    {
        private readonly ITestOutputHelper _output;

        public XunitLogger(ITestOutputHelper output)
        {
            _output = output;
        }
        
        public async Task LogRequest(HttpRequestMessage request)
        {
            _output.WriteLine("Request: " + request);

            if (request.Content != null)
            {
                _output.WriteLine("Request Body: " + await request.Content.ReadAsStringAsync());   
            }
        }

        public async Task LogResponse(HttpResponseMessage response)
        {
            _output.WriteLine("Response: " + response);

            if (response.Content != null)
            {
                _output.WriteLine("Response Body: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
