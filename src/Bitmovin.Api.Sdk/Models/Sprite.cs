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
    /// Sprite
    /// </summary>

    public class Sprite : BitmovinResource
    {
        /// <summary>
        /// Height of one thumbnail (required)
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }
        
        /// <summary>
        /// Width of one thumbnail (required)
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }
        
        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public SpriteUnit? Unit { get; set; }
        
        /// <summary>
        /// Distance in the given unit between a screenshot
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public double? Distance { get; set; }
        
        /// <summary>
        /// Name of the sprite image. File extension \&quot;.jpg\&quot; or \&quot;.png\&quot; is required. (required)
        /// </summary>
        [JsonProperty(PropertyName = "spriteName")]
        public string SpriteName { get; set; }
        
        /// <summary>
        /// Filename of the sprite image. If not set, spriteName will be used, but without an extension.
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <summary>
        /// Filename of the vtt-file. The file-extension \&quot;.vtt\&quot; is required. (required)
        /// </summary>
        [JsonProperty(PropertyName = "vttName")]
        public string VttName { get; set; }
        
        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();
        
        /// <summary>
        /// Number of images per file. If more images are generated than specified in this value, multiple sprites will be created. You can use the placeholder &#39;%number%&#39; in the spriteName to specify the naming policy.
        /// </summary>
        [JsonProperty(PropertyName = "imagesPerFile")]
        public int? ImagesPerFile { get; set; }
    }

}
