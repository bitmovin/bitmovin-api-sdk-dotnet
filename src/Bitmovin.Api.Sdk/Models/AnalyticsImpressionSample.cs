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
    /// AnalyticsImpressionSample
    /// </summary>
    public class AnalyticsImpressionSample
    {
        /// <summary>
        /// Is an ad playing. 0 indicates no, 1 indicates yes
        /// </summary>
        [JsonProperty(PropertyName = "ad")]
        public long? Ad { get; set; }

        /// <summary>
        /// Collector version
        /// </summary>
        [JsonProperty(PropertyName = "analytics_version")]
        public string AnalyticsVersion { get; set; }

        /// <summary>
        /// Audio Bitrate
        /// </summary>
        [JsonProperty(PropertyName = "audio_bitrate")]
        public long? AudioBitrate { get; set; }

        /// <summary>
        /// Audio codec of currently playing stream
        /// </summary>
        [JsonProperty(PropertyName = "audio_codec")]
        public string AudioCodec { get; set; }

        /// <summary>
        /// Selected audio language
        /// </summary>
        [JsonProperty(PropertyName = "audio_language")]
        public string AudioLanguage { get; set; }

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
        [JsonProperty(PropertyName = "browser_version_major")]
        public string BrowserVersionMajor { get; set; }

        /// <summary>
        /// Browser version minor
        /// </summary>
        [JsonProperty(PropertyName = "browser_version_minor")]
        public string BrowserVersionMinor { get; set; }

        /// <summary>
        /// Milliseconds the player buffered
        /// </summary>
        [JsonProperty(PropertyName = "buffered")]
        public long? Buffered { get; set; }

        /// <summary>
        /// CDN Provider
        /// </summary>
        [JsonProperty(PropertyName = "cdn_provider")]
        public string CdnProvider { get; set; }

        /// <summary>
        /// Casting Technology
        /// </summary>
        [JsonProperty(PropertyName = "cast_tech")]
        public string CastTech { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Current time of the client
        /// </summary>
        [JsonProperty(PropertyName = "client_time")]
        public long? ClientTime { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Custom user ID
        /// </summary>
        [JsonProperty(PropertyName = "custom_user_id")]
        public string CustomUserId { get; set; }

        /// <summary>
        /// Free form data set via the customData1 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_1")]
        public string CustomData1 { get; set; }

        /// <summary>
        /// Free form data set via the customData2 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_2")]
        public string CustomData2 { get; set; }

        /// <summary>
        /// Free form data set via the customData3 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_3")]
        public string CustomData3 { get; set; }

        /// <summary>
        /// Free form data set via the customData4 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_4")]
        public string CustomData4 { get; set; }

        /// <summary>
        /// Free form data set via the customData5 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_5")]
        public string CustomData5 { get; set; }

        /// <summary>
        /// Free form data set via the customData6 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_6")]
        public string CustomData6 { get; set; }

        /// <summary>
        /// Free form data set via the customData7 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_7")]
        public string CustomData7 { get; set; }

        /// <summary>
        /// Free form data set via the customData8 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_8")]
        public string CustomData8 { get; set; }

        /// <summary>
        /// Free form data set via the customData9 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_9")]
        public string CustomData9 { get; set; }

        /// <summary>
        /// Free form data set via the customData10 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_10")]
        public string CustomData10 { get; set; }

        /// <summary>
        /// Free form data set via the customData11 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_11")]
        public string CustomData11 { get; set; }

        /// <summary>
        /// Free form data set via the customData12 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_12")]
        public string CustomData12 { get; set; }

        /// <summary>
        /// Free form data set via the customData13 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_13")]
        public string CustomData13 { get; set; }

        /// <summary>
        /// Free form data set via the customData14 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_14")]
        public string CustomData14 { get; set; }

        /// <summary>
        /// Free form data set via the customData15 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_15")]
        public string CustomData15 { get; set; }

        /// <summary>
        /// Free form data set via the customData16 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_16")]
        public string CustomData16 { get; set; }

        /// <summary>
        /// Free form data set via the customData17 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_17")]
        public string CustomData17 { get; set; }

        /// <summary>
        /// Free form data set via the customData18 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_18")]
        public string CustomData18 { get; set; }

        /// <summary>
        /// Free form data set via the customData19 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_19")]
        public string CustomData19 { get; set; }

        /// <summary>
        /// Free form data set via the customData20 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_20")]
        public string CustomData20 { get; set; }

        /// <summary>
        /// Free form data set via the customData21 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_21")]
        public string CustomData21 { get; set; }

        /// <summary>
        /// Free form data set via the customData22 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_22")]
        public string CustomData22 { get; set; }

        /// <summary>
        /// Free form data set via the customData23 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_23")]
        public string CustomData23 { get; set; }

        /// <summary>
        /// Free form data set via the customData24 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_24")]
        public string CustomData24 { get; set; }

        /// <summary>
        /// Free form data set via the customData25 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_25")]
        public string CustomData25 { get; set; }

        /// <summary>
        /// Free form data set via the customData26 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_26")]
        public string CustomData26 { get; set; }

        /// <summary>
        /// Free form data set via the customData27 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_27")]
        public string CustomData27 { get; set; }

        /// <summary>
        /// Free form data set via the customData28 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_28")]
        public string CustomData28 { get; set; }

        /// <summary>
        /// Free form data set via the customData29 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_29")]
        public string CustomData29 { get; set; }

        /// <summary>
        /// Free form data set via the customData30 field in the analytics collector configuration
        /// </summary>
        [JsonProperty(PropertyName = "custom_data_30")]
        public string CustomData30 { get; set; }

        /// <summary>
        /// Type of device (Desktop, Phone, Tablet)
        /// </summary>
        [JsonProperty(PropertyName = "device_class")]
        public string DeviceClass { get; set; }

        /// <summary>
        /// Type of the device detected via User Agent
        /// </summary>
        [JsonProperty(PropertyName = "device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// Domain the player was loaded on (.www is stripped away)
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Time in milliseconds it took the DRM server to respond
        /// </summary>
        [JsonProperty(PropertyName = "drm_load_time")]
        public long? DrmLoadTime { get; set; }

        /// <summary>
        /// DRM system used for this impression
        /// </summary>
        [JsonProperty(PropertyName = "drm_type")]
        public string DrmType { get; set; }

        /// <summary>
        /// Dropped frames during playback
        /// </summary>
        [JsonProperty(PropertyName = "dropped_frames")]
        public long? DroppedFrames { get; set; }

        /// <summary>
        /// Duration of the sample in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// A/B test experiment name
        /// </summary>
        [JsonProperty(PropertyName = "experiment_name")]
        public string ExperimentName { get; set; }

        /// <summary>
        /// Random UUID that is used to identify a session (required)
        /// </summary>
        [JsonProperty(PropertyName = "impression_id")]
        public string ImpressionId { get; set; }

        /// <summary>
        /// IP Address of the client
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Is chromecast active
        /// </summary>
        [JsonProperty(PropertyName = "is_casting")]
        public bool? IsCasting { get; set; }

        /// <summary>
        /// Is the stream live or VoD
        /// </summary>
        [JsonProperty(PropertyName = "is_live")]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Is the player muted
        /// </summary>
        [JsonProperty(PropertyName = "is_muted")]
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
        [JsonProperty(PropertyName = "license_key")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// URL of the HLS source
        /// </summary>
        [JsonProperty(PropertyName = "m3u8_url")]
        public string M3u8Url { get; set; }

        /// <summary>
        /// URL of the DASH source
        /// </summary>
        [JsonProperty(PropertyName = "mpd_url")]
        public string MpdUrl { get; set; }

        /// <summary>
        /// Operating system
        /// </summary>
        [JsonProperty(PropertyName = "operatingsystem")]
        public string Operatingsystem { get; set; }

        /// <summary>
        /// Operating system version major
        /// </summary>
        [JsonProperty(PropertyName = "operatingsystem_version_major")]
        public string OperatingsystemVersionMajor { get; set; }

        /// <summary>
        /// Operating system version minor
        /// </summary>
        [JsonProperty(PropertyName = "operatingsystem_version_minor")]
        public string OperatingsystemVersionMinor { get; set; }

        /// <summary>
        /// Time in milliseconds the page took to load
        /// </summary>
        [JsonProperty(PropertyName = "page_load_time")]
        public int? PageLoadTime { get; set; }

        /// <summary>
        /// Player load type. 1 &#x3D; Foreground, 2 &#x3D; Background
        /// </summary>
        [JsonProperty(PropertyName = "page_load_type")]
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
        [JsonProperty(PropertyName = "player_key")]
        public string PlayerKey { get; set; }

        /// <summary>
        /// Time in milliseconds the player took to start up
        /// </summary>
        [JsonProperty(PropertyName = "player_startuptime")]
        public int? PlayerStartuptime { get; set; }

        /// <summary>
        /// HTML or native playback
        /// </summary>
        [JsonProperty(PropertyName = "player_tech")]
        public string PlayerTech { get; set; }

        /// <summary>
        /// Player software version
        /// </summary>
        [JsonProperty(PropertyName = "player_version")]
        public string PlayerVersion { get; set; }

        /// <summary>
        /// URL of the progressive MP4 source
        /// </summary>
        [JsonProperty(PropertyName = "prog_url")]
        public string ProgUrl { get; set; }

        /// <summary>
        /// Geographic region (ISO 3166-2 code)
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Screen as reported by the browser
        /// </summary>
        [JsonProperty(PropertyName = "screen_height")]
        public int? ScreenHeight { get; set; }

        /// <summary>
        /// Screen as reported by the browser
        /// </summary>
        [JsonProperty(PropertyName = "screen_width")]
        public int? ScreenWidth { get; set; }

        /// <summary>
        /// Milliseconds it took the player to seek
        /// </summary>
        [JsonProperty(PropertyName = "seeked")]
        public long? Seeked { get; set; }

        /// <summary>
        /// Number of video segments downloaded
        /// </summary>
        [JsonProperty(PropertyName = "segment_download_count")]
        public int? SegmentDownloadCount { get; set; }

        /// <summary>
        /// Size of downloaded video segments (byte)
        /// </summary>
        [JsonProperty(PropertyName = "segment_download_size")]
        public int? SegmentDownloadSize { get; set; }

        /// <summary>
        /// Cumulative time needed to download video segments
        /// </summary>
        [JsonProperty(PropertyName = "segment_download_time")]
        public int? SegmentDownloadTime { get; set; }

        /// <summary>
        /// Sequence number of the sample in which it occurred in the session
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public long? SequenceNumber { get; set; }

        /// <summary>
        /// Video size (FULLSCREEN or WINDOW)
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Combination of player- and videoStartuptime
        /// </summary>
        [JsonProperty(PropertyName = "startuptime")]
        public int? Startuptime { get; set; }

        /// <summary>
        /// Internal state of the analytics state machine
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Format of the stream (HLS, DASH, Progressive MP4)
        /// </summary>
        [JsonProperty(PropertyName = "stream_format")]
        public string StreamFormat { get; set; }

        /// <summary>
        /// Subtitle enabled
        /// </summary>
        [JsonProperty(PropertyName = "subtitle_enabled")]
        public bool? SubtitleEnabled { get; set; }

        /// <summary>
        /// Selected subtitle language
        /// </summary>
        [JsonProperty(PropertyName = "subtitle_language")]
        public string SubtitleLanguage { get; set; }

        /// <summary>
        /// Video codecs supported by platform/browser
        /// </summary>
        [JsonProperty(PropertyName = "supported_video_codes")]
        public List<string> SupportedVideoCodes { get; set; } = new List<string>();

        /// <summary>
        /// Current time in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public long? Time { get; set; }

        /// <summary>
        /// ID that is persisted across sessions to identify a browser
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Bitrate of the played back video rendition
        /// </summary>
        [JsonProperty(PropertyName = "video_bitrate")]
        public long? VideoBitrate { get; set; }

        /// <summary>
        /// Video codec of current stream
        /// </summary>
        [JsonProperty(PropertyName = "video_codec")]
        public string VideoCodec { get; set; }

        /// <summary>
        /// Length of the video in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "video_duration")]
        public long? VideoDuration { get; set; }

        /// <summary>
        /// ID of the video as configured via the analytics config
        /// </summary>
        [JsonProperty(PropertyName = "video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// Free form human readable video title as configured in the analytics config
        /// </summary>
        [JsonProperty(PropertyName = "video_title")]
        public string VideoTitle { get; set; }

        /// <summary>
        /// Resolution of the played back Video Rendition
        /// </summary>
        [JsonProperty(PropertyName = "video_playback_height")]
        public int? VideoPlaybackHeight { get; set; }

        /// <summary>
        /// Resolution of the played back Video Rendition
        /// </summary>
        [JsonProperty(PropertyName = "video_playback_width")]
        public int? VideoPlaybackWidth { get; set; }

        /// <summary>
        /// Time in milliseconds it took to start video playback
        /// </summary>
        [JsonProperty(PropertyName = "video_startuptime")]
        public long? VideoStartuptime { get; set; }

        /// <summary>
        /// End time of the sample in the video (milliseconds)
        /// </summary>
        [JsonProperty(PropertyName = "videotime_end")]
        public long? VideotimeEnd { get; set; }

        /// <summary>
        /// Start time of the sample in the video (milliseconds)
        /// </summary>
        [JsonProperty(PropertyName = "videotime_start")]
        public long? VideotimeStart { get; set; }

        /// <summary>
        /// Height of the video player on the page
        /// </summary>
        [JsonProperty(PropertyName = "video_window_height")]
        public int? VideoWindowHeight { get; set; }

        /// <summary>
        /// Width of the video player on the page
        /// </summary>
        [JsonProperty(PropertyName = "video_window_width")]
        public int? VideoWindowWidth { get; set; }

        /// <summary>
        /// True if starting the video failed
        /// </summary>
        [JsonProperty(PropertyName = "videostart_failed")]
        public bool? VideostartFailed { get; set; }

        /// <summary>
        /// Reason why starting the video failed
        /// </summary>
        [JsonProperty(PropertyName = "videostart_failed_reason")]
        public AnalyticsVideoStartFailedReason? VideostartFailedReason { get; set; }
    }
}
