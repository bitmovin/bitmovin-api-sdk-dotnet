using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdvisoryConfidence
    /// </summary>
    public enum AdvisoryConfidence
    {
        /// <summary>
        /// The analysis reported a visible product, packaging or signage associated with the advisory category.
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH,

        /// <summary>
        /// The analysis based the advisory mainly on smoke rising from a person.
        /// </summary>
        [EnumMember(Value = "MEDIUM")]
        MEDIUM,

        /// <summary>
        /// The analysis reported an ambiguous shape that could indicate the advisory category. The cue is uncertain and should be reviewed.
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
