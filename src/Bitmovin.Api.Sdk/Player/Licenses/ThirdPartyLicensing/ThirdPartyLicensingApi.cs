using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.Licenses.ThirdPartyLicensing
{
    public class ThirdPartyLicensingApi
    {
        private readonly IThirdPartyLicensingApiClient _apiClient;

        public ThirdPartyLicensingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IThirdPartyLicensingApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ThirdPartyLicensingApi
        /// </summary>
        public static BitmovinApiBuilder<ThirdPartyLicensingApi> Builder => new BitmovinApiBuilder<ThirdPartyLicensingApi>();

        /// <summary>
        /// Enable Third Party Licensing
        /// </summary>
        /// <param name="licenseId">Id of the Player License (required)</param>
        /// <param name="playerThirdPartyLicensing">Third Party Licensing settings to apply to Player License</param>
        public async Task<Models.PlayerThirdPartyLicensing> CreateAsync(string licenseId, Models.PlayerThirdPartyLicensing playerThirdPartyLicensing)
        {
            return await _apiClient.CreateAsync(licenseId, playerThirdPartyLicensing);
        }

        /// <summary>
        /// Delete Third Party Licensing Configuration
        /// </summary>
        /// <param name="licenseId">Id of the Player License (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string licenseId)
        {
            return await _apiClient.DeleteAsync(licenseId);
        }

        /// <summary>
        /// Get Third Party Licensing Configuration
        /// </summary>
        /// <param name="licenseId">Id of the Player License (required)</param>
        public async Task<Models.PlayerThirdPartyLicensing> GetAsync(string licenseId)
        {
            return await _apiClient.GetAsync(licenseId);
        }

        internal interface IThirdPartyLicensingApiClient
        {
            [Post("/player/licenses/{license_id}/third-party-licensing")]
            [AllowAnyStatusCode]
            Task<Models.PlayerThirdPartyLicensing> CreateAsync([Path("license_id")] string licenseId, [Body] Models.PlayerThirdPartyLicensing playerThirdPartyLicensing);

            [Delete("/player/licenses/{license_id}/third-party-licensing")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("license_id")] string licenseId);

            [Get("/player/licenses/{license_id}/third-party-licensing")]
            [AllowAnyStatusCode]
            Task<Models.PlayerThirdPartyLicensing> GetAsync([Path("license_id")] string licenseId);
        }
    }
}
