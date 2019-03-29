using System.Net.Http;
using System.Threading.Tasks;

namespace Bitmovin.Api.Sdk.Common.Logging
{
    public interface IBitmovinApiLogger
    {
        Task LogRequest(HttpRequestMessage request);
        Task LogResponse(HttpResponseMessage response);
    }
}
