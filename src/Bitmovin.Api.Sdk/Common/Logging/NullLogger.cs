using System.Net.Http;
using System.Threading.Tasks;

namespace Bitmovin.Api.Sdk.Common.Logging
{
    class NullLogger : IBitmovinApiLogger
    {
        public Task LogRequest(HttpRequestMessage request)
        {
            // do nothing
            return Task.CompletedTask;
        }

        public Task LogResponse(HttpResponseMessage response)
        {
            // do nothing
            return Task.CompletedTask;
        }
    }
}
