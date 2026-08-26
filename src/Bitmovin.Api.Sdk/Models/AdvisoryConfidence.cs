using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdvisoryConfidence
    /// </summary>
    public enum AdvisoryConfidence
    {
        /// <summary>
        /// The model is certain of the detection, with the subject plainly visible
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH,

        /// <summary>
        /// The model is reasonably certain, but the subject is partly obscured, brief or otherwise not plainly visible
        /// </summary>
        [EnumMember(Value = "MEDIUM")]
        MEDIUM,

        /// <summary>
        /// The model flagged the shot on a cue it could not resolve, for example a small, dark or fleeting object, and another reading of it is possible. Detection is tuned to flag uncertain cases rather than miss them, so advisories below HIGH confidence are expected
        /// </summary>
        [EnumMember(Value = "LOW")]
        LOW,

        /// <summary>
        /// No confidence could be established because the shot was never assessed. Returned with status BLOCKED, where the advisory is a conservative assumption rather than an observation
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
