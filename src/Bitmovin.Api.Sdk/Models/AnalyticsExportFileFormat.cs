using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Analytics Export File Format
    /// </summary>
    public enum AnalyticsExportFileFormat
    {
        /// <summary>
        /// Export file will be in CSV format
        /// </summary>
        [EnumMember(Value = "CSV")]
        CSV,

        /// <summary>
        /// Export file will be in PARQUET format
        /// </summary>
        [EnumMember(Value = "PARQUET")]
        PARQUET
    }
}
