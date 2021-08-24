using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// WatchFolderStatus
    /// </summary>
    public enum WatchFolderStatus
    {
        /// <summary>
        /// The watch folder is currently inactive
        /// </summary>
        [EnumMember(Value = "STOPPED")]
        STOPPED,

        /// <summary>
        /// The watch folder is currently active and monitors the storage for new files to be encoded
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// The watch folder is inactive due to an error
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
