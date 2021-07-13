using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Determines how IMSC styling is handled.
    /// </summary>
    public enum ImscStylingMode
    {
        /// <summary>
        /// Keep the styling of the input file.
        /// </summary>
        [EnumMember(Value = "PASSTHROUGH")]
        PASSTHROUGH,

        /// <summary>
        /// Drop the styling of the input file.
        /// </summary>
        [EnumMember(Value = "DROP_STYLING")]
        DROP_STYLING
    }
}
