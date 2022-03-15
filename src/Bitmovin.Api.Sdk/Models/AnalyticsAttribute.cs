using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsAttribute
    /// </summary>
    public enum AnalyticsAttribute
    {
        /// <summary>
        /// IMPRESSION_ID
        /// </summary>
        [EnumMember(Value = "IMPRESSION_ID")]
        IMPRESSION_ID,

        /// <summary>
        /// ACTIVE_PLAYER_STARTUPTIME
        /// </summary>
        [EnumMember(Value = "ACTIVE_PLAYER_STARTUPTIME")]
        ACTIVE_PLAYER_STARTUPTIME,

        /// <summary>
        /// AD
        /// </summary>
        [EnumMember(Value = "AD")]
        AD,

        /// <summary>
        /// ANALYTICS_VERSION
        /// </summary>
        [EnumMember(Value = "ANALYTICS_VERSION")]
        ANALYTICS_VERSION,

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
        /// BROWSER_IS_BOT
        /// </summary>
        [EnumMember(Value = "BROWSER_IS_BOT")]
        BROWSER_IS_BOT,

        /// <summary>
        /// BUFFERED
        /// </summary>
        [EnumMember(Value = "BUFFERED")]
        BUFFERED,

        /// <summary>
        /// CDN_PROVIDER
        /// </summary>
        [EnumMember(Value = "CDN_PROVIDER")]
        CDN_PROVIDER,

        /// <summary>
        /// CAST_TECH
        /// </summary>
        [EnumMember(Value = "CAST_TECH")]
        CAST_TECH,

        /// <summary>
        /// CITY
        /// </summary>
        [EnumMember(Value = "CITY")]
        CITY,

        /// <summary>
        /// CLIENT_TIME
        /// </summary>
        [EnumMember(Value = "CLIENT_TIME")]
        CLIENT_TIME,

        /// <summary>
        /// COUNTRY
        /// </summary>
        [EnumMember(Value = "COUNTRY")]
        COUNTRY,

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
        /// DRM_LOAD_TIME
        /// </summary>
        [EnumMember(Value = "DRM_LOAD_TIME")]
        DRM_LOAD_TIME,

        /// <summary>
        /// DRM_TYPE
        /// </summary>
        [EnumMember(Value = "DRM_TYPE")]
        DRM_TYPE,

        /// <summary>
        /// DROPPED_FRAMES
        /// </summary>
        [EnumMember(Value = "DROPPED_FRAMES")]
        DROPPED_FRAMES,

        /// <summary>
        /// DURATION
        /// </summary>
        [EnumMember(Value = "DURATION")]
        DURATION,

        /// <summary>
        /// ERROR_CODE
        /// </summary>
        [EnumMember(Value = "ERROR_CODE")]
        ERROR_CODE,

        /// <summary>
        /// ERROR_MESSAGE
        /// </summary>
        [EnumMember(Value = "ERROR_MESSAGE")]
        ERROR_MESSAGE,

        /// <summary>
        /// ERROR_RATE
        /// </summary>
        [EnumMember(Value = "ERROR_RATE")]
        ERROR_RATE,

        /// <summary>
        /// EXPERIMENT_NAME
        /// </summary>
        [EnumMember(Value = "EXPERIMENT_NAME")]
        EXPERIMENT_NAME,

        /// <summary>
        /// FUNCTION
        /// </summary>
        [EnumMember(Value = "FUNCTION")]
        FUNCTION,

        /// <summary>
        /// HOUR
        /// </summary>
        [EnumMember(Value = "HOUR")]
        HOUR,

        /// <summary>
        /// INITIAL_TIME_TO_TARGET_LATENCY
        /// </summary>
        [EnumMember(Value = "INITIAL_TIME_TO_TARGET_LATENCY")]
        INITIAL_TIME_TO_TARGET_LATENCY,

        /// <summary>
        /// IP_ADDRESS
        /// </summary>
        [EnumMember(Value = "IP_ADDRESS")]
        IP_ADDRESS,

        /// <summary>
        /// IS_CASTING
        /// </summary>
        [EnumMember(Value = "IS_CASTING")]
        IS_CASTING,

        /// <summary>
        /// IS_LIVE
        /// </summary>
        [EnumMember(Value = "IS_LIVE")]
        IS_LIVE,

        /// <summary>
        /// IS_LOW_LATENCY
        /// </summary>
        [EnumMember(Value = "IS_LOW_LATENCY")]
        IS_LOW_LATENCY,

        /// <summary>
        /// IS_MUTED
        /// </summary>
        [EnumMember(Value = "IS_MUTED")]
        IS_MUTED,

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
        /// LATENCY
        /// </summary>
        [EnumMember(Value = "LATENCY")]
        LATENCY,

        /// <summary>
        /// LICENSE_KEY
        /// </summary>
        [EnumMember(Value = "LICENSE_KEY")]
        LICENSE_KEY,

        /// <summary>
        /// M3U8_URL
        /// </summary>
        [EnumMember(Value = "M3U8_URL")]
        M3U8_URL,

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
        /// MPD_URL
        /// </summary>
        [EnumMember(Value = "MPD_URL")]
        MPD_URL,

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
        /// PAUSED
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        PAUSED,

        /// <summary>
        /// PLATFORM
        /// </summary>
        [EnumMember(Value = "PLATFORM")]
        PLATFORM,

        /// <summary>
        /// PLAYED
        /// </summary>
        [EnumMember(Value = "PLAYED")]
        PLAYED,

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
        /// PROG_URL
        /// </summary>
        [EnumMember(Value = "PROG_URL")]
        PROG_URL,

        /// <summary>
        /// REBUFFER_PERCENTAGE
        /// </summary>
        [EnumMember(Value = "REBUFFER_PERCENTAGE")]
        REBUFFER_PERCENTAGE,

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
        /// SEEKED
        /// </summary>
        [EnumMember(Value = "SEEKED")]
        SEEKED,

        /// <summary>
        /// SEQUENCE_NUMBER
        /// </summary>
        [EnumMember(Value = "SEQUENCE_NUMBER")]
        SEQUENCE_NUMBER,

        /// <summary>
        /// SIZE
        /// </summary>
        [EnumMember(Value = "SIZE")]
        SIZE,

        /// <summary>
        /// STARTUPTIME
        /// </summary>
        [EnumMember(Value = "STARTUPTIME")]
        STARTUPTIME,

        /// <summary>
        /// STREAM_FORMAT
        /// </summary>
        [EnumMember(Value = "STREAM_FORMAT")]
        STREAM_FORMAT,

        /// <summary>
        /// SUPPORTED_VIDEO_CODECS
        /// </summary>
        [EnumMember(Value = "SUPPORTED_VIDEO_CODECS")]
        SUPPORTED_VIDEO_CODECS,

        /// <summary>
        /// TARGET_LATENCY
        /// </summary>
        [EnumMember(Value = "TARGET_LATENCY")]
        TARGET_LATENCY,

        /// <summary>
        /// TARGET_LATENCY_DELTA
        /// </summary>
        [EnumMember(Value = "TARGET_LATENCY_DELTA")]
        TARGET_LATENCY_DELTA,

        /// <summary>
        /// TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,

        /// <summary>
        /// TIME_TO_TARGET_LATENCY
        /// </summary>
        [EnumMember(Value = "TIME_TO_TARGET_LATENCY")]
        TIME_TO_TARGET_LATENCY,

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
        /// VIDEO_DURATION
        /// </summary>
        [EnumMember(Value = "VIDEO_DURATION")]
        VIDEO_DURATION,

        /// <summary>
        /// VIDEO_ID
        /// </summary>
        [EnumMember(Value = "VIDEO_ID")]
        VIDEO_ID,

        /// <summary>
        /// VIDEO_PLAYBACK_HEIGHT
        /// </summary>
        [EnumMember(Value = "VIDEO_PLAYBACK_HEIGHT")]
        VIDEO_PLAYBACK_HEIGHT,

        /// <summary>
        /// VIDEO_PLAYBACK_WIDTH
        /// </summary>
        [EnumMember(Value = "VIDEO_PLAYBACK_WIDTH")]
        VIDEO_PLAYBACK_WIDTH,

        /// <summary>
        /// VIDEO_STARTUPTIME
        /// </summary>
        [EnumMember(Value = "VIDEO_STARTUPTIME")]
        VIDEO_STARTUPTIME,

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
        VIDEO_WINDOW_WIDTH,

        /// <summary>
        /// VIDEOTIME_END
        /// </summary>
        [EnumMember(Value = "VIDEOTIME_END")]
        VIDEOTIME_END,

        /// <summary>
        /// VIDEOTIME_START
        /// </summary>
        [EnumMember(Value = "VIDEOTIME_START")]
        VIDEOTIME_START,

        /// <summary>
        /// VIDEOSTART_FAILED
        /// </summary>
        [EnumMember(Value = "VIDEOSTART_FAILED")]
        VIDEOSTART_FAILED,

        /// <summary>
        /// VIDEOSTART_FAILED_REASON
        /// </summary>
        [EnumMember(Value = "VIDEOSTART_FAILED_REASON")]
        VIDEOSTART_FAILED_REASON
    }
}
