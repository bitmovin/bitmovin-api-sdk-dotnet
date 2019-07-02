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
    /// AnalyticsImpressionDetails
    /// </summary>

    public class AnalyticsImpressionDetails : BitmovinResponse
    {
        /// <summary>
        /// Is an ad playing. 0 indicates no, 1 indicates yes
        /// </summary>
        [JsonProperty(PropertyName = "ad")]
        public long? Ad { get; set; }
        
        /// <summary>
        /// Collector version
        /// </summary>
        [JsonProperty(PropertyName = "analyticsVersion")]
        public string AnalyticsVersion { get; set; }
        
        /// <summary>
        /// Autonomous System Number inferred from the IP address
        /// </summary>
        [JsonProperty(PropertyName = "asn")]
        public long? Asn { get; set; }
        
        /// <summary>
        /// Audio Bitrate
        /// </summary>
        [JsonProperty(PropertyName = "audioBitrate")]
        public long? AudioBitrate { get; set; }
        
        /// <summary>
        /// Autoplay enabled
        /// </summary>
        [JsonProperty(PropertyName = "autoplay")]
        public bool? Autoplay { get; set; }
        
        /// <summary>
        /// Browser name
        /// </summary>
        [JsonProperty(PropertyName = "browser")]
        public string Browser { get; set; }
        
        /// <summary>
        /// Browser version major
        /// </summary>
        [JsonProperty(PropertyName = "browserVersionMajor")]
        public string BrowserVersionMajor { get; set; }
        
        /// <summary>
        /// Browser version minor
        /// </summary>
        [JsonProperty(PropertyName = "browserVersionMinor")]
        public string BrowserVersionMinor { get; set; }
        
        /// <summary>
        /// Millisecond the player buffered
        /// </summary>
        [JsonProperty(PropertyName = "buffered")]
        public long? Buffered { get; set; }
        
        /// <summary>
        /// CDN Provider
        /// </summary>
        [JsonProperty(PropertyName = "cdnProvider")]
        public string CdnProvider { get; set; }
        
        /// <summary>
        /// City
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        
        /// <summary>
        /// Current time of the client
        /// </summary>
        [JsonProperty(PropertyName = "clientTime")]
        public long? ClientTime { get; set; }
        
        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <summary>
        /// Custom user ID
        /// </summary>
        [JsonProperty(PropertyName = "customUserId")]
        public string CustomUserId { get; set; }
        
        /// <summary>
        /// Free form data set via the customData1 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "customData1")]
        public string CustomData1 { get; set; }
        
        /// <summary>
        /// Free form data set via the customData2 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "customData2")]
        public string CustomData2 { get; set; }
        
        /// <summary>
        /// Free form data set via the customData3 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "customData3")]
        public string CustomData3 { get; set; }
        
        /// <summary>
        /// Free form data set via the customData4 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "customData4")]
        public string CustomData4 { get; set; }
        
        /// <summary>
        /// Free form data set via the customData5 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "customData5")]
        public string CustomData5 { get; set; }
        
        /// <summary>
        /// Type of the device detected via User Agent
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }
        
        /// <summary>
        /// Domain the player was loaded on (.www is stripped away)
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <summary>
        /// Time in milliseconds it took the DRM server to respond
        /// </summary>
        [JsonProperty(PropertyName = "drmLoadTime")]
        public long? DrmLoadTime { get; set; }
        
        /// <summary>
        /// DRM system used for this impression
        /// </summary>
        [JsonProperty(PropertyName = "drmType")]
        public string DrmType { get; set; }
        
        /// <summary>
        /// Dropped frames during playback
        /// </summary>
        [JsonProperty(PropertyName = "droppedFrames")]
        public long? DroppedFrames { get; set; }
        
        /// <summary>
        /// Duration of the sample in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }
        
        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; set; }
        
        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <summary>
        /// A/B test experiment name
        /// </summary>
        [JsonProperty(PropertyName = "experimentName")]
        public string ExperimentName { get; set; }
        
        /// <summary>
        /// Random UUID that is used to identify a sessions (required)
        /// </summary>
        [JsonProperty(PropertyName = "impressionId")]
        public string ImpressionId { get; set; }
        
        /// <summary>
        /// IP Address of the client
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <summary>
        /// Is chromecast active
        /// </summary>
        [JsonProperty(PropertyName = "isCasting")]
        public bool? IsCasting { get; set; }
        
        /// <summary>
        /// Is the stream live or VoD
        /// </summary>
        [JsonProperty(PropertyName = "isLive")]
        public bool? IsLive { get; set; }
        
        /// <summary>
        /// Is the player muted
        /// </summary>
        [JsonProperty(PropertyName = "isMuted")]
        public bool? IsMuted { get; set; }
        
        /// <summary>
        /// The users Internet Service Provider inferred via the IP address
        /// </summary>
        [JsonProperty(PropertyName = "isp")]
        public string Isp { get; set; }
        
        /// <summary>
        /// Language set in the browser
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        /// <summary>
        /// Analytics license key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
        
        /// <summary>
        /// Operating system
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; set; }
        
        /// <summary>
        /// Operating system version major
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystemVersionMajor")]
        public string OperatingSystemVersionMajor { get; set; }
        
        /// <summary>
        /// Operating system version minor
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystemVersionMinor")]
        public string OperatingSystemVersionMinor { get; set; }
        
        /// <summary>
        /// Time in milliseconds the page took to load
        /// </summary>
        [JsonProperty(PropertyName = "pageLoadTime")]
        public int? PageLoadTime { get; set; }
        
        /// <summary>
        /// Player load type. 1 &#x3D; Foreground, 2 &#x3D; Background
        /// </summary>
        [JsonProperty(PropertyName = "pageLoadType")]
        public int? PageLoadType { get; set; }
        
        /// <summary>
        /// path on the website
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <summary>
        /// Milliseconds the player was paused
        /// </summary>
        [JsonProperty(PropertyName = "paused")]
        public long? Paused { get; set; }
        
        /// <summary>
        /// Platform the player is running on (web, android, ios)
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }
        
        /// <summary>
        /// Milliseconds the player played
        /// </summary>
        [JsonProperty(PropertyName = "played")]
        public long? Played { get; set; }
        
        /// <summary>
        /// Video player being used for this session
        /// </summary>
        [JsonProperty(PropertyName = "player")]
        public string Player { get; set; }
        
        /// <summary>
        /// Player license key
        /// </summary>
        [JsonProperty(PropertyName = "playerKey")]
        public string PlayerKey { get; set; }
        
        /// <summary>
        /// Time in milliseconds the player took to start up
        /// </summary>
        [JsonProperty(PropertyName = "playerStartuptime")]
        public int? PlayerStartuptime { get; set; }
        
        /// <summary>
        /// HTML or native playback
        /// </summary>
        [JsonProperty(PropertyName = "playerTech")]
        public string PlayerTech { get; set; }
        
        /// <summary>
        /// Player software version
        /// </summary>
        [JsonProperty(PropertyName = "playerVersion")]
        public string PlayerVersion { get; set; }
        
        /// <summary>
        /// Geographic region (ISO 3166-2 code)
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <summary>
        /// Screen as reported by the browser
        /// </summary>
        [JsonProperty(PropertyName = "screenHeight")]
        public int? ScreenHeight { get; set; }
        
        /// <summary>
        /// Screen as reported by the browser
        /// </summary>
        [JsonProperty(PropertyName = "screenWidth")]
        public int? ScreenWidth { get; set; }
        
        /// <summary>
        /// Milliseconds it took the player to seek
        /// </summary>
        [JsonProperty(PropertyName = "seeked")]
        public long? Seeked { get; set; }
        
        /// <summary>
        /// Sequence number of the sample in which it occured in the session
        /// </summary>
        [JsonProperty(PropertyName = "sequenceNumber")]
        public long? SequenceNumber { get; set; }
        
        /// <summary>
        /// Video size (FULLSCREEN or WINDOW)
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }
        
        /// <summary>
        /// Combination of player- and videoStartuptime
        /// </summary>
        [JsonProperty(PropertyName = "startupTime")]
        public int? StartupTime { get; set; }
        
        /// <summary>
        /// Internal state of the analytics state machine
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        
        /// <summary>
        /// Format of the stream (HLS, DASH, Progressive MP4)
        /// </summary>
        [JsonProperty(PropertyName = "streamFormat")]
        public string StreamFormat { get; set; }
        
        /// <summary>
        /// Current time in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public long? Time { get; set; }
        
        /// <summary>
        /// ID that is persisted across sessions to identify a browser
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <summary>
        /// Bitrate of the played back video rendition
        /// </summary>
        [JsonProperty(PropertyName = "videoBitrate")]
        public long? VideoBitrate { get; set; }
        
        /// <summary>
        /// Length of the video in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "videoDuration")]
        public long? VideoDuration { get; set; }
        
        /// <summary>
        /// ID of the video as configured via the analytics config
        /// </summary>
        [JsonProperty(PropertyName = "videoId")]
        public string VideoId { get; set; }
        
        /// <summary>
        /// Free form human readable video title as configured in the analytics config
        /// </summary>
        [JsonProperty(PropertyName = "videoTitle")]
        public string VideoTitle { get; set; }
        
        /// <summary>
        /// Resolution of the played back Video Rendition
        /// </summary>
        [JsonProperty(PropertyName = "videoPlaybackHeight")]
        public int? VideoPlaybackHeight { get; set; }
        
        /// <summary>
        /// Resolution of the played back Video Rendition
        /// </summary>
        [JsonProperty(PropertyName = "videoPlaybackWidth")]
        public int? VideoPlaybackWidth { get; set; }
        
        /// <summary>
        /// Time in milliseconds it took to start video playback
        /// </summary>
        [JsonProperty(PropertyName = "videoStartupTime")]
        public long? VideoStartupTime { get; set; }
        
        /// <summary>
        /// End time of the sample in the video (milliseconds)
        /// </summary>
        [JsonProperty(PropertyName = "videotimeEnd")]
        public long? VideotimeEnd { get; set; }
        
        /// <summary>
        /// Start time of the sample in the video (milliseconds)
        /// </summary>
        [JsonProperty(PropertyName = "videotimeStart")]
        public long? VideotimeStart { get; set; }
        
        /// <summary>
        /// Height of the video player on the page
        /// </summary>
        [JsonProperty(PropertyName = "videoWindowHeight")]
        public int? VideoWindowHeight { get; set; }
        
        /// <summary>
        /// Width of the video player on the page
        /// </summary>
        [JsonProperty(PropertyName = "videoWindowWidth")]
        public int? VideoWindowWidth { get; set; }
    }

}
