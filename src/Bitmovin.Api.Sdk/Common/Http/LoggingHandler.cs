using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bitmovin.Api.Sdk.Common.Logging;

namespace Bitmovin.Api.Sdk.Common.Http
{
    class LoggingHandler : DelegatingHandler
    {
        private readonly IBitmovinApiLogger _logger;

        public LoggingHandler(IBitmovinApiLogger logger)
        {
            _logger = logger;
        }
        
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await _logger.LogRequest(request);
            
            var response = await base.SendAsync(request, cancellationToken);

            await _logger.LogResponse(response);
            
            return response;
        }
    }
}
