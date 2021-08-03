using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AudioVideoSyncMode
    /// </summary>
    public enum AudioVideoSyncMode
    {
        /// <summary>
        /// Do not add or drop any audio samples.
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD,

        /// <summary>
        /// Drop audio samples or add audio silence samples at the start of the audio stream.
        /// </summary>
        [EnumMember(Value = "RESYNC_AT_START")]
        RESYNC_AT_START,

        /// <summary>
        /// Adds or drops audio samples at the start.&lt;br&gt; Adds silence audio samples at the end of the audio inputs.&lt;br&gt; This mode does not drop audio samples from the end.
        /// </summary>
        [EnumMember(Value = "RESYNC_AT_START_AND_END")]
        RESYNC_AT_START_AND_END
    }
}
