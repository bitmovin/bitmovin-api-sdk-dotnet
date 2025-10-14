using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdAnalyticsAttribute
    /// </summary>
    public enum AdAnalyticsAttribute
    {
        /// <summary>
        /// AD_IMPRESSION_ID
        /// </summary>
        [EnumMember(Value = "AD_IMPRESSION_ID")]
        AD_IMPRESSION_ID,

        /// <summary>
        /// AD_CLICKTHROUGH_URL
        /// </summary>
        [EnumMember(Value = "AD_CLICKTHROUGH_URL")]
        AD_CLICKTHROUGH_URL,

        /// <summary>
        /// AD_DESCRIPTION
        /// </summary>
        [EnumMember(Value = "AD_DESCRIPTION")]
        AD_DESCRIPTION,

        /// <summary>
        /// AD_DURATION
        /// </summary>
        [EnumMember(Value = "AD_DURATION")]
        AD_DURATION,

        /// <summary>
        /// AD_FALLBACK_INDEX
        /// </summary>
        [EnumMember(Value = "AD_FALLBACK_INDEX")]
        AD_FALLBACK_INDEX,

        /// <summary>
        /// AD_ID
        /// </summary>
        [EnumMember(Value = "AD_ID")]
        AD_ID,

        /// <summary>
        /// AD_ID_PLAYER
        /// </summary>
        [EnumMember(Value = "AD_ID_PLAYER")]
        AD_ID_PLAYER,

        /// <summary>
        /// AD_IS_PERSISTENT
        /// </summary>
        [EnumMember(Value = "AD_IS_PERSISTENT")]
        AD_IS_PERSISTENT,

        /// <summary>
        /// AD_MODULE
        /// </summary>
        [EnumMember(Value = "AD_MODULE")]
        AD_MODULE,

        /// <summary>
        /// AD_OFFSET
        /// </summary>
        [EnumMember(Value = "AD_OFFSET")]
        AD_OFFSET,

        /// <summary>
        /// AD_PLAYBACK_HEIGHT
        /// </summary>
        [EnumMember(Value = "AD_PLAYBACK_HEIGHT")]
        AD_PLAYBACK_HEIGHT,

        /// <summary>
        /// AD_PLAYBACK_WIDTH
        /// </summary>
        [EnumMember(Value = "AD_PLAYBACK_WIDTH")]
        AD_PLAYBACK_WIDTH,

        /// <summary>
        /// AD_POD_POSITION
        /// </summary>
        [EnumMember(Value = "AD_POD_POSITION")]
        AD_POD_POSITION,

        /// <summary>
        /// AD_POSITION
        /// </summary>
        [EnumMember(Value = "AD_POSITION")]
        AD_POSITION,

        /// <summary>
        /// AD_PRELOAD_OFFSET
        /// </summary>
        [EnumMember(Value = "AD_PRELOAD_OFFSET")]
        AD_PRELOAD_OFFSET,

        /// <summary>
        /// AD_REPLACE_CONTENT_DURATION
        /// </summary>
        [EnumMember(Value = "AD_REPLACE_CONTENT_DURATION")]
        AD_REPLACE_CONTENT_DURATION,

        /// <summary>
        /// AD_SCHEDULE_TIME
        /// </summary>
        [EnumMember(Value = "AD_SCHEDULE_TIME")]
        AD_SCHEDULE_TIME,

        /// <summary>
        /// AD_SKIP_AFTER
        /// </summary>
        [EnumMember(Value = "AD_SKIP_AFTER")]
        AD_SKIP_AFTER,

        /// <summary>
        /// AD_SKIPPABLE
        /// </summary>
        [EnumMember(Value = "AD_SKIPPABLE")]
        AD_SKIPPABLE,

        /// <summary>
        /// AD_STARTUP_TIME
        /// </summary>
        [EnumMember(Value = "AD_STARTUP_TIME")]
        AD_STARTUP_TIME,

        /// <summary>
        /// AD_SYSTEM
        /// </summary>
        [EnumMember(Value = "AD_SYSTEM")]
        AD_SYSTEM,

        /// <summary>
        /// AD_TAG_PATH
        /// </summary>
        [EnumMember(Value = "AD_TAG_PATH")]
        AD_TAG_PATH,

        /// <summary>
        /// AD_TAG_SERVER
        /// </summary>
        [EnumMember(Value = "AD_TAG_SERVER")]
        AD_TAG_SERVER,

        /// <summary>
        /// AD_TAG_TYPE
        /// </summary>
        [EnumMember(Value = "AD_TAG_TYPE")]
        AD_TAG_TYPE,

        /// <summary>
        /// AD_TAG_URL
        /// </summary>
        [EnumMember(Value = "AD_TAG_URL")]
        AD_TAG_URL,

        /// <summary>
        /// AD_TITLE
        /// </summary>
        [EnumMember(Value = "AD_TITLE")]
        AD_TITLE,

        /// <summary>
        /// AD_WRAPPER_ADS_COUNT
        /// </summary>
        [EnumMember(Value = "AD_WRAPPER_ADS_COUNT")]
        AD_WRAPPER_ADS_COUNT,

        /// <summary>
        /// ADVERTISER_NAME
        /// </summary>
        [EnumMember(Value = "ADVERTISER_NAME")]
        ADVERTISER_NAME,

        /// <summary>
        /// ANALYTICS_VERSION
        /// </summary>
        [EnumMember(Value = "ANALYTICS_VERSION")]
        ANALYTICS_VERSION,

        /// <summary>
        /// API_FRAMEWORK
        /// </summary>
        [EnumMember(Value = "API_FRAMEWORK")]
        API_FRAMEWORK,

        /// <summary>
        /// AUDIO_BITRATE
        /// </summary>
        [EnumMember(Value = "AUDIO_BITRATE")]
        AUDIO_BITRATE,

        /// <summary>
        /// AUDIO_CODEC
        /// </summary>
        [EnumMember(Value = "AUDIO_CODEC")]
        AUDIO_CODEC,

        /// <summary>
        /// AUTOPLAY
        /// </summary>
        [EnumMember(Value = "AUTOPLAY")]
        AUTOPLAY,

        /// <summary>
        /// BROWSER
        /// </summary>
        [EnumMember(Value = "BROWSER")]
        BROWSER,

        /// <summary>
        /// BROWSER_VERSION_MAJOR
        /// </summary>
        [EnumMember(Value = "BROWSER_VERSION_MAJOR")]
        BROWSER_VERSION_MAJOR,

        /// <summary>
        /// CDN_PROVIDER
        /// </summary>
        [EnumMember(Value = "CDN_PROVIDER")]
        CDN_PROVIDER,

        /// <summary>
        /// CITY
        /// </summary>
        [EnumMember(Value = "CITY")]
        CITY,

        /// <summary>
        /// CLICK_PERCENTAGE
        /// </summary>
        [EnumMember(Value = "CLICK_PERCENTAGE")]
        CLICK_PERCENTAGE,

        /// <summary>
        /// CLICK_POSITION
        /// </summary>
        [EnumMember(Value = "CLICK_POSITION")]
        CLICK_POSITION,

        /// <summary>
        /// CLICKED
        /// </summary>
        [EnumMember(Value = "CLICKED")]
        CLICKED,

        /// <summary>
        /// CLIENT_TIME
        /// </summary>
        [EnumMember(Value = "CLIENT_TIME")]
        CLIENT_TIME,

        /// <summary>
        /// CLOSE_PERCENTAGE
        /// </summary>
        [EnumMember(Value = "CLOSE_PERCENTAGE")]
        CLOSE_PERCENTAGE,

        /// <summary>
        /// CLOSE_POSITION
        /// </summary>
        [EnumMember(Value = "CLOSE_POSITION")]
        CLOSE_POSITION,

        /// <summary>
        /// CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED,

        /// <summary>
        /// COMPLETED
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        /// <summary>
        /// COUNTRY
        /// </summary>
        [EnumMember(Value = "COUNTRY")]
        COUNTRY,

        /// <summary>
        /// CREATIVE_AD_ID
        /// </summary>
        [EnumMember(Value = "CREATIVE_AD_ID")]
        CREATIVE_AD_ID,

        /// <summary>
        /// CREATIVE_ID
        /// </summary>
        [EnumMember(Value = "CREATIVE_ID")]
        CREATIVE_ID,

        /// <summary>
        /// CUSTOM_DATA_1
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_1")]
        CUSTOM_DATA_1,

        /// <summary>
        /// CUSTOM_DATA_2
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_2")]
        CUSTOM_DATA_2,

        /// <summary>
        /// CUSTOM_DATA_3
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_3")]
        CUSTOM_DATA_3,

        /// <summary>
        /// CUSTOM_DATA_4
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_4")]
        CUSTOM_DATA_4,

        /// <summary>
        /// CUSTOM_DATA_5
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_5")]
        CUSTOM_DATA_5,

        /// <summary>
        /// CUSTOM_DATA_6
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_6")]
        CUSTOM_DATA_6,

        /// <summary>
        /// CUSTOM_DATA_7
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_7")]
        CUSTOM_DATA_7,

        /// <summary>
        /// CUSTOM_DATA_8
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_8")]
        CUSTOM_DATA_8,

        /// <summary>
        /// CUSTOM_DATA_9
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_9")]
        CUSTOM_DATA_9,

        /// <summary>
        /// CUSTOM_DATA_10
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_10")]
        CUSTOM_DATA_10,

        /// <summary>
        /// CUSTOM_DATA_11
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_11")]
        CUSTOM_DATA_11,

        /// <summary>
        /// CUSTOM_DATA_12
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_12")]
        CUSTOM_DATA_12,

        /// <summary>
        /// CUSTOM_DATA_13
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_13")]
        CUSTOM_DATA_13,

        /// <summary>
        /// CUSTOM_DATA_14
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_14")]
        CUSTOM_DATA_14,

        /// <summary>
        /// CUSTOM_DATA_15
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_15")]
        CUSTOM_DATA_15,

        /// <summary>
        /// CUSTOM_DATA_16
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_16")]
        CUSTOM_DATA_16,

        /// <summary>
        /// CUSTOM_DATA_17
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_17")]
        CUSTOM_DATA_17,

        /// <summary>
        /// CUSTOM_DATA_18
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_18")]
        CUSTOM_DATA_18,

        /// <summary>
        /// CUSTOM_DATA_19
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_19")]
        CUSTOM_DATA_19,

        /// <summary>
        /// CUSTOM_DATA_20
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_20")]
        CUSTOM_DATA_20,

        /// <summary>
        /// CUSTOM_DATA_21
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_21")]
        CUSTOM_DATA_21,

        /// <summary>
        /// CUSTOM_DATA_22
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_22")]
        CUSTOM_DATA_22,

        /// <summary>
        /// CUSTOM_DATA_23
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_23")]
        CUSTOM_DATA_23,

        /// <summary>
        /// CUSTOM_DATA_24
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_24")]
        CUSTOM_DATA_24,

        /// <summary>
        /// CUSTOM_DATA_25
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_25")]
        CUSTOM_DATA_25,

        /// <summary>
        /// CUSTOM_DATA_26
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_26")]
        CUSTOM_DATA_26,

        /// <summary>
        /// CUSTOM_DATA_27
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_27")]
        CUSTOM_DATA_27,

        /// <summary>
        /// CUSTOM_DATA_28
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_28")]
        CUSTOM_DATA_28,

        /// <summary>
        /// CUSTOM_DATA_29
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_29")]
        CUSTOM_DATA_29,

        /// <summary>
        /// CUSTOM_DATA_30
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_30")]
        CUSTOM_DATA_30,

        /// <summary>
        /// CUSTOM_USER_ID
        /// </summary>
        [EnumMember(Value = "CUSTOM_USER_ID")]
        CUSTOM_USER_ID,

        /// <summary>
        /// DAY
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY,

        /// <summary>
        /// DEAL_ID
        /// </summary>
        [EnumMember(Value = "DEAL_ID")]
        DEAL_ID,

        /// <summary>
        /// DEVICE_CLASS
        /// </summary>
        [EnumMember(Value = "DEVICE_CLASS")]
        DEVICE_CLASS,

        /// <summary>
        /// DEVICE_TYPE
        /// </summary>
        [EnumMember(Value = "DEVICE_TYPE")]
        DEVICE_TYPE,

        /// <summary>
        /// DOMAIN
        /// </summary>
        [EnumMember(Value = "DOMAIN")]
        DOMAIN,

        /// <summary>
        /// ERROR_CODE
        /// </summary>
        [EnumMember(Value = "ERROR_CODE")]
        ERROR_CODE,

        /// <summary>
        /// ERROR_SEVERITY
        /// </summary>
        [EnumMember(Value = "ERROR_SEVERITY")]
        ERROR_SEVERITY,

        /// <summary>
        /// ERROR_PERCENTAGE
        /// </summary>
        [EnumMember(Value = "ERROR_PERCENTAGE")]
        ERROR_PERCENTAGE,

        /// <summary>
        /// ERROR_POSITION
        /// </summary>
        [EnumMember(Value = "ERROR_POSITION")]
        ERROR_POSITION,

        /// <summary>
        /// EXIT_POSITION
        /// </summary>
        [EnumMember(Value = "EXIT_POSITION")]
        EXIT_POSITION,

        /// <summary>
        /// EXPERIMENT_NAME
        /// </summary>
        [EnumMember(Value = "EXPERIMENT_NAME")]
        EXPERIMENT_NAME,

        /// <summary>
        /// HOUR
        /// </summary>
        [EnumMember(Value = "HOUR")]
        HOUR,

        /// <summary>
        /// IP_ADDRESS
        /// </summary>
        [EnumMember(Value = "IP_ADDRESS")]
        IP_ADDRESS,

        /// <summary>
        /// IS_LINEAR
        /// </summary>
        [EnumMember(Value = "IS_LINEAR")]
        IS_LINEAR,

        /// <summary>
        /// ISP
        /// </summary>
        [EnumMember(Value = "ISP")]
        ISP,

        /// <summary>
        /// LANGUAGE
        /// </summary>
        [EnumMember(Value = "LANGUAGE")]
        LANGUAGE,

        /// <summary>
        /// LICENSE_KEY
        /// </summary>
        [EnumMember(Value = "LICENSE_KEY")]
        LICENSE_KEY,

        /// <summary>
        /// MANIFEST_DOWNLOAD_TIME
        /// </summary>
        [EnumMember(Value = "MANIFEST_DOWNLOAD_TIME")]
        MANIFEST_DOWNLOAD_TIME,

        /// <summary>
        /// MEDIA_PATH
        /// </summary>
        [EnumMember(Value = "MEDIA_PATH")]
        MEDIA_PATH,

        /// <summary>
        /// MEDIA_SERVER
        /// </summary>
        [EnumMember(Value = "MEDIA_SERVER")]
        MEDIA_SERVER,

        /// <summary>
        /// MEDIA_URL
        /// </summary>
        [EnumMember(Value = "MEDIA_URL")]
        MEDIA_URL,

        /// <summary>
        /// MIDPOINT
        /// </summary>
        [EnumMember(Value = "MIDPOINT")]
        MIDPOINT,

        /// <summary>
        /// MIN_SUGGESTED_DURATION
        /// </summary>
        [EnumMember(Value = "MIN_SUGGESTED_DURATION")]
        MIN_SUGGESTED_DURATION,

        /// <summary>
        /// MINUTE
        /// </summary>
        [EnumMember(Value = "MINUTE")]
        MINUTE,

        /// <summary>
        /// MONTH
        /// </summary>
        [EnumMember(Value = "MONTH")]
        MONTH,

        /// <summary>
        /// OPERATINGSYSTEM
        /// </summary>
        [EnumMember(Value = "OPERATINGSYSTEM")]
        OPERATINGSYSTEM,

        /// <summary>
        /// OPERATINGSYSTEM_VERSION_MAJOR
        /// </summary>
        [EnumMember(Value = "OPERATINGSYSTEM_VERSION_MAJOR")]
        OPERATINGSYSTEM_VERSION_MAJOR,

        /// <summary>
        /// PAGE_LOAD_TIME
        /// </summary>
        [EnumMember(Value = "PAGE_LOAD_TIME")]
        PAGE_LOAD_TIME,

        /// <summary>
        /// PAGE_LOAD_TYPE
        /// </summary>
        [EnumMember(Value = "PAGE_LOAD_TYPE")]
        PAGE_LOAD_TYPE,

        /// <summary>
        /// PATH
        /// </summary>
        [EnumMember(Value = "PATH")]
        PATH,

        /// <summary>
        /// PERCENTAGE_IN_VIEWPORT
        /// </summary>
        [EnumMember(Value = "PERCENTAGE_IN_VIEWPORT")]
        PERCENTAGE_IN_VIEWPORT,

        /// <summary>
        /// PLATFORM
        /// </summary>
        [EnumMember(Value = "PLATFORM")]
        PLATFORM,

        /// <summary>
        /// PLAY_PERCENTAGE
        /// </summary>
        [EnumMember(Value = "PLAY_PERCENTAGE")]
        PLAY_PERCENTAGE,

        /// <summary>
        /// PLAYER
        /// </summary>
        [EnumMember(Value = "PLAYER")]
        PLAYER,

        /// <summary>
        /// PLAYER_KEY
        /// </summary>
        [EnumMember(Value = "PLAYER_KEY")]
        PLAYER_KEY,

        /// <summary>
        /// PLAYER_STARTUPTIME
        /// </summary>
        [EnumMember(Value = "PLAYER_STARTUPTIME")]
        PLAYER_STARTUPTIME,

        /// <summary>
        /// PLAYER_TECH
        /// </summary>
        [EnumMember(Value = "PLAYER_TECH")]
        PLAYER_TECH,

        /// <summary>
        /// PLAYER_VERSION
        /// </summary>
        [EnumMember(Value = "PLAYER_VERSION")]
        PLAYER_VERSION,

        /// <summary>
        /// QUARTILE_1
        /// </summary>
        [EnumMember(Value = "QUARTILE_1")]
        QUARTILE_1,

        /// <summary>
        /// QUARTILE_3
        /// </summary>
        [EnumMember(Value = "QUARTILE_3")]
        QUARTILE_3,

        /// <summary>
        /// REGION
        /// </summary>
        [EnumMember(Value = "REGION")]
        REGION,

        /// <summary>
        /// SCALE_FACTOR
        /// </summary>
        [EnumMember(Value = "SCALE_FACTOR")]
        SCALE_FACTOR,

        /// <summary>
        /// SCREEN_HEIGHT
        /// </summary>
        [EnumMember(Value = "SCREEN_HEIGHT")]
        SCREEN_HEIGHT,

        /// <summary>
        /// SCREEN_WIDTH
        /// </summary>
        [EnumMember(Value = "SCREEN_WIDTH")]
        SCREEN_WIDTH,

        /// <summary>
        /// SCREEN_ORIENTATION
        /// </summary>
        [EnumMember(Value = "SCREEN_ORIENTATION")]
        SCREEN_ORIENTATION,

        /// <summary>
        /// SIZE
        /// </summary>
        [EnumMember(Value = "SIZE")]
        SIZE,

        /// <summary>
        /// SKIP_PERCENTAGE
        /// </summary>
        [EnumMember(Value = "SKIP_PERCENTAGE")]
        SKIP_PERCENTAGE,

        /// <summary>
        /// SKIP_POSITION
        /// </summary>
        [EnumMember(Value = "SKIP_POSITION")]
        SKIP_POSITION,

        /// <summary>
        /// SKIPPED
        /// </summary>
        [EnumMember(Value = "SKIPPED")]
        SKIPPED,

        /// <summary>
        /// STARTED
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// STREAM_FORMAT
        /// </summary>
        [EnumMember(Value = "STREAM_FORMAT")]
        STREAM_FORMAT,

        /// <summary>
        /// SURVEY_URL
        /// </summary>
        [EnumMember(Value = "SURVEY_URL")]
        SURVEY_URL,

        /// <summary>
        /// TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,

        /// <summary>
        /// TIME_IN_VIEWPORT
        /// </summary>
        [EnumMember(Value = "TIME_IN_VIEWPORT")]
        TIME_IN_VIEWPORT,

        /// <summary>
        /// TIME_PLAYED
        /// </summary>
        [EnumMember(Value = "TIME_PLAYED")]
        TIME_PLAYED,

        /// <summary>
        /// UNIVERSAL_AD_ID_REGISTRY
        /// </summary>
        [EnumMember(Value = "UNIVERSAL_AD_ID_REGISTRY")]
        UNIVERSAL_AD_ID_REGISTRY,

        /// <summary>
        /// UNIVERSAL_AD_ID_VALUE
        /// </summary>
        [EnumMember(Value = "UNIVERSAL_AD_ID_VALUE")]
        UNIVERSAL_AD_ID_VALUE,

        /// <summary>
        /// USER_ID
        /// </summary>
        [EnumMember(Value = "USER_ID")]
        USER_ID,

        /// <summary>
        /// VIDEO_BITRATE
        /// </summary>
        [EnumMember(Value = "VIDEO_BITRATE")]
        VIDEO_BITRATE,

        /// <summary>
        /// VIDEO_CODEC
        /// </summary>
        [EnumMember(Value = "VIDEO_CODEC")]
        VIDEO_CODEC,

        /// <summary>
        /// VIDEO_ID
        /// </summary>
        [EnumMember(Value = "VIDEO_ID")]
        VIDEO_ID,

        /// <summary>
        /// VIDEO_IMPRESSION_ID
        /// </summary>
        [EnumMember(Value = "VIDEO_IMPRESSION_ID")]
        VIDEO_IMPRESSION_ID,

        /// <summary>
        /// VIDEO_TITLE
        /// </summary>
        [EnumMember(Value = "VIDEO_TITLE")]
        VIDEO_TITLE,

        /// <summary>
        /// VIDEO_WINDOW_HEIGHT
        /// </summary>
        [EnumMember(Value = "VIDEO_WINDOW_HEIGHT")]
        VIDEO_WINDOW_HEIGHT,

        /// <summary>
        /// VIDEO_WINDOW_WIDTH
        /// </summary>
        [EnumMember(Value = "VIDEO_WINDOW_WIDTH")]
        VIDEO_WINDOW_WIDTH
    }
}
