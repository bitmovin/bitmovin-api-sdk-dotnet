using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SceneAnalysisListSort
    /// </summary>
    public enum SceneAnalysisListSort
    {
        /// <summary>
        /// Sort by analysis creation date in descending order
        /// </summary>
        [EnumMember(Value = "createdAt:DESC")]
        CREATED_AT_DESC,

        /// <summary>
        /// Sort by analysis creation date in ascending order
        /// </summary>
        [EnumMember(Value = "createdAt:ASC")]
        CREATED_AT_ASC
    }
}
