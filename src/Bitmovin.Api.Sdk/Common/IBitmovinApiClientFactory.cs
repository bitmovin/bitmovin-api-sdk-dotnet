namespace Bitmovin.Api.Sdk.Common
{
    public interface IBitmovinApiClientFactory
    {
        T CreateClient<T>();
    }
}
