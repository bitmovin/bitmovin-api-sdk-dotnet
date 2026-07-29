using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AgeRange
    /// </summary>
    public enum AgeRange
    {
        /// <summary>
        /// Character appears to be a child
        /// </summary>
        [EnumMember(Value = "CHILD")]
        CHILD,

        /// <summary>
        /// Character appears to be a teen
        /// </summary>
        [EnumMember(Value = "TEEN")]
        TEEN,

        /// <summary>
        /// Character appears to be in their 20s
        /// </summary>
        [EnumMember(Value = "TWENTIES")]
        TWENTIES,

        /// <summary>
        /// Character appears to be in their 30s
        /// </summary>
        [EnumMember(Value = "THIRTIES")]
        THIRTIES,

        /// <summary>
        /// Character appears to be in their 40s
        /// </summary>
        [EnumMember(Value = "FORTIES")]
        FORTIES,

        /// <summary>
        /// Character appears to be in their 50s
        /// </summary>
        [EnumMember(Value = "FIFTIES")]
        FIFTIES,

        /// <summary>
        /// Character appears to be 60 or older
        /// </summary>
        [EnumMember(Value = "SIXTIES_PLUS")]
        SIXTIES_PLUS,

        /// <summary>
        /// Fallback when age range cannot be determined
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
