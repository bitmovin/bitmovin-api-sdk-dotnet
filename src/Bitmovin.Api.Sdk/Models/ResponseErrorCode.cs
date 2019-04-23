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
    /// ResponseErrorCode
    /// </summary>
    public enum ResponseErrorCode
    {
        /// <summary>
        /// GENERALMISSINGATTRIBUTEORFIELD
        /// </summary>
        [EnumMember(Value = "GENERAL_MISSING_ATTRIBUTE_OR_FIELD")]
        GENERALMISSINGATTRIBUTEORFIELD,
        
        /// <summary>
        /// GENERALPARAMETERNOTVALID
        /// </summary>
        [EnumMember(Value = "GENERAL_PARAMETER_NOT_VALID")]
        GENERALPARAMETERNOTVALID,
        
        /// <summary>
        /// GENERALINVALIDCREDENTIALS
        /// </summary>
        [EnumMember(Value = "GENERAL_INVALID_CREDENTIALS")]
        GENERALINVALIDCREDENTIALS,
        
        /// <summary>
        /// GENERALUNAUTHORIZED
        /// </summary>
        [EnumMember(Value = "GENERAL_UNAUTHORIZED")]
        GENERALUNAUTHORIZED,
        
        /// <summary>
        /// GENERALUNDEFINEDERROR
        /// </summary>
        [EnumMember(Value = "GENERAL_UNDEFINED_ERROR")]
        GENERALUNDEFINEDERROR,
        
        /// <summary>
        /// GENERALREQUESTURLNOTVALID
        /// </summary>
        [EnumMember(Value = "GENERAL_REQUEST_URL_NOT_VALID")]
        GENERALREQUESTURLNOTVALID,
        
        /// <summary>
        /// ENCODINGGENERALENCODINGRESOURCEERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_ENCODING_RESOURCE_ERROR")]
        ENCODINGGENERALENCODINGRESOURCEERROR,
        
        /// <summary>
        /// ENCODINGGENERALINPUTNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_INPUT_NOT_VALID")]
        ENCODINGGENERALINPUTNOTVALID,
        
        /// <summary>
        /// ENCODINGGENERALOUTPUTNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_OUTPUT_NOT_VALID")]
        ENCODINGGENERALOUTPUTNOTVALID,
        
        /// <summary>
        /// ENCODINGGENERALMUXINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_MUXING_ERROR")]
        ENCODINGGENERALMUXINGERROR,
        
        /// <summary>
        /// ENCODINGGENERALENCRYPTIONERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_ENCRYPTION_ERROR")]
        ENCODINGGENERALENCRYPTIONERROR,
        
        /// <summary>
        /// ENCODINGGENERALFILTERERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_FILTER_ERROR")]
        ENCODINGGENERALFILTERERROR,
        
        /// <summary>
        /// ENCODINGGENERALCAPTIONSERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_CAPTIONS_ERROR")]
        ENCODINGGENERALCAPTIONSERROR,
        
        /// <summary>
        /// ENCODINGGENERALSUBTITLEERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_SUBTITLE_ERROR")]
        ENCODINGGENERALSUBTITLEERROR,
        
        /// <summary>
        /// ENCODINGGENERALCODECCONFIGURATIONERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_CODEC_CONFIGURATION_ERROR")]
        ENCODINGGENERALCODECCONFIGURATIONERROR,
        
        /// <summary>
        /// ENCODINGGENERALTHUMBNAILERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_THUMBNAIL_ERROR")]
        ENCODINGGENERALTHUMBNAILERROR,
        
        /// <summary>
        /// ENCODINGGENERALSPRITEERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_SPRITE_ERROR")]
        ENCODINGGENERALSPRITEERROR,
        
        /// <summary>
        /// ENCODINGGENERALLIVEERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_LIVE_ERROR")]
        ENCODINGGENERALLIVEERROR,
        
        /// <summary>
        /// ENCODINGGENERALDEMUXINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_DEMUXING_ERROR")]
        ENCODINGGENERALDEMUXINGERROR,
        
        /// <summary>
        /// ENCODINGGENERALDECODINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_DECODING_ERROR")]
        ENCODINGGENERALDECODINGERROR,
        
        /// <summary>
        /// ENCODINGGENERALENCODINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_ENCODING_ERROR")]
        ENCODINGGENERALENCODINGERROR,
        
        /// <summary>
        /// ENCODINGGENERALUPLOADERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_UPLOAD_ERROR")]
        ENCODINGGENERALUPLOADERROR,
        
        /// <summary>
        /// ENCODINGGENERALINTERNALERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_INTERNAL_ERROR")]
        ENCODINGGENERALINTERNALERROR,
        
        /// <summary>
        /// ENCODINGGENERALINFRASTRUCTUREERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_INFRASTRUCTURE_ERROR")]
        ENCODINGGENERALINFRASTRUCTUREERROR,
        
        /// <summary>
        /// ENCODINGGENERALINVALIDENCODERVERSION
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_INVALID_ENCODER_VERSION")]
        ENCODINGGENERALINVALIDENCODERVERSION,
        
        /// <summary>
        /// ENCODINGGENERALDELETENOTALLOWED
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_DELETE_NOT_ALLOWED")]
        ENCODINGGENERALDELETENOTALLOWED,
        
        /// <summary>
        /// ENCODINGGENERALCOULDNOTSTOPLIVEENCODING
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_COULD_NOT_STOP_LIVE_ENCODING")]
        ENCODINGGENERALCOULDNOTSTOPLIVEENCODING,
        
        /// <summary>
        /// ENCODINGGENERALLIVEENCODINGNOTREADY
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_LIVE_ENCODING_NOT_READY")]
        ENCODINGGENERALLIVEENCODINGNOTREADY,
        
        /// <summary>
        /// ENCODINGGENERALSTREAMINPUTDETAILSNOTAVAILABLE
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_STREAM_INPUT_DETAILS_NOT_AVAILABLE")]
        ENCODINGGENERALSTREAMINPUTDETAILSNOTAVAILABLE,
        
        /// <summary>
        /// ENCODINGGENERALENCODINGCONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_ENCODING_CONFIGURATION_NOT_VALID")]
        ENCODINGGENERALENCODINGCONFIGURATIONNOTVALID,
        
        /// <summary>
        /// ENCODINGGENERALONPREMISENOTALLOWED
        /// </summary>
        [EnumMember(Value = "ENCODING_GENERAL_ON_PREMISE_NOT_ALLOWED")]
        ENCODINGGENERALONPREMISENOTALLOWED,
        
        /// <summary>
        /// ENCODINGINPUTINPUTFILENOTFOUND
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_INPUT_FILE_NOT_FOUND")]
        ENCODINGINPUTINPUTFILENOTFOUND,
        
        /// <summary>
        /// ENCODINGINPUTBUCKETNOTFOUND
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_BUCKET_NOT_FOUND")]
        ENCODINGINPUTBUCKETNOTFOUND,
        
        /// <summary>
        /// ENCODINGINPUTINVALIDFILEPATH
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_INVALID_FILE_PATH")]
        ENCODINGINPUTINVALIDFILEPATH,
        
        /// <summary>
        /// ENCODINGINPUTDOWNLOADACCESSDENIED
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_DOWNLOAD_ACCESS_DENIED")]
        ENCODINGINPUTDOWNLOADACCESSDENIED,
        
        /// <summary>
        /// ENCODINGINPUTDOWNLOADTIMEOUT
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_DOWNLOAD_TIMEOUT")]
        ENCODINGINPUTDOWNLOADTIMEOUT,
        
        /// <summary>
        /// ENCODINGINPUTDOWNLOADFAILURE
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_DOWNLOAD_FAILURE")]
        ENCODINGINPUTDOWNLOADFAILURE,
        
        /// <summary>
        /// ENCODINGINPUTREMOTESERVERPROBLEM
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_REMOTE_SERVER_PROBLEM")]
        ENCODINGINPUTREMOTESERVERPROBLEM,
        
        /// <summary>
        /// ENCODINGINPUTINPUTFILEISNOTAVALIDMEDIAFILE
        /// </summary>
        [EnumMember(Value = "ENCODING_INPUT_INPUT_FILE_IS_NOT_A_VALID_MEDIA_FILE")]
        ENCODINGINPUTINPUTFILEISNOTAVALIDMEDIAFILE,
        
        /// <summary>
        /// ENCODINGOUTPUTBUCKETNOTFOUND
        /// </summary>
        [EnumMember(Value = "ENCODING_OUTPUT_BUCKET_NOT_FOUND")]
        ENCODINGOUTPUTBUCKETNOTFOUND,
        
        /// <summary>
        /// ENCODINGOUTPUTINVALIDFILEPATH
        /// </summary>
        [EnumMember(Value = "ENCODING_OUTPUT_INVALID_FILE_PATH")]
        ENCODINGOUTPUTINVALIDFILEPATH,
        
        /// <summary>
        /// ENCODINGOUTPUTUPLOADACCESSDENIED
        /// </summary>
        [EnumMember(Value = "ENCODING_OUTPUT_UPLOAD_ACCESS_DENIED")]
        ENCODINGOUTPUTUPLOADACCESSDENIED,
        
        /// <summary>
        /// ENCODINGOUTPUTUPLOADTIMEOUT
        /// </summary>
        [EnumMember(Value = "ENCODING_OUTPUT_UPLOAD_TIMEOUT")]
        ENCODINGOUTPUTUPLOADTIMEOUT,
        
        /// <summary>
        /// ENCODINGOUTPUTUPLOADFAILURE
        /// </summary>
        [EnumMember(Value = "ENCODING_OUTPUT_UPLOAD_FAILURE")]
        ENCODINGOUTPUTUPLOADFAILURE,
        
        /// <summary>
        /// ENCODINGOUTPUTREMOTESERVERPROBLEM
        /// </summary>
        [EnumMember(Value = "ENCODING_OUTPUT_REMOTE_SERVER_PROBLEM")]
        ENCODINGOUTPUTREMOTESERVERPROBLEM,
        
        /// <summary>
        /// ENCODINGCODECCONFIGURATIONH264CONFIGURATIONERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_CODEC_CONFIGURATION_H264_CONFIGURATION_ERROR")]
        ENCODINGCODECCONFIGURATIONH264CONFIGURATIONERROR,
        
        /// <summary>
        /// ENCODINGCODECCONFIGURATIONH265CONFIGURATIONERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_CODEC_CONFIGURATION_H265_CONFIGURATION_ERROR")]
        ENCODINGCODECCONFIGURATIONH265CONFIGURATIONERROR,
        
        /// <summary>
        /// ENCODINGCODECCONFIGURATIONAACCONFIGURATIONERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_CODEC_CONFIGURATION_AAC_CONFIGURATION_ERROR")]
        ENCODINGCODECCONFIGURATIONAACCONFIGURATIONERROR,
        
        /// <summary>
        /// ENCODINGFILTERWATERMARKCONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_FILTER_WATERMARK_CONFIGURATION_NOT_VALID")]
        ENCODINGFILTERWATERMARKCONFIGURATIONNOTVALID,
        
        /// <summary>
        /// ENCODINGFILTERWATERMARKENCODINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_FILTER_WATERMARK_ENCODING_ERROR")]
        ENCODINGFILTERWATERMARKENCODINGERROR,
        
        /// <summary>
        /// ENCODINGFILTERCROPCONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_FILTER_CROP_CONFIGURATION_NOT_VALID")]
        ENCODINGFILTERCROPCONFIGURATIONNOTVALID,
        
        /// <summary>
        /// ENCODINGFILTERCROPENCODINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_FILTER_CROP_ENCODING_ERROR")]
        ENCODINGFILTERCROPENCODINGERROR,
        
        /// <summary>
        /// ENCODINGFILTERROTATECONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_FILTER_ROTATE_CONFIGURATION_NOT_VALID")]
        ENCODINGFILTERROTATECONFIGURATIONNOTVALID,
        
        /// <summary>
        /// ENCODINGFILTERROTATEENCODINGERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_FILTER_ROTATE_ENCODING_ERROR")]
        ENCODINGFILTERROTATEENCODINGERROR,
        
        /// <summary>
        /// ENCODINGMANIFESTDASHMANIFESTCONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_MANIFEST_DASH_MANIFEST_CONFIGURATION_NOT_VALID")]
        ENCODINGMANIFESTDASHMANIFESTCONFIGURATIONNOTVALID,
        
        /// <summary>
        /// ENCODINGMANIFESTHLSMANIFESTCONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_MANIFEST_HLS_MANIFEST_CONFIGURATION_NOT_VALID")]
        ENCODINGMANIFESTHLSMANIFESTCONFIGURATIONNOTVALID,
        
        /// <summary>
        /// ENCODINGTRANSFERCONFIGURATIONNOTVALID
        /// </summary>
        [EnumMember(Value = "ENCODING_TRANSFER_CONFIGURATION_NOT_VALID")]
        ENCODINGTRANSFERCONFIGURATIONNOTVALID,
        
        /// <summary>
        /// STORAGEGENERALERROR
        /// </summary>
        [EnumMember(Value = "STORAGE_GENERAL_ERROR")]
        STORAGEGENERALERROR,
        
        /// <summary>
        /// STORAGENOTACCESSABLE
        /// </summary>
        [EnumMember(Value = "STORAGE_NOT_ACCESSABLE")]
        STORAGENOTACCESSABLE,
        
        /// <summary>
        /// PLAYERGENERALERROR
        /// </summary>
        [EnumMember(Value = "PLAYER_GENERAL_ERROR")]
        PLAYERGENERALERROR,
        
        /// <summary>
        /// PLAYERDOMAINNOTVALID
        /// </summary>
        [EnumMember(Value = "PLAYER_DOMAIN_NOT_VALID")]
        PLAYERDOMAINNOTVALID,
        
        /// <summary>
        /// ANALYTICSGENERALERROR
        /// </summary>
        [EnumMember(Value = "ANALYTICS_GENERAL_ERROR")]
        ANALYTICSGENERALERROR,
        
        /// <summary>
        /// ANALYTICSINFRASTRUCTUREERROR
        /// </summary>
        [EnumMember(Value = "ANALYTICS_INFRASTRUCTURE_ERROR")]
        ANALYTICSINFRASTRUCTUREERROR,
        
        /// <summary>
        /// ANALYTICSEXPORTBUCKETNOTFOUND
        /// </summary>
        [EnumMember(Value = "ANALYTICS_EXPORT_BUCKET_NOT_FOUND")]
        ANALYTICSEXPORTBUCKETNOTFOUND,
        
        /// <summary>
        /// ANALYTICSEXPORTINVALIDFILEPATH
        /// </summary>
        [EnumMember(Value = "ANALYTICS_EXPORT_INVALID_FILE_PATH")]
        ANALYTICSEXPORTINVALIDFILEPATH,
        
        /// <summary>
        /// ANALYTICSEXPORTUPLOADACCESSDENIED
        /// </summary>
        [EnumMember(Value = "ANALYTICS_EXPORT_UPLOAD_ACCESS_DENIED")]
        ANALYTICSEXPORTUPLOADACCESSDENIED,
        
        /// <summary>
        /// ANALYTICSEXPORTUPLOADFAILURE
        /// </summary>
        [EnumMember(Value = "ANALYTICS_EXPORT_UPLOAD_FAILURE")]
        ANALYTICSEXPORTUPLOADFAILURE,
        
        /// <summary>
        /// ACCOUNTGENERALERROR
        /// </summary>
        [EnumMember(Value = "ACCOUNT_GENERAL_ERROR")]
        ACCOUNTGENERALERROR,
        
        /// <summary>
        /// ACCOUNTUNKNOWNORGANIZATION
        /// </summary>
        [EnumMember(Value = "ACCOUNT_UNKNOWN_ORGANIZATION")]
        ACCOUNTUNKNOWNORGANIZATION,
        
        /// <summary>
        /// ACCOUNTUNKNOWNTENANT
        /// </summary>
        [EnumMember(Value = "ACCOUNT_UNKNOWN_TENANT")]
        ACCOUNTUNKNOWNTENANT,
        
        /// <summary>
        /// ACCOUNTINTERNALCOULDNOTCREATEUSERONGATEWAY
        /// </summary>
        [EnumMember(Value = "ACCOUNT_INTERNAL_COULD_NOT_CREATE_USER_ON_GATEWAY")]
        ACCOUNTINTERNALCOULDNOTCREATEUSERONGATEWAY,
        
        /// <summary>
        /// ACCOUNTINTERNALCOULDNOTCREATEAPIKEYONGATEWAY
        /// </summary>
        [EnumMember(Value = "ACCOUNT_INTERNAL_COULD_NOT_CREATE_APIKEY_ON_GATEWAY")]
        ACCOUNTINTERNALCOULDNOTCREATEAPIKEYONGATEWAY,
        
        /// <summary>
        /// ACCOUNTINTERNALCOULDNOTDELETEUSERONGATEWAY
        /// </summary>
        [EnumMember(Value = "ACCOUNT_INTERNAL_COULD_NOT_DELETE_USER_ON_GATEWAY")]
        ACCOUNTINTERNALCOULDNOTDELETEUSERONGATEWAY,
        
        /// <summary>
        /// ACCOUNTINTERNALCOULDNOTDELETEAPIKEYONGATEWAY
        /// </summary>
        [EnumMember(Value = "ACCOUNT_INTERNAL_COULD_NOT_DELETE_API_KEY_ON_GATEWAY")]
        ACCOUNTINTERNALCOULDNOTDELETEAPIKEYONGATEWAY,
        
        /// <summary>
        /// ACCOUNTINTERNALAPIGATEWAYCOMMUNICATIONFAILURE
        /// </summary>
        [EnumMember(Value = "ACCOUNT_INTERNAL_API_GATEWAY_COMMUNICATION_FAILURE")]
        ACCOUNTINTERNALAPIGATEWAYCOMMUNICATIONFAILURE,
        
        /// <summary>
        /// NOTIFCATIONGENERALERROR
        /// </summary>
        [EnumMember(Value = "NOTIFCATION_GENERAL_ERROR")]
        NOTIFCATIONGENERALERROR
        
    }

}
