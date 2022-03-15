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
    /// AnalyticsAdsImpressionSample
    /// </summary>
    public class AnalyticsAdsImpressionSample
    {
        /// <summary>
        /// Ad click through url
        /// </summary>
        [JsonProperty(PropertyName = "ad_clickthrough_url")]
        public string AdClickthroughUrl { get; set; }

        /// <summary>
        /// Ad description
        /// </summary>
        [JsonProperty(PropertyName = "ad_description")]
        public string AdDescription { get; set; }

        /// <summary>
        /// Ad duration
        /// </summary>
        [JsonProperty(PropertyName = "ad_duration")]
        public long? AdDuration { get; set; }

        /// <summary>
        /// Ad fallback index
        /// </summary>
        [JsonProperty(PropertyName = "ad_fallback_index")]
        public long? AdFallbackIndex { get; set; }

        /// <summary>
        /// Ad id
        /// </summary>
        [JsonProperty(PropertyName = "ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// Ad id player
        /// </summary>
        [JsonProperty(PropertyName = "ad_id_player")]
        public string AdIdPlayer { get; set; }

        /// <summary>
        /// Ad impression id
        /// </summary>
        [JsonProperty(PropertyName = "ad_impression_id")]
        public string AdImpressionId { get; set; }

        /// <summary>
        /// Ad is persistent
        /// </summary>
        [JsonProperty(PropertyName = "ad_is_persistent")]
        public bool? AdIsPersistent { get; set; }

        /// <summary>
        /// Ad module
        /// </summary>
        [JsonProperty(PropertyName = "ad_module")]
        public string AdModule { get; set; }

        /// <summary>
        /// Ad module version
        /// </summary>
        [JsonProperty(PropertyName = "ad_module_version")]
        public string AdModuleVersion { get; set; }

        /// <summary>
        /// Ad offset
        /// </summary>
        [JsonProperty(PropertyName = "ad_offset")]
        public string AdOffset { get; set; }

        /// <summary>
        /// Ad playback height
        /// </summary>
        [JsonProperty(PropertyName = "ad_playback_height")]
        public long? AdPlaybackHeight { get; set; }

        /// <summary>
        /// Ad playback width
        /// </summary>
        [JsonProperty(PropertyName = "ad_playback_width")]
        public long? AdPlaybackWidth { get; set; }

        /// <summary>
        /// Ad pod position
        /// </summary>
        [JsonProperty(PropertyName = "ad_pod_position")]
        public long? AdPodPosition { get; set; }

        /// <summary>
        /// Ad position
        /// </summary>
        [JsonProperty(PropertyName = "ad_position")]
        public string AdPosition { get; set; }

        /// <summary>
        /// Ad preload offset
        /// </summary>
        [JsonProperty(PropertyName = "ad_preload_offset")]
        public long? AdPreloadOffset { get; set; }

        /// <summary>
        /// Ad replace content duration
        /// </summary>
        [JsonProperty(PropertyName = "ad_replace_content_duration")]
        public long? AdReplaceContentDuration { get; set; }

        /// <summary>
        /// Ad schedule duration
        /// </summary>
        [JsonProperty(PropertyName = "ad_schedule_time")]
        public long? AdScheduleTime { get; set; }

        /// <summary>
        /// Ad skip after
        /// </summary>
        [JsonProperty(PropertyName = "ad_skip_after")]
        public long? AdSkipAfter { get; set; }

        /// <summary>
        /// Ad is skippable
        /// </summary>
        [JsonProperty(PropertyName = "ad_skippable")]
        public bool? AdSkippable { get; set; }

        /// <summary>
        /// Ad startup time
        /// </summary>
        [JsonProperty(PropertyName = "ad_startup_time")]
        public long? AdStartupTime { get; set; }

        /// <summary>
        /// Ad system
        /// </summary>
        [JsonProperty(PropertyName = "ad_system")]
        public string AdSystem { get; set; }

        /// <summary>
        /// Ad tag path
        /// </summary>
        [JsonProperty(PropertyName = "ad_tag_path")]
        public string AdTagPath { get; set; }

        /// <summary>
        /// Ad system
        /// </summary>
        [JsonProperty(PropertyName = "ad_tag_server")]
        public string AdTagServer { get; set; }

        /// <summary>
        /// Ad tag type
        /// </summary>
        [JsonProperty(PropertyName = "ad_tag_type")]
        public string AdTagType { get; set; }

        /// <summary>
        /// Ad tag url
        /// </summary>
        [JsonProperty(PropertyName = "ad_tag_url")]
        public string AdTagUrl { get; set; }

        /// <summary>
        /// Ad title
        /// </summary>
        [JsonProperty(PropertyName = "ad_title")]
        public string AdTitle { get; set; }

        /// <summary>
        /// Ad wrapper ads count
        /// </summary>
        [JsonProperty(PropertyName = "ad_wrapper_ads_count")]
        public long? AdWrapperAdsCount { get; set; }

        /// <summary>
        /// Advertiser name
        /// </summary>
        [JsonProperty(PropertyName = "advertiser_name")]
        public string AdvertiserName { get; set; }

        /// <summary>
        /// Analytics version
        /// </summary>
        [JsonProperty(PropertyName = "analytics_version")]
        public string AnalyticsVersion { get; set; }

        /// <summary>
        /// Api framework
        /// </summary>
        [JsonProperty(PropertyName = "api_framework")]
        public string ApiFramework { get; set; }

        /// <summary>
        /// Organization id
        /// </summary>
        [JsonProperty(PropertyName = "apiorg_id")]
        public string ApiorgId { get; set; }

        /// <summary>
        /// User id
        /// </summary>
        [JsonProperty(PropertyName = "apiuser_id")]
        public string ApiuserId { get; set; }

        /// <summary>
        /// Audio bitrate
        /// </summary>
        [JsonProperty(PropertyName = "audio_bitrate")]
        public long? AudioBitrate { get; set; }

        /// <summary>
        /// Is autoplay
        /// </summary>
        [JsonProperty(PropertyName = "autoplay")]
        public bool? Autoplay { get; set; }

        /// <summary>
        /// Browser name
        /// </summary>
        [JsonProperty(PropertyName = "browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Browser is bot
        /// </summary>
        [JsonProperty(PropertyName = "browser_is_bot")]
        public bool? BrowserIsBot { get; set; }

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
        /// CDN Provider
        /// </summary>
        [JsonProperty(PropertyName = "cdn_provider")]
        public string CdnProvider { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Click percentage
        /// </summary>
        [JsonProperty(PropertyName = "click_percentage")]
        public long? ClickPercentage { get; set; }

        /// <summary>
        /// Click position
        /// </summary>
        [JsonProperty(PropertyName = "click_position")]
        public long? ClickPosition { get; set; }

        /// <summary>
        /// Clicked
        /// </summary>
        [JsonProperty(PropertyName = "clicked")]
        public int? Clicked { get; set; }

        /// <summary>
        /// Current time of the client
        /// </summary>
        [JsonProperty(PropertyName = "client_time")]
        public long? ClientTime { get; set; }

        /// <summary>
        /// Close percentage
        /// </summary>
        [JsonProperty(PropertyName = "close_percentage")]
        public long? ClosePercentage { get; set; }

        /// <summary>
        /// Close position
        /// </summary>
        [JsonProperty(PropertyName = "close_position")]
        public long? ClosePosition { get; set; }

        /// <summary>
        /// Closed
        /// </summary>
        [JsonProperty(PropertyName = "closed")]
        public int? Closed { get; set; }

        /// <summary>
        /// Completed
        /// </summary>
        [JsonProperty(PropertyName = "completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Creative ad id
        /// </summary>
        [JsonProperty(PropertyName = "creative_ad_id")]
        public string CreativeAdId { get; set; }

        /// <summary>
        /// Creative id
        /// </summary>
        [JsonProperty(PropertyName = "creative_id")]
        public string CreativeId { get; set; }

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
        /// Custom user ID
        /// </summary>
        [JsonProperty(PropertyName = "custom_user_id")]
        public string CustomUserId { get; set; }

        /// <summary>
        /// Deal id
        /// </summary>
        [JsonProperty(PropertyName = "deal_id")]
        public string DealId { get; set; }

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
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Error data
        /// </summary>
        [JsonProperty(PropertyName = "error_data")]
        public string ErrorData { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Error percentage
        /// </summary>
        [JsonProperty(PropertyName = "error_percentage")]
        public int? ErrorPercentage { get; set; }

        /// <summary>
        /// Error position
        /// </summary>
        [JsonProperty(PropertyName = "error_position")]
        public long? ErrorPosition { get; set; }

        /// <summary>
        /// Exit position
        /// </summary>
        [JsonProperty(PropertyName = "exit_position")]
        public long? ExitPosition { get; set; }

        /// <summary>
        /// A/B test experiment name
        /// </summary>
        [JsonProperty(PropertyName = "experiment_name")]
        public string ExperimentName { get; set; }

        /// <summary>
        /// IP Address of the client
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string IpAddress { get; set; }

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
        /// Manifest download time
        /// </summary>
        [JsonProperty(PropertyName = "manifest_download_time")]
        public long? ManifestDownloadTime { get; set; }

        /// <summary>
        /// Media path
        /// </summary>
        [JsonProperty(PropertyName = "media_path")]
        public string MediaPath { get; set; }

        /// <summary>
        /// Media server
        /// </summary>
        [JsonProperty(PropertyName = "media_server")]
        public string MediaServer { get; set; }

        /// <summary>
        /// Media url
        /// </summary>
        [JsonProperty(PropertyName = "media_url")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Midpoint
        /// </summary>
        [JsonProperty(PropertyName = "midpoint")]
        public int? Midpoint { get; set; }

        /// <summary>
        /// Minimum suggested duration
        /// </summary>
        [JsonProperty(PropertyName = "min_suggested_duration")]
        public long? MinSuggestedDuration { get; set; }

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
        /// Percentage in viewport
        /// </summary>
        [JsonProperty(PropertyName = "percentage_in_viewport")]
        public long? PercentageInViewport { get; set; }

        /// <summary>
        /// Platform the player is running on (web, android, ios)
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

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
        /// Play percentage
        /// </summary>
        [JsonProperty(PropertyName = "play_percentage")]
        public int? PlayPercentage { get; set; }

        /// <summary>
        /// Quartile 1
        /// </summary>
        [JsonProperty(PropertyName = "quartile_1")]
        public int? Quartile1 { get; set; }

        /// <summary>
        /// Quartile 3
        /// </summary>
        [JsonProperty(PropertyName = "quartile_3")]
        public int? Quartile3 { get; set; }

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
        /// Video size (FULLSCREEN or WINDOW)
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Skip percentage
        /// </summary>
        [JsonProperty(PropertyName = "skip_percentage")]
        public int? SkipPercentage { get; set; }

        /// <summary>
        /// Skip position
        /// </summary>
        [JsonProperty(PropertyName = "skip_position")]
        public long? SkipPosition { get; set; }

        /// <summary>
        /// Skipped
        /// </summary>
        [JsonProperty(PropertyName = "skipped")]
        public int? Skipped { get; set; }

        /// <summary>
        /// Started
        /// </summary>
        [JsonProperty(PropertyName = "started")]
        public int? Started { get; set; }

        /// <summary>
        /// Format of the stream (HLS, DASH, Progressive MP4)
        /// </summary>
        [JsonProperty(PropertyName = "stream_format")]
        public string StreamFormat { get; set; }

        /// <summary>
        /// Survey url
        /// </summary>
        [JsonProperty(PropertyName = "survey_url")]
        public string SurveyUrl { get; set; }

        /// <summary>
        /// Current time in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public long? Time { get; set; }

        /// <summary>
        /// Time in viewport
        /// </summary>
        [JsonProperty(PropertyName = "time_in_viewport")]
        public long? TimeInViewport { get; set; }

        /// <summary>
        /// Time played
        /// </summary>
        [JsonProperty(PropertyName = "time_played")]
        public long? TimePlayed { get; set; }

        /// <summary>
        /// Universal ad id registry
        /// </summary>
        [JsonProperty(PropertyName = "universal_ad_id_registry")]
        public string UniversalAdIdRegistry { get; set; }

        /// <summary>
        /// Universal ad id value
        /// </summary>
        [JsonProperty(PropertyName = "universal_ad_id_value")]
        public string UniversalAdIdValue { get; set; }

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
        /// ID of the video 
        /// </summary>
        [JsonProperty(PropertyName = "video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// ID of related video impression
        /// </summary>
        [JsonProperty(PropertyName = "video_impression_id")]
        public string VideoImpressionId { get; set; }

        /// <summary>
        /// Free form human readable video ad title
        /// </summary>
        [JsonProperty(PropertyName = "video_title")]
        public string VideoTitle { get; set; }

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
    }
}
