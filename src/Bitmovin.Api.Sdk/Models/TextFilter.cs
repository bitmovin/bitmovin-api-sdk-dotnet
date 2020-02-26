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
    /// Only one of those properties may be set: fontSize, fontSizeExpression.
    /// </summary>
    public class TextFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "TEXT";

        /// <summary>
        /// Font
        /// </summary>
        [JsonProperty(PropertyName = "font")]
        public TextFilterFont? Font { get; set; }

        /// <summary>
        /// If set to true a box is drawn around the text using the background color.
        /// </summary>
        [JsonProperty(PropertyName = "box")]
        public bool? Box { get; set; }

        /// <summary>
        /// The width of the box drawn around the text.
        /// </summary>
        [JsonProperty(PropertyName = "boxBorderWidth")]
        public int? BoxBorderWidth { get; set; }

        /// <summary>
        /// The background color to be used for drawing the box.
        /// </summary>
        [JsonProperty(PropertyName = "boxColor")]
        public string BoxColor { get; set; }

        /// <summary>
        /// Line spacing of the border around the box in pixels
        /// </summary>
        [JsonProperty(PropertyName = "lineSpacing")]
        public int? LineSpacing { get; set; }

        /// <summary>
        /// Width of the border around the text
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int? BorderWidth { get; set; }

        /// <summary>
        /// If set to true, it will fix text coordinates to avoid clipping if necessary
        /// </summary>
        [JsonProperty(PropertyName = "fixBounds")]
        public bool? FixBounds { get; set; }

        /// <summary>
        /// The color to be used to draw the text
        /// </summary>
        [JsonProperty(PropertyName = "fontColor")]
        public string FontColor { get; set; }

        /// <summary>
        /// Font size to be used to draw the text
        /// </summary>
        [JsonProperty(PropertyName = "fontSize")]
        public int? FontSize { get; set; }

        /// <summary>
        /// An expression for the Font size. Either fontSize or fontSizeExpression can be set at the same time. The following variables are valid: main_h, h, H for input height and main_w, w, W for the input_width
        /// </summary>
        [JsonProperty(PropertyName = "fontSizeExpression")]
        public string FontSizeExpression { get; set; }

        /// <summary>
        /// If set, alpha blending for the text is applied. Values are valid between 0.0 and 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "alpha")]
        public int? Alpha { get; set; }

        /// <summary>
        /// Color of the shadow
        /// </summary>
        [JsonProperty(PropertyName = "shadowColor")]
        public string ShadowColor { get; set; }

        /// <summary>
        /// X offset of the shadow
        /// </summary>
        [JsonProperty(PropertyName = "shadowX")]
        public int? ShadowX { get; set; }

        /// <summary>
        /// Y offset of the shadow
        /// </summary>
        [JsonProperty(PropertyName = "shadowY")]
        public int? ShadowY { get; set; }

        /// <summary>
        /// If set, the timecode representation in \&quot;hh:mm:ss[:;.]ff\&quot; format will be applied
        /// </summary>
        [JsonProperty(PropertyName = "timecode")]
        public string Timecode { get; set; }

        /// <summary>
        /// String to be drawn
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// X position of the text. Also an expression can be used. The following variables are valid: line_h - height of each text line; main_h - input height; main_w - input width; n - number of input frame; text_h - Text height; text_w - Text width (required)
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public string X { get; set; }

        /// <summary>
        /// Y position of the text. Also an expression can be used. The following variables are valid: line_h - height of each text line; main_h - input height; main_w - input width; n - number of input frame; text_h - Text height; text_w - Text width (required)
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public string Y { get; set; }
    }
}
