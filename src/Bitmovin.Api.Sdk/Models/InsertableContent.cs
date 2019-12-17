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
    /// InsertableContent
    /// </summary>

    public class InsertableContent : BitmovinResource
    {
        /// <summary>
        /// Either a list of video files to be inserted in the live stream which have to match the codec, aspect ratio and frame rate of the live stream or a single image file. Supported image formats are: &#x60;.Y.U.V&#x60;, &#x60;Alias PIX&#x60;, &#x60;animated GIF&#x60;, &#x60;APNG&#x60;, &#x60;BMP&#x60;, &#x60;DPX&#x60;, &#x60;FITS&#x60;, &#x60;JPEG&#x60;, &#x60;JPEG 2000&#x60;, &#x60;JPEG-LS&#x60;, &#x60;PAM&#x60;, &#x60;PBM&#x60;, &#x60;PCX&#x60;, &#x60;PGM&#x60;, &#x60;PGMYUV&#x60;, &#x60;PNG&#x60;, &#x60;PPM&#x60;, &#x60;SGI&#x60;, &#x60;Sun Rasterfile&#x60;, &#x60;TIFF&#x60;, &#x60;Truevision Targa&#x60;, &#x60;WebP&#x60;, &#x60;XBM&#x60;, &#x60;XFace&#x60;, &#x60;XPM&#x60;, &#x60;XWD&#x60;
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public List<InsertableContentInput> Inputs { get; set; } = new List<InsertableContentInput>();
        
        /// <summary>
        /// Status of the insertable content.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InsertableContentStatus? Status { get; internal set; }
    }

}
