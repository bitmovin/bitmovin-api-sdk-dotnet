using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PcmSampleFormat
    /// </summary>
    public enum PcmSampleFormat
    {
        /// <summary>
        /// Signed 16 bit little endian sampling
        /// </summary>
        [EnumMember(Value = "S16LE")]
        S16LE,

        /// <summary>
        /// Signed 24 bit little endian sampling
        /// </summary>
        [EnumMember(Value = "S24LE")]
        S24LE,

        /// <summary>
        /// Singed 32 bit little endian sampling
        /// </summary>
        [EnumMember(Value = "S32LE")]
        S32LE
    }
}
