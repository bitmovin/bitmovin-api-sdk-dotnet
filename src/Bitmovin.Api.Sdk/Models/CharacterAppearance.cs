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
    /// CharacterAppearance
    /// </summary>
    public class CharacterAppearance
    {
        /// <summary>
        /// Summary
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The approximate age range of the character
        /// </summary>
        [JsonProperty(PropertyName = "approximateAge")]
        public AgeRange? ApproximateAge { get; set; }

        /// <summary>
        /// HairColor
        /// </summary>
        [JsonProperty(PropertyName = "hairColor")]
        public string HairColor { get; set; }

        /// <summary>
        /// HairStyle
        /// </summary>
        [JsonProperty(PropertyName = "hairStyle")]
        public string HairStyle { get; set; }

        /// <summary>
        /// HairFullness
        /// </summary>
        [JsonProperty(PropertyName = "hairFullness")]
        public string HairFullness { get; set; }

        /// <summary>
        /// FacialHair
        /// </summary>
        [JsonProperty(PropertyName = "facialHair")]
        public string FacialHair { get; set; }

        /// <summary>
        /// PhysicalBuild
        /// </summary>
        [JsonProperty(PropertyName = "physicalBuild")]
        public string PhysicalBuild { get; set; }

        /// <summary>
        /// DistinguishingFeatures
        /// </summary>
        [JsonProperty(PropertyName = "distinguishingFeatures")]
        public string DistinguishingFeatures { get; set; }

        /// <summary>
        /// Clothing
        /// </summary>
        [JsonProperty(PropertyName = "clothing")]
        public string Clothing { get; set; }
    }
}
