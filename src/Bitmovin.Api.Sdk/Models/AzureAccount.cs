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
    /// AzureAccount
    /// </summary>
    public class AzureAccount : BitmovinResource
    {
        /// <summary>
        /// Your Azure Subscription ID (The ID of your subscription where you intend to run the Encoding VMs) (required)
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The name of the resource group where you intend to run the Encoding VMs (required)
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupId")]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of your Active Directory where your subscription runs in (required)
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
    }
}
