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
    /// Credits
    /// </summary>
    public class Credits
    {
        /// <summary>
        /// Selected people identified in the video credits.
        /// </summary>
        [JsonProperty(PropertyName = "persons")]
        public List<Person> Persons { get; set; } = new List<Person>();

        /// <summary>
        /// Songs extracted from recognized credit text, such as opening, ending or insert songs. This is not a list of all music heard in the video.
        /// </summary>
        [JsonProperty(PropertyName = "songs")]
        public List<Song> Songs { get; set; } = new List<Song>();

        /// <summary>
        /// Production copyright year extracted from on-screen credits. Empty, null or omitted when unavailable. This is not the full copyright notice or a determination of rights or licensing. Retains its original value in language-specific results.
        /// </summary>
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }
    }
}
