using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AiSceneAnalysisLiveStatus
    /// </summary>
    public enum AiSceneAnalysisLiveStatus
    {
        /// <summary>
        /// The Analysis has been created and has not been started
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// The start request was accepted and AI analysis is preparing to receive input
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,

        /// <summary>
        /// AI analysis is ready to receive RTMP input
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,

        /// <summary>
        /// The running analysis stopped gracefully and final required delivery completed
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,

        /// <summary>
        /// Queued work was stopped before analysis began
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,

        /// <summary>
        /// Provisioning, validation, processing, or final generation failed
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// Required result delivery exhausted its retry budget
        /// </summary>
        [EnumMember(Value = "TRANSFER_ERROR")]
        TRANSFER_ERROR
    }
}
