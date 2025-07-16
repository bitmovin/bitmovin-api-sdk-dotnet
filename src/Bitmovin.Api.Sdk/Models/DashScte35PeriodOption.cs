using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Controls how SCTE-35 signals are applied at the DASH period level. &lt;ul&gt;   &lt;li&gt;SINGLE_PERIOD: Applies SCTE markers to a single DASH period.&lt;/li&gt;   &lt;li&gt;MULTI_PERIOD: Multiple periods are created based on received SCTE-35 messages.&lt;/li&gt; &lt;/ul&gt; 
    /// </summary>
    public enum DashScte35PeriodOption
    {
        /// <summary>
        /// Controls how SCTE-35 signals are applied at the DASH period level. &lt;ul&gt;   &lt;li&gt;SINGLE_PERIOD: Applies SCTE markers to a single DASH period.&lt;/li&gt;   &lt;li&gt;MULTI_PERIOD: Multiple periods are created based on received SCTE-35 messages.&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        [EnumMember(Value = "SINGLE_PERIOD")]
        SINGLE_PERIOD,

        /// <summary>
        /// Controls how SCTE-35 signals are applied at the DASH period level. &lt;ul&gt;   &lt;li&gt;SINGLE_PERIOD: Applies SCTE markers to a single DASH period.&lt;/li&gt;   &lt;li&gt;MULTI_PERIOD: Multiple periods are created based on received SCTE-35 messages.&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        [EnumMember(Value = "MULTI_PERIOD")]
        MULTI_PERIOD
    }
}
