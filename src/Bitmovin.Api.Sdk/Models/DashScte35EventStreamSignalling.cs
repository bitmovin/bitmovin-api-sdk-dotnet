using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Defines how SCTE-35 events are delivered using DASH EventStream. &lt;ul&gt;   &lt;li&gt;XML: Events will contain an XML representation of a SCTE-35 cue message as a SpliceInfoSection element as defined in SCTE-35. The schemeIdUri will be \&quot;urn:scte:scte35:2013:xml.&lt;/li&gt;   &lt;li&gt;XML_BIN: Events will contain an XML representation of a SCTE-35 cue message as a Signal.Binary element as defined in SCTE-35. The schemeIdUri will be \&quot;urn:scte:scte35:2014:xml+bin&lt;/li&gt; &lt;/ul&gt; 
    /// </summary>
    public enum DashScte35EventStreamSignalling
    {
        /// <summary>
        /// Defines how SCTE-35 events are delivered using DASH EventStream. &lt;ul&gt;   &lt;li&gt;XML: Events will contain an XML representation of a SCTE-35 cue message as a SpliceInfoSection element as defined in SCTE-35. The schemeIdUri will be \&quot;urn:scte:scte35:2013:xml.&lt;/li&gt;   &lt;li&gt;XML_BIN: Events will contain an XML representation of a SCTE-35 cue message as a Signal.Binary element as defined in SCTE-35. The schemeIdUri will be \&quot;urn:scte:scte35:2014:xml+bin&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        [EnumMember(Value = "XML")]
        XML,

        /// <summary>
        /// Defines how SCTE-35 events are delivered using DASH EventStream. &lt;ul&gt;   &lt;li&gt;XML: Events will contain an XML representation of a SCTE-35 cue message as a SpliceInfoSection element as defined in SCTE-35. The schemeIdUri will be \&quot;urn:scte:scte35:2013:xml.&lt;/li&gt;   &lt;li&gt;XML_BIN: Events will contain an XML representation of a SCTE-35 cue message as a Signal.Binary element as defined in SCTE-35. The schemeIdUri will be \&quot;urn:scte:scte35:2014:xml+bin&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        [EnumMember(Value = "XML_BIN")]
        XML_BIN
    }
}
