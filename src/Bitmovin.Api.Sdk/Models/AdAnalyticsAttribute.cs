using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdAnalyticsAttribute
    /// </summary>
    public enum AdAnalyticsAttribute
    {
        /// <summary>
        /// ADIMPRESSIONID
        /// </summary>
        [EnumMember(Value = "AD_IMPRESSION_ID")]
        ADIMPRESSIONID,

        /// <summary>
        /// ADCLICKTHROUGHURL
        /// </summary>
        [EnumMember(Value = "AD_CLICKTHROUGH_URL")]
        ADCLICKTHROUGHURL,

        /// <summary>
        /// ADDESCRIPTION
        /// </summary>
        [EnumMember(Value = "AD_DESCRIPTION")]
        ADDESCRIPTION,

        /// <summary>
        /// ADDURATION
        /// </summary>
        [EnumMember(Value = "AD_DURATION")]
        ADDURATION,

        /// <summary>
        /// ADFALLBACKINDEX
        /// </summary>
        [EnumMember(Value = "AD_FALLBACK_INDEX")]
        ADFALLBACKINDEX,

        /// <summary>
        /// ADID
        /// </summary>
        [EnumMember(Value = "AD_ID")]
        ADID,

        /// <summary>
        /// ADIDPLAYER
        /// </summary>
        [EnumMember(Value = "AD_ID_PLAYER")]
        ADIDPLAYER,

        /// <summary>
        /// ADISPERSISTENT
        /// </summary>
        [EnumMember(Value = "AD_IS_PERSISTENT")]
        ADISPERSISTENT,

        /// <summary>
        /// ADMODULE
        /// </summary>
        [EnumMember(Value = "AD_MODULE")]
        ADMODULE,

        /// <summary>
        /// ADOFFSET
        /// </summary>
        [EnumMember(Value = "AD_OFFSET")]
        ADOFFSET,

        /// <summary>
        /// ADPLAYBACKHEIGHT
        /// </summary>
        [EnumMember(Value = "AD_PLAYBACK_HEIGHT")]
        ADPLAYBACKHEIGHT,

        /// <summary>
        /// ADPLAYBACKWIDTH
        /// </summary>
        [EnumMember(Value = "AD_PLAYBACK_WIDTH")]
        ADPLAYBACKWIDTH,

        /// <summary>
        /// ADPODPOSITION
        /// </summary>
        [EnumMember(Value = "AD_POD_POSITION")]
        ADPODPOSITION,

        /// <summary>
        /// ADPOSITION
        /// </summary>
        [EnumMember(Value = "AD_POSITION")]
        ADPOSITION,

        /// <summary>
        /// ADPRELOADOFFSET
        /// </summary>
        [EnumMember(Value = "AD_PRELOAD_OFFSET")]
        ADPRELOADOFFSET,

        /// <summary>
        /// ADREPLACECONTENTDURATION
        /// </summary>
        [EnumMember(Value = "AD_REPLACE_CONTENT_DURATION")]
        ADREPLACECONTENTDURATION,

        /// <summary>
        /// ADSCHEDULETIME
        /// </summary>
        [EnumMember(Value = "AD_SCHEDULE_TIME")]
        ADSCHEDULETIME,

        /// <summary>
        /// ADSKIPAFTER
        /// </summary>
        [EnumMember(Value = "AD_SKIP_AFTER")]
        ADSKIPAFTER,

        /// <summary>
        /// ADSKIPPABLE
        /// </summary>
        [EnumMember(Value = "AD_SKIPPABLE")]
        ADSKIPPABLE,

        /// <summary>
        /// ADSTARTUPTIME
        /// </summary>
        [EnumMember(Value = "AD_STARTUP_TIME")]
        ADSTARTUPTIME,

        /// <summary>
        /// ADSYSTEM
        /// </summary>
        [EnumMember(Value = "AD_SYSTEM")]
        ADSYSTEM,

        /// <summary>
        /// ADTAGPATH
        /// </summary>
        [EnumMember(Value = "AD_TAG_PATH")]
        ADTAGPATH,

        /// <summary>
        /// ADTAGSERVER
        /// </summary>
        [EnumMember(Value = "AD_TAG_SERVER")]
        ADTAGSERVER,

        /// <summary>
        /// ADTAGTYPE
        /// </summary>
        [EnumMember(Value = "AD_TAG_TYPE")]
        ADTAGTYPE,

        /// <summary>
        /// ADTAGURL
        /// </summary>
        [EnumMember(Value = "AD_TAG_URL")]
        ADTAGURL,

        /// <summary>
        /// ADTITLE
        /// </summary>
        [EnumMember(Value = "AD_TITLE")]
        ADTITLE,

        /// <summary>
        /// ADWRAPPERADSCOUNT
        /// </summary>
        [EnumMember(Value = "AD_WRAPPER_ADS_COUNT")]
        ADWRAPPERADSCOUNT,

        /// <summary>
        /// ADVERTISERNAME
        /// </summary>
        [EnumMember(Value = "ADVERTISER_NAME")]
        ADVERTISERNAME,

        /// <summary>
        /// ANALYTICSVERSION
        /// </summary>
        [EnumMember(Value = "ANALYTICS_VERSION")]
        ANALYTICSVERSION,

        /// <summary>
        /// APIFRAMEWORK
        /// </summary>
        [EnumMember(Value = "API_FRAMEWORK")]
        APIFRAMEWORK,

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
        /// CLICKPERCENTAGE
        /// </summary>
        [EnumMember(Value = "CLICK_PERCENTAGE")]
        CLICKPERCENTAGE,

        /// <summary>
        /// CLICKPOSITION
        /// </summary>
        [EnumMember(Value = "CLICK_POSITION")]
        CLICKPOSITION,

        /// <summary>
        /// CLICKED
        /// </summary>
        [EnumMember(Value = "CLICKED")]
        CLICKED,

        /// <summary>
        /// CLIENTTIME
        /// </summary>
        [EnumMember(Value = "CLIENT_TIME")]
        CLIENTTIME,

        /// <summary>
        /// CLOSEPERCENTAGE
        /// </summary>
        [EnumMember(Value = "CLOSE_PERCENTAGE")]
        CLOSEPERCENTAGE,

        /// <summary>
        /// CLOSEPOSITION
        /// </summary>
        [EnumMember(Value = "CLOSE_POSITION")]
        CLOSEPOSITION,

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
        /// CREATIVEADID
        /// </summary>
        [EnumMember(Value = "CREATIVE_AD_ID")]
        CREATIVEADID,

        /// <summary>
        /// CREATIVEID
        /// </summary>
        [EnumMember(Value = "CREATIVE_ID")]
        CREATIVEID,

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
        /// DEALID
        /// </summary>
        [EnumMember(Value = "DEAL_ID")]
        DEALID,

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
        /// ERRORCODE
        /// </summary>
        [EnumMember(Value = "ERROR_CODE")]
        ERRORCODE,

        /// <summary>
        /// ERRORPERCENTAGE
        /// </summary>
        [EnumMember(Value = "ERROR_PERCENTAGE")]
        ERRORPERCENTAGE,

        /// <summary>
        /// ERRORPOSITION
        /// </summary>
        [EnumMember(Value = "ERROR_POSITION")]
        ERRORPOSITION,

        /// <summary>
        /// EXITPOSITION
        /// </summary>
        [EnumMember(Value = "EXIT_POSITION")]
        EXITPOSITION,

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
        /// IPADDRESS
        /// </summary>
        [EnumMember(Value = "IP_ADDRESS")]
        IPADDRESS,

        /// <summary>
        /// ISLINEAR
        /// </summary>
        [EnumMember(Value = "IS_LINEAR")]
        ISLINEAR,

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
        /// LICENSEKEY
        /// </summary>
        [EnumMember(Value = "LICENSE_KEY")]
        LICENSEKEY,

        /// <summary>
        /// MANIFESTDOWNLOADTIME
        /// </summary>
        [EnumMember(Value = "MANIFEST_DOWNLOAD_TIME")]
        MANIFESTDOWNLOADTIME,

        /// <summary>
        /// MEDIAPATH
        /// </summary>
        [EnumMember(Value = "MEDIA_PATH")]
        MEDIAPATH,

        /// <summary>
        /// MEDIASERVER
        /// </summary>
        [EnumMember(Value = "MEDIA_SERVER")]
        MEDIASERVER,

        /// <summary>
        /// MEDIAURL
        /// </summary>
        [EnumMember(Value = "MEDIA_URL")]
        MEDIAURL,

        /// <summary>
        /// MIDPOINT
        /// </summary>
        [EnumMember(Value = "MIDPOINT")]
        MIDPOINT,

        /// <summary>
        /// MINSUGGESTEDDURATION
        /// </summary>
        [EnumMember(Value = "MIN_SUGGESTED_DURATION")]
        MINSUGGESTEDDURATION,

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
        /// PERCENTAGEINVIEWPORT
        /// </summary>
        [EnumMember(Value = "PERCENTAGE_IN_VIEWPORT")]
        PERCENTAGEINVIEWPORT,

        /// <summary>
        /// PLATFORM
        /// </summary>
        [EnumMember(Value = "PLATFORM")]
        PLATFORM,

        /// <summary>
        /// PLAYPERCENTAGE
        /// </summary>
        [EnumMember(Value = "PLAY_PERCENTAGE")]
        PLAYPERCENTAGE,

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
        /// QUARTILE1
        /// </summary>
        [EnumMember(Value = "QUARTILE_1")]
        QUARTILE1,

        /// <summary>
        /// QUARTILE3
        /// </summary>
        [EnumMember(Value = "QUARTILE_3")]
        QUARTILE3,

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
        /// SIZE
        /// </summary>
        [EnumMember(Value = "SIZE")]
        SIZE,

        /// <summary>
        /// SKIPPERCENTAGE
        /// </summary>
        [EnumMember(Value = "SKIP_PERCENTAGE")]
        SKIPPERCENTAGE,

        /// <summary>
        /// SKIPPOSITION
        /// </summary>
        [EnumMember(Value = "SKIP_POSITION")]
        SKIPPOSITION,

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
        /// STREAMFORMAT
        /// </summary>
        [EnumMember(Value = "STREAM_FORMAT")]
        STREAMFORMAT,

        /// <summary>
        /// SURVEYURL
        /// </summary>
        [EnumMember(Value = "SURVEY_URL")]
        SURVEYURL,

        /// <summary>
        /// TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,

        /// <summary>
        /// TIMEFROMCONTENT
        /// </summary>
        [EnumMember(Value = "TIME_FROM_CONTENT")]
        TIMEFROMCONTENT,

        /// <summary>
        /// TIMEINVIEWPORT
        /// </summary>
        [EnumMember(Value = "TIME_IN_VIEWPORT")]
        TIMEINVIEWPORT,

        /// <summary>
        /// TIMEPLAYED
        /// </summary>
        [EnumMember(Value = "TIME_PLAYED")]
        TIMEPLAYED,

        /// <summary>
        /// TIMETOCONTENT
        /// </summary>
        [EnumMember(Value = "TIME_TO_CONTENT")]
        TIMETOCONTENT,

        /// <summary>
        /// UNIVERSALADIDREGISTRY
        /// </summary>
        [EnumMember(Value = "UNIVERSAL_AD_ID_REGISTRY")]
        UNIVERSALADIDREGISTRY,

        /// <summary>
        /// UNIVERSALADIDVALUE
        /// </summary>
        [EnumMember(Value = "UNIVERSAL_AD_ID_VALUE")]
        UNIVERSALADIDVALUE,

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
        /// VIDEOID
        /// </summary>
        [EnumMember(Value = "VIDEO_ID")]
        VIDEOID,

        /// <summary>
        /// VIDEOIMPRESSIONID
        /// </summary>
        [EnumMember(Value = "VIDEO_IMPRESSION_ID")]
        VIDEOIMPRESSIONID,

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
        VIDEOWINDOWWIDTH
    }
}
