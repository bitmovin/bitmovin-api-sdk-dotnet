using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamKeyConfigurationType
    /// </summary>
    public enum StreamKeyConfigurationType
    {
        /// <summary>
        /// A temporary stream key with a random 20 characters string will be generated
        /// </summary>
        [EnumMember(Value = "GENERATE")]
        GENERATE,

        /// <summary>
        /// A previously generated reserved stream key will be assigned
        /// </summary>
        [EnumMember(Value = "ASSIGN")]
        ASSIGN
    }
}
