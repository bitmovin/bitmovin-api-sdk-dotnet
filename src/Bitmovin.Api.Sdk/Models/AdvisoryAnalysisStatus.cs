using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdvisoryAnalysisStatus
    /// </summary>
    public enum AdvisoryAnalysisStatus
    {
        /// <summary>
        /// Advisory assessment completed. An empty or omitted advisory list means no advisories were reported.
        /// </summary>
        [EnumMember(Value = "ANALYZED")]
        ANALYZED,

        /// <summary>
        /// The shot could not be assessed. It carries a conservative TOBACCO advisory with UNKNOWN confidence because no verdict is available. This advisory is an assumption, not an observed detection. Review the shot manually.
        /// </summary>
        [EnumMember(Value = "BLOCKED")]
        BLOCKED
    }
}
