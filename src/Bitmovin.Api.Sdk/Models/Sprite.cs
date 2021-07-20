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
        /// Height of one thumbnail, either height or width are required fields. If only one is given the encoder will calculate the other way value based on the aspect ratio of the video file. If the encoder version is below 2.83.0 both are required 
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of one thumbnail, either height or width are required fields. If only one is given the encoder will calculate the other way value based on the aspect ratio of the video file. If the encoder version is below 2.83.0 both are required 
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
        /// Name of the sprite image. File extension \&quot;.jpg\&quot;/\&quot;.jpeg\&quot; or \&quot;.png\&quot; is required. (required)
        /// </summary>
        [JsonProperty(PropertyName = "spriteName")]
        public string SpriteName { get; set; }

        /// <summary>
        /// Filename of the sprite image. If not set, spriteName will be used, but without an extension.
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Filename of the vtt-file. The file-extension \&quot;.vtt\&quot; is required.
        /// </summary>
        [JsonProperty(PropertyName = "vttName")]
        public string VttName { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();

        /// <summary>
        /// Number of images per file. If more images are generated than specified in this value, multiple sprites will be created. You can use the placeholder &#39;%number%&#39; in the spriteName to specify the naming policy. Either this property must be set or hTiles and vTiles. 
        /// </summary>
        [JsonProperty(PropertyName = "imagesPerFile")]
        public int? ImagesPerFile { get; set; }

        /// <summary>
        /// Number of rows of images per file.  Has to be set together with vTiles. If this property and vTiles are set, the imagesPerFile property must not be set.  It is recommended to use the placeholder &#39;%number%&#39; in the spriteName to allow the generation of multiple sprites.  Only supported starting with encoder version &#x60;2.76.0&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "hTiles")]
        public int? HTiles { get; set; }

        /// <summary>
        /// Number of columns of images per file.  Has to be set together with hTiles. If this property and hTiles are set, the imagesPerFile property must not be set.  It is recommended to use the placeholder &#39;%number%&#39; in the spriteName to allow the generation of multiple sprites.  Only supported starting with encoder version &#x60;2.76.0&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "vTiles")]
        public int? VTiles { get; set; }

        /// <summary>
        /// Additional configuration for JPEG sprite generation.  If this property is set the extension of the file must be &#39;.jpg.&#39; or &#39;.jpeg&#39;  Only supported starting with encoder version &#x60;2.76.0&#x60; 
        /// </summary>
        [JsonProperty(PropertyName = "jpegConfig")]
        public SpriteJpegConfig JpegConfig { get; set; }

        /// <summary>
        /// The creation mode for the thumbnails in the Sprite.  Two possible creation modes exist: generate thumbnails starting with the beginning of the video or after the first configured period.  When using distance&#x3D;10 and unit&#x3D;SECONDS and INTERVAL_END, the first image of the sprite is from the second 10 of the video. When using distance&#x3D;10 and unit&#x3D;SECONDS and INTERVAL_START, the first image of the sprite is from the very start of the video, while the second image is from second 10 of the video.  It is recommended to use &#39;INTERVAL_START&#39; when using the sprites for trick play so that there is an additional thumbnail from the beginning of the video.  Only supported starting with encoder version &#x60;2.76.0&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "creationMode")]
        public SpriteCreationMode? CreationMode { get; set; }

        /// <summary>
        /// Specifies the aspect mode that is used when both height and width are specified Only supported starting with encoder version &#x60;2.85.0&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "aspectMode")]
        public ThumbnailAspectMode? AspectMode { get; set; }
    }
}
