using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdvisoryCategory
    /// </summary>
    public enum AdvisoryCategory
    {
        /// <summary>
        /// Tobacco imagery such as smoking, cigarettes, cigars, pipes, or tobacco products
        /// </summary>
        [EnumMember(Value = "TOBACCO")]
        TOBACCO,

        /// <summary>
        /// Vaping imagery such as e-cigarettes, vape pens, or their use
        /// </summary>
        [EnumMember(Value = "VAPE")]
        VAPE
    }
}
