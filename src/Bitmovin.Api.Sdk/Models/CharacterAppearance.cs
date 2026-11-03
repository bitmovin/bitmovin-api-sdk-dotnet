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
    /// Visible appearance of a character. Text fields use an open vocabulary; spelling, case and unknown-value wording can vary.
    /// </summary>
    public class CharacterAppearance
    {
        /// <summary>
        /// Summary of the character&#39;s visible appearance.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Apparent gender, described in free text.
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The approximate age range of the character
        /// </summary>
        [JsonProperty(PropertyName = "approximateAge")]
        public AgeRange? ApproximateAge { get; set; }

        /// <summary>
        /// Hair color.
        /// </summary>
        [JsonProperty(PropertyName = "hairColor")]
        public string HairColor { get; set; }

        /// <summary>
        /// Hairstyle.
        /// </summary>
        [JsonProperty(PropertyName = "hairStyle")]
        public string HairStyle { get; set; }

        /// <summary>
        /// Hair fullness or coverage.
        /// </summary>
        [JsonProperty(PropertyName = "hairFullness")]
        public string HairFullness { get; set; }

        /// <summary>
        /// Facial hair. Can be empty when no description is available.
        /// </summary>
        [JsonProperty(PropertyName = "facialHair")]
        public string FacialHair { get; set; }

        /// <summary>
        /// The character&#39;s physical build.
        /// </summary>
        [JsonProperty(PropertyName = "physicalBuild")]
        public string PhysicalBuild { get; set; }

        /// <summary>
        /// Distinctive visible features, such as glasses or markings.
        /// </summary>
        [JsonProperty(PropertyName = "distinguishingFeatures")]
        public string DistinguishingFeatures { get; set; }

        /// <summary>
        /// The character&#39;s clothing.
        /// </summary>
        [JsonProperty(PropertyName = "clothing")]
        public string Clothing { get; set; }
    }
}
