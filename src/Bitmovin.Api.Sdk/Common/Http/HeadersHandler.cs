using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Bitmovin.Api.Sdk.Common.Http
{
    class HeadersHandler : DelegatingHandler
    {
        private IDictionary<string, string> _headers;

        public HeadersHandler(IDictionary<string, string> headers)
        {
            _headers = headers;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            foreach (var keyValuePair in _headers)
            {
                request.Headers.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
