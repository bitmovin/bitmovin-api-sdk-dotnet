using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsAttribute
    /// </summary>
    public enum AnalyticsAttribute
    {
        /// <summary>
        /// IMPRESSIONID
        /// </summary>
        [EnumMember(Value = "IMPRESSION_ID")]
        IMPRESSIONID,

        /// <summary>
        /// ACTIVEPLAYERSTARTUPTIME
        /// </summary>
        [EnumMember(Value = "ACTIVE_PLAYER_STARTUPTIME")]
        ACTIVEPLAYERSTARTUPTIME,

        /// <summary>
        /// AD
        /// </summary>
        [EnumMember(Value = "AD")]
        AD,

        /// <summary>
        /// ANALYTICSVERSION
        /// </summary>
        [EnumMember(Value = "ANALYTICS_VERSION")]
        ANALYTICSVERSION,

        /// <summary>
        /// ASN
        /// </summary>
        [EnumMember(Value = "ASN")]
        ASN,

        /// <summary>
        /// AUDIOBITRATE
        /// </summary>
        [EnumMember(Value = "AUDIO_BITRATE")]
        AUDIOBITRATE,

        /// <summary>
        /// AUDIOCODEC
        /// </summary>
        [EnumMember(Value = "AUDIO_CODEC")]
        AUDIOCODEC,

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
        /// BROWSERVERSIONMAJOR
        /// </summary>
        [EnumMember(Value = "BROWSER_VERSION_MAJOR")]
        BROWSERVERSIONMAJOR,

        /// <summary>
        /// BROWSERISBOT
        /// </summary>
        [EnumMember(Value = "BROWSER_IS_BOT")]
        BROWSERISBOT,

        /// <summary>
        /// BUFFERED
        /// </summary>
        [EnumMember(Value = "BUFFERED")]
        BUFFERED,

        /// <summary>
        /// CDNPROVIDER
        /// </summary>
        [EnumMember(Value = "CDN_PROVIDER")]
        CDNPROVIDER,

        /// <summary>
        /// CITY
        /// </summary>
        [EnumMember(Value = "CITY")]
        CITY,

        /// <summary>
        /// CLIENTTIME
        /// </summary>
        [EnumMember(Value = "CLIENT_TIME")]
        CLIENTTIME,

        /// <summary>
        /// COUNTRY
        /// </summary>
        [EnumMember(Value = "COUNTRY")]
        COUNTRY,

        /// <summary>
        /// CUSTOMDATA1
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_1")]
        CUSTOMDATA1,

        /// <summary>
        /// CUSTOMDATA2
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_2")]
        CUSTOMDATA2,

        /// <summary>
        /// CUSTOMDATA3
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_3")]
        CUSTOMDATA3,

        /// <summary>
        /// CUSTOMDATA4
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_4")]
        CUSTOMDATA4,

        /// <summary>
        /// CUSTOMDATA5
        /// </summary>
        [EnumMember(Value = "CUSTOM_DATA_5")]
        CUSTOMDATA5,

        /// <summary>
        /// CUSTOMUSERID
        /// </summary>
        [EnumMember(Value = "CUSTOM_USER_ID")]
        CUSTOMUSERID,

        /// <summary>
        /// DAY
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY,

        /// <summary>
        /// DEVICECLASS
        /// </summary>
        [EnumMember(Value = "DEVICE_CLASS")]
        DEVICECLASS,

        /// <summary>
        /// DEVICETYPE
        /// </summary>
        [EnumMember(Value = "DEVICE_TYPE")]
        DEVICETYPE,

        /// <summary>
        /// DOMAIN
        /// </summary>
        [EnumMember(Value = "DOMAIN")]
        DOMAIN,

        /// <summary>
        /// DRMLOADTIME
        /// </summary>
        [EnumMember(Value = "DRM_LOAD_TIME")]
        DRMLOADTIME,

        /// <summary>
        /// DRMTYPE
        /// </summary>
        [EnumMember(Value = "DRM_TYPE")]
        DRMTYPE,

        /// <summary>
        /// DROPPEDFRAMES
        /// </summary>
        [EnumMember(Value = "DROPPED_FRAMES")]
        DROPPEDFRAMES,

        /// <summary>
        /// DURATION
        /// </summary>
        [EnumMember(Value = "DURATION")]
        DURATION,

        /// <summary>
        /// ERRORCODE
        /// </summary>
        [EnumMember(Value = "ERROR_CODE")]
        ERRORCODE,

        /// <summary>
        /// ERRORMESSAGE
        /// </summary>
        [EnumMember(Value = "ERROR_MESSAGE")]
        ERRORMESSAGE,

        /// <summary>
        /// ERRORRATE
        /// </summary>
        [EnumMember(Value = "ERROR_RATE")]
        ERRORRATE,

        /// <summary>
        /// EXPERIMENTNAME
        /// </summary>
        [EnumMember(Value = "EXPERIMENT_NAME")]
        EXPERIMENTNAME,

        /// <summary>
        /// HOUR
        /// </summary>
        [EnumMember(Value = "HOUR")]
        HOUR,

        /// <summary>
        /// INITIALTIMETOTARGETLATENCY
        /// </summary>
        [EnumMember(Value = "INITIAL_TIME_TO_TARGET_LATENCY")]
        INITIALTIMETOTARGETLATENCY,

        /// <summary>
        /// IPADDRESS
        /// </summary>
        [EnumMember(Value = "IP_ADDRESS")]
        IPADDRESS,

        /// <summary>
        /// ISCASTING
        /// </summary>
        [EnumMember(Value = "IS_CASTING")]
        ISCASTING,

        /// <summary>
        /// ISLIVE
        /// </summary>
        [EnumMember(Value = "IS_LIVE")]
        ISLIVE,

        /// <summary>
        /// ISLOWLATENCY
        /// </summary>
        [EnumMember(Value = "IS_LOW_LATENCY")]
        ISLOWLATENCY,

        /// <summary>
        /// ISMUTED
        /// </summary>
        [EnumMember(Value = "IS_MUTED")]
        ISMUTED,

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
        /// LICENSEKEY
        /// </summary>
        [EnumMember(Value = "LICENSE_KEY")]
        LICENSEKEY,

        /// <summary>
        /// M3U8URL
        /// </summary>
        [EnumMember(Value = "M3U8_URL")]
        M3U8URL,

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
        /// MPDURL
        /// </summary>
        [EnumMember(Value = "MPD_URL")]
        MPDURL,

        /// <summary>
        /// OPERATINGSYSTEM
        /// </summary>
        [EnumMember(Value = "OPERATINGSYSTEM")]
        OPERATINGSYSTEM,

        /// <summary>
        /// OPERATINGSYSTEMVERSIONMAJOR
        /// </summary>
        [EnumMember(Value = "OPERATINGSYSTEM_VERSION_MAJOR")]
        OPERATINGSYSTEMVERSIONMAJOR,

        /// <summary>
        /// PAGELOADTIME
        /// </summary>
        [EnumMember(Value = "PAGE_LOAD_TIME")]
        PAGELOADTIME,

        /// <summary>
        /// PAGELOADTYPE
        /// </summary>
        [EnumMember(Value = "PAGE_LOAD_TYPE")]
        PAGELOADTYPE,

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
        /// PLAYERKEY
        /// </summary>
        [EnumMember(Value = "PLAYER_KEY")]
        PLAYERKEY,

        /// <summary>
        /// PLAYERSTARTUPTIME
        /// </summary>
        [EnumMember(Value = "PLAYER_STARTUPTIME")]
        PLAYERSTARTUPTIME,

        /// <summary>
        /// PLAYERTECH
        /// </summary>
        [EnumMember(Value = "PLAYER_TECH")]
        PLAYERTECH,

        /// <summary>
        /// PLAYERVERSION
        /// </summary>
        [EnumMember(Value = "PLAYER_VERSION")]
        PLAYERVERSION,

        /// <summary>
        /// PROGURL
        /// </summary>
        [EnumMember(Value = "PROG_URL")]
        PROGURL,

        /// <summary>
        /// REGION
        /// </summary>
        [EnumMember(Value = "REGION")]
        REGION,

        /// <summary>
        /// SCALEFACTOR
        /// </summary>
        [EnumMember(Value = "SCALE_FACTOR")]
        SCALEFACTOR,

        /// <summary>
        /// SCREENHEIGHT
        /// </summary>
        [EnumMember(Value = "SCREEN_HEIGHT")]
        SCREENHEIGHT,

        /// <summary>
        /// SCREENWIDTH
        /// </summary>
        [EnumMember(Value = "SCREEN_WIDTH")]
        SCREENWIDTH,

        /// <summary>
        /// SEEKED
        /// </summary>
        [EnumMember(Value = "SEEKED")]
        SEEKED,

        /// <summary>
        /// SEQUENCENUMBER
        /// </summary>
        [EnumMember(Value = "SEQUENCE_NUMBER")]
        SEQUENCENUMBER,

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
        /// STREAMFORMAT
        /// </summary>
        [EnumMember(Value = "STREAM_FORMAT")]
        STREAMFORMAT,

        /// <summary>
        /// SUPPORTEDVIDEOCODECS
        /// </summary>
        [EnumMember(Value = "SUPPORTED_VIDEO_CODECS")]
        SUPPORTEDVIDEOCODECS,

        /// <summary>
        /// TARGETLATENCY
        /// </summary>
        [EnumMember(Value = "TARGET_LATENCY")]
        TARGETLATENCY,

        /// <summary>
        /// TARGETLATENCYDELTA
        /// </summary>
        [EnumMember(Value = "TARGET_LATENCY_DELTA")]
        TARGETLATENCYDELTA,

        /// <summary>
        /// TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,

        /// <summary>
        /// TIMETOTARGETLATENCY
        /// </summary>
        [EnumMember(Value = "TIME_TO_TARGET_LATENCY")]
        TIMETOTARGETLATENCY,

        /// <summary>
        /// USERID
        /// </summary>
        [EnumMember(Value = "USER_ID")]
        USERID,

        /// <summary>
        /// VIDEOBITRATE
        /// </summary>
        [EnumMember(Value = "VIDEO_BITRATE")]
        VIDEOBITRATE,

        /// <summary>
        /// VIDEOCODEC
        /// </summary>
        [EnumMember(Value = "VIDEO_CODEC")]
        VIDEOCODEC,

        /// <summary>
        /// VIDEODURATION
        /// </summary>
        [EnumMember(Value = "VIDEO_DURATION")]
        VIDEODURATION,

        /// <summary>
        /// VIDEOID
        /// </summary>
        [EnumMember(Value = "VIDEO_ID")]
        VIDEOID,

        /// <summary>
        /// VIDEOPLAYBACKHEIGHT
        /// </summary>
        [EnumMember(Value = "VIDEO_PLAYBACK_HEIGHT")]
        VIDEOPLAYBACKHEIGHT,

        /// <summary>
        /// VIDEOPLAYBACKWIDTH
        /// </summary>
        [EnumMember(Value = "VIDEO_PLAYBACK_WIDTH")]
        VIDEOPLAYBACKWIDTH,

        /// <summary>
        /// VIDEOSTARTUPTIME
        /// </summary>
        [EnumMember(Value = "VIDEO_STARTUPTIME")]
        VIDEOSTARTUPTIME,

        /// <summary>
        /// VIDEOTITLE
        /// </summary>
        [EnumMember(Value = "VIDEO_TITLE")]
        VIDEOTITLE,

        /// <summary>
        /// VIDEOWINDOWHEIGHT
        /// </summary>
        [EnumMember(Value = "VIDEO_WINDOW_HEIGHT")]
        VIDEOWINDOWHEIGHT,

        /// <summary>
        /// VIDEOWINDOWWIDTH
        /// </summary>
        [EnumMember(Value = "VIDEO_WINDOW_WIDTH")]
        VIDEOWINDOWWIDTH,

        /// <summary>
        /// VIDEOTIMEEND
        /// </summary>
        [EnumMember(Value = "VIDEOTIME_END")]
        VIDEOTIMEEND,

        /// <summary>
        /// VIDEOTIMESTART
        /// </summary>
        [EnumMember(Value = "VIDEOTIME_START")]
        VIDEOTIMESTART
    }
}
