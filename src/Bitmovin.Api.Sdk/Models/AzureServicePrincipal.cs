using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Azure service principal credentials for Microsoft Entra ID authentication
    /// </summary>
    public class AzureServicePrincipal
    {
        /// <summary>
        /// Tenant ID (Directory ID) of the Azure service principal (required)
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Client ID of the Azure service principal (required)
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret of the Azure service principal
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// PEM-encoded client certificate and private key of the Azure service principal. Newline symbols must be preserved.
        /// </summary>
        [JsonProperty(PropertyName = "clientCertificate")]
        public string ClientCertificate { get; set; }
    }
}
