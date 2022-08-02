using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamConditionsMode
    /// </summary>
    public enum StreamConditionsMode
    {
        /// <summary>
        /// The whole muxing will be ignored if at least one of its Streams is ignored
        /// </summary>
        [EnumMember(Value = "DROP_MUXING")]
        DROP_MUXING,

        /// <summary>
        /// Ignored Streams will be omitted from the muxing. The muxing will only be ignored if all of its Streams are ignored
        /// </summary>
        [EnumMember(Value = "DROP_STREAM")]
        DROP_STREAM
    }
}
