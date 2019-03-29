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
    /// Thumbnail
    /// </summary>

    public class Thumbnail : BitmovinResource
    {
        /// <summary>
        /// Height of the thumbnail
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }
        
        /// <summary>
        ///  Pattern which describes the thumbnail filenames. For example with thumbnail-%number%.png as pattern and 3 positions: thumbnail-3_0.png, thumbnail-5_0.png and thumbnail-25_5.png. (The number represents the position in the source video in seconds, in the previous example the first filename represents the thumbnail at 3s, the second one at 5s and the third one at 25.5s)
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }
        
        /// <summary>
        /// Position in the unit where the thumbnail should be created from.
        /// </summary>
        [JsonProperty(PropertyName = "positions")]
        public List<double?> Positions { get; set; }
        
        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; }
        
        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public ThumbnailUnit Unit { get; set; }
    }

}
