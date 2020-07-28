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
    /// ColorConfig
    /// </summary>
    public class ColorConfig
    {
        /// <summary>
        /// Copy the chroma location setting from the input source
        /// </summary>
        [JsonProperty(PropertyName = "copyChromaLocationFlag")]
        public bool? CopyChromaLocationFlag { get; set; }

        /// <summary>
        /// Copy the color space setting from the input source
        /// </summary>
        [JsonProperty(PropertyName = "copyColorSpaceFlag")]
        public bool? CopyColorSpaceFlag { get; set; }

        /// <summary>
        /// Copy the color primaries setting from the input source
        /// </summary>
        [JsonProperty(PropertyName = "copyColorPrimariesFlag")]
        public bool? CopyColorPrimariesFlag { get; set; }

        /// <summary>
        /// Copy the color range setting from the input source
        /// </summary>
        [JsonProperty(PropertyName = "copyColorRangeFlag")]
        public bool? CopyColorRangeFlag { get; set; }

        /// <summary>
        /// Copy the color transfer setting from the input source
        /// </summary>
        [JsonProperty(PropertyName = "copyColorTransferFlag")]
        public bool? CopyColorTransferFlag { get; set; }

        /// <summary>
        /// The chroma location to be applied
        /// </summary>
        [JsonProperty(PropertyName = "chromaLocation")]
        public ChromaLocation? ChromaLocation { get; set; }

        /// <summary>
        /// The color space to be applied. If used on a Dolby Vision stream, this value must be set to UNSPECIFIED.
        /// </summary>
        [JsonProperty(PropertyName = "colorSpace")]
        public ColorSpace? ColorSpace { get; set; }

        /// <summary>
        /// The color primaries to be applied. If used on a Dolby Vision stream, this value must be set to UNSPECIFIED.
        /// </summary>
        [JsonProperty(PropertyName = "colorPrimaries")]
        public ColorPrimaries? ColorPrimaries { get; set; }

        /// <summary>
        /// The color range to be applied. If used on a Dolby Vision stream, this value must be set to JPEG.
        /// </summary>
        [JsonProperty(PropertyName = "colorRange")]
        public ColorRange? ColorRange { get; set; }

        /// <summary>
        /// The color transfer to be applied. If used on a Dolby Vision stream, this value must be set to UNSPECIFIED.
        /// </summary>
        [JsonProperty(PropertyName = "colorTransfer")]
        public ColorTransfer? ColorTransfer { get; set; }

        /// <summary>
        /// Override the color space detected in the input file. If not set the input color space will be automatically detected if possible.
        /// </summary>
        [JsonProperty(PropertyName = "inputColorSpace")]
        public InputColorSpace? InputColorSpace { get; set; }

        /// <summary>
        /// Override the color range detected in the input file. If not set the input color range will be automatically detected if possible.
        /// </summary>
        [JsonProperty(PropertyName = "inputColorRange")]
        public InputColorRange? InputColorRange { get; set; }
    }
}
