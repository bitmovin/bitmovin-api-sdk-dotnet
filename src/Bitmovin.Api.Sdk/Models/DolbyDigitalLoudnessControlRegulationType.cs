using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyDigitalLoudnessControlRegulationType
    /// </summary>
    public enum DolbyDigitalLoudnessControlRegulationType
    {
        /// <summary>
        /// EBU 128 loudness control regulation type
        /// </summary>
        [EnumMember(Value = "EBU_R128")]
        EBU_R128,

        /// <summary>
        /// ATSC A85 loudness control regulation type
        /// </summary>
        [EnumMember(Value = "ATSC_A85_FIXED")]
        ATSC_A85_FIXED,

        /// <summary>
        /// ATSC A85 loudness control regulation type
        /// </summary>
        [EnumMember(Value = "ATSC_A85_AGILE")]
        ATSC_A85_AGILE,

        /// <summary>
        /// Manual loudness control regulation type
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL
    }
}
