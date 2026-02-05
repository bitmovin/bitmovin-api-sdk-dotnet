namespace Bitmovin.Api.Sdk.Common
{
    /// <summary>
    /// Factory interface for creating Bitmovin API client instances
    /// </summary>
    public interface IBitmovinApiClientFactory
    {
        /// <summary>
        /// Creates a typed REST client instance
        /// </summary>
        /// <typeparam name="T">The client interface type</typeparam>
        /// <returns>The typed client instance</returns>
        T CreateClient<T>();
    }
}
