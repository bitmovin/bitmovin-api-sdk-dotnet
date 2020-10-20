using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SmpteTimecodeFlavor
    /// </summary>
    public enum SmpteTimecodeFlavor
    {
        /// <summary>
        /// Automatically detect the flavor of timecodes depending on the separation character between seconds and frames (&quot;:&quot; meaning NON_DROP_FRAME, &quot;;&quot; or &quot;.&quot; meaning DROP_FRAME)
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// Interpret timecodes as non-drop frame (NDF or wall-clock time) timecodes
        /// </summary>
        [EnumMember(Value = "NON_DROP_FRAME")]
        NON_DROP_FRAME,

        /// <summary>
        /// Interpret timecodes as drop-frame (DF) timecodes
        /// </summary>
        [EnumMember(Value = "DROP_FRAME")]
        DROP_FRAME
    }
}
