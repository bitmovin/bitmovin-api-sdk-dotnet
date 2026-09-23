using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AiSceneAnalysisLiveSourceGapReason
    /// </summary>
    public enum AiSceneAnalysisLiveSourceGapReason
    {
        /// <summary>
        /// The RTMP source disconnected and later reconnected
        /// </summary>
        [EnumMember(Value = "SOURCE_DISCONNECTED")]
        SOURCE_DISCONNECTED,

        /// <summary>
        /// The media interval was not analyzed because temporary storage capacity was reached
        /// </summary>
        [EnumMember(Value = "PROCESSING_MEDIA_PRESSURE")]
        PROCESSING_MEDIA_PRESSURE,

        /// <summary>
        /// The media interval was not analyzed because analysis lag exceeded the configured maximum latency and the analysis window was skipped to catch up
        /// </summary>
        [EnumMember(Value = "ANALYSIS_LAG")]
        ANALYSIS_LAG,

        /// <summary>
        /// The media interval was not analyzed because the analysis window could not be created from the recorded media
        /// </summary>
        [EnumMember(Value = "WINDOW_BUILD_FAILED")]
        WINDOW_BUILD_FAILED,

        /// <summary>
        /// The media interval was received but remained unanalyzed when AI analysis ended
        /// </summary>
        [EnumMember(Value = "FINALIZATION_BACKLOG")]
        FINALIZATION_BACKLOG
    }
}
