using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// CloudRegion
    /// </summary>
    public enum CloudRegion
    {
        /// <summary>
        /// AWS US East (N. Virginia)
        /// </summary>
        [EnumMember(Value = "AWS_US_EAST_1")]
        AWS_US_EAST_1,

        /// <summary>
        /// AWS US East (Ohio)
        /// </summary>
        [EnumMember(Value = "AWS_US_EAST_2")]
        AWS_US_EAST_2,

        /// <summary>
        /// AWS US West (N. California)
        /// </summary>
        [EnumMember(Value = "AWS_US_WEST_1")]
        AWS_US_WEST_1,

        /// <summary>
        /// AWS US West (Oregon)
        /// </summary>
        [EnumMember(Value = "AWS_US_WEST_2")]
        AWS_US_WEST_2,

        /// <summary>
        /// AWS Europe (Ireland)
        /// </summary>
        [EnumMember(Value = "AWS_EU_WEST_1")]
        AWS_EU_WEST_1,

        /// <summary>
        /// AWS Europe (Frankfurt)
        /// </summary>
        [EnumMember(Value = "AWS_EU_CENTRAL_1")]
        AWS_EU_CENTRAL_1,

        /// <summary>
        /// AWS Asia Pacific (Singapore)
        /// </summary>
        [EnumMember(Value = "AWS_AP_SOUTHEAST_1")]
        AWS_AP_SOUTHEAST_1,

        /// <summary>
        /// AWS Asia Pacific (Sydney)
        /// </summary>
        [EnumMember(Value = "AWS_AP_SOUTHEAST_2")]
        AWS_AP_SOUTHEAST_2,

        /// <summary>
        /// AWS Asia Pacific (Tokyo)
        /// </summary>
        [EnumMember(Value = "AWS_AP_NORTHEAST_1")]
        AWS_AP_NORTHEAST_1,

        /// <summary>
        /// AWS Asia Pacific (Seoul)
        /// </summary>
        [EnumMember(Value = "AWS_AP_NORTHEAST_2")]
        AWS_AP_NORTHEAST_2,

        /// <summary>
        /// AWS Asia Pacific (Mumbai)
        /// </summary>
        [EnumMember(Value = "AWS_AP_SOUTH_1")]
        AWS_AP_SOUTH_1,

        /// <summary>
        /// AWS South America (São Paulo)
        /// </summary>
        [EnumMember(Value = "AWS_SA_EAST_1")]
        AWS_SA_EAST_1,

        /// <summary>
        /// AWS Europe (London)
        /// </summary>
        [EnumMember(Value = "AWS_EU_WEST_2")]
        AWS_EU_WEST_2,

        /// <summary>
        /// AWS Europe (Paris)
        /// </summary>
        [EnumMember(Value = "AWS_EU_WEST_3")]
        AWS_EU_WEST_3,

        /// <summary>
        /// AWS Canada (Central)
        /// </summary>
        [EnumMember(Value = "AWS_CA_CENTRAL_1")]
        AWS_CA_CENTRAL_1,

        /// <summary>
        /// AWS Europe (Stockholm)
        /// </summary>
        [EnumMember(Value = "AWS_EU_NORTH_1")]
        AWS_EU_NORTH_1,

        /// <summary>
        /// Google Council Bluffs, Iowa, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_CENTRAL_1")]
        GOOGLE_US_CENTRAL_1,

        /// <summary>
        /// Google Moncks Corner, South Carolina, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_EAST_1")]
        GOOGLE_US_EAST_1,

        /// <summary>
        /// Google Changhua County, Taiwan
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_EAST_1")]
        GOOGLE_ASIA_EAST_1,

        /// <summary>
        /// Google St. Ghislain, Belgium
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_1")]
        GOOGLE_EUROPE_WEST_1,

        /// <summary>
        /// Google The Dalles, Oregon, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_WEST_1")]
        GOOGLE_US_WEST_1,

        /// <summary>
        /// Google Hong Kong
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_EAST_2")]
        GOOGLE_ASIA_EAST_2,

        /// <summary>
        /// Google Tokyo, Japan
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_NORTHEAST_1")]
        GOOGLE_ASIA_NORTHEAST_1,

        /// <summary>
        /// Google Mumbai, India
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_SOUTH_1")]
        GOOGLE_ASIA_SOUTH_1,

        /// <summary>
        /// Google Jurong West, Singapore
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_SOUTHEAST_1")]
        GOOGLE_ASIA_SOUTHEAST_1,

        /// <summary>
        /// Google Sydney, Australia
        /// </summary>
        [EnumMember(Value = "GOOGLE_AUSTRALIA_SOUTHEAST_1")]
        GOOGLE_AUSTRALIA_SOUTHEAST_1,

        /// <summary>
        /// Google Hamina, Finland
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_NORTH_1")]
        GOOGLE_EUROPE_NORTH_1,

        /// <summary>
        /// Google London, England, UK
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_2")]
        GOOGLE_EUROPE_WEST_2,

        /// <summary>
        /// Google Frankfurt, Germany
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_3")]
        GOOGLE_EUROPE_WEST_3,

        /// <summary>
        /// Google Eemshaven, Netherlands
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_4")]
        GOOGLE_EUROPE_WEST_4,

        /// <summary>
        /// Google Montréal, Québec, Canada
        /// </summary>
        [EnumMember(Value = "GOOGLE_NORTHAMERICA_NORTHEAST_1")]
        GOOGLE_NORTHAMERICA_NORTHEAST_1,

        /// <summary>
        /// Google São Paulo, Brazil
        /// </summary>
        [EnumMember(Value = "GOOGLE_SOUTHAMERICA_EAST_1")]
        GOOGLE_SOUTHAMERICA_EAST_1,

        /// <summary>
        /// Google Ashburn, Northern Virginia, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_EAST_4")]
        GOOGLE_US_EAST_4,

        /// <summary>
        /// Google Los Angeles, California, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_WEST_2")]
        GOOGLE_US_WEST_2,

        /// <summary>
        /// Azure East Asia, Hong Kong
        /// </summary>
        [EnumMember(Value = "AZURE_ASIA_EAST")]
        AZURE_ASIA_EAST,

        /// <summary>
        /// Azure Southeast Asia, Singapore
        /// </summary>
        [EnumMember(Value = "AZURE_ASIA_SOUTHEAST")]
        AZURE_ASIA_SOUTHEAST,

        /// <summary>
        /// Azure Australia East, Canberra
        /// </summary>
        [EnumMember(Value = "AZURE_AUSTRALIA_EAST")]
        AZURE_AUSTRALIA_EAST,

        /// <summary>
        /// Azure Australia Southeast, Victoria
        /// </summary>
        [EnumMember(Value = "AZURE_AUSTRALIA_SOUTHEAST")]
        AZURE_AUSTRALIA_SOUTHEAST,

        /// <summary>
        /// Azure Brazil South, São Paulo
        /// </summary>
        [EnumMember(Value = "AZURE_BRAZIL_SOUTH")]
        AZURE_BRAZIL_SOUTH,

        /// <summary>
        /// Azure Canada Central, Toronto
        /// </summary>
        [EnumMember(Value = "AZURE_CANADA_CENTRAL")]
        AZURE_CANADA_CENTRAL,

        /// <summary>
        /// Azure North Europe, Ireland
        /// </summary>
        [EnumMember(Value = "AZURE_EUROPE_NORTH")]
        AZURE_EUROPE_NORTH,

        /// <summary>
        /// Azure West Europe, Netherlands
        /// </summary>
        [EnumMember(Value = "AZURE_EUROPE_WEST")]
        AZURE_EUROPE_WEST,

        /// <summary>
        /// Azure France Central, Paris
        /// </summary>
        [EnumMember(Value = "AZURE_FRANCE_CENTRAL")]
        AZURE_FRANCE_CENTRAL,

        /// <summary>
        /// Azure Germany West Central, Frankfurt
        /// </summary>
        [EnumMember(Value = "AZURE_GERMANY_WESTCENTRAL")]
        AZURE_GERMANY_WESTCENTRAL,

        /// <summary>
        /// Azure Central India, Pune
        /// </summary>
        [EnumMember(Value = "AZURE_INDIA_CENTRAL")]
        AZURE_INDIA_CENTRAL,

        /// <summary>
        /// Azure South India, Chennai
        /// </summary>
        [EnumMember(Value = "AZURE_INDIA_SOUTH")]
        AZURE_INDIA_SOUTH,

        /// <summary>
        /// Azure Japan East, Tokyo, Saitama
        /// </summary>
        [EnumMember(Value = "AZURE_JAPAN_EAST")]
        AZURE_JAPAN_EAST,

        /// <summary>
        /// Azure Japan West, Osaka
        /// </summary>
        [EnumMember(Value = "AZURE_JAPAN_WEST")]
        AZURE_JAPAN_WEST,

        /// <summary>
        /// Azure Korea Central, Seoul
        /// </summary>
        [EnumMember(Value = "AZURE_KOREA_CENTRAL")]
        AZURE_KOREA_CENTRAL,

        /// <summary>
        /// Azure UAE North, Dubai, United Arab Emirates
        /// </summary>
        [EnumMember(Value = "AZURE_UAE_NORTH")]
        AZURE_UAE_NORTH,

        /// <summary>
        /// Azure Central US, Iowa, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_CENTRAL")]
        AZURE_US_CENTRAL,

        /// <summary>
        /// Azure East US, Virginia, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_EAST")]
        AZURE_US_EAST,

        /// <summary>
        /// Azure East US 2, Virginia, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_EAST2")]
        AZURE_US_EAST2,

        /// <summary>
        /// Azure West US, California, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_WEST")]
        AZURE_US_WEST,

        /// <summary>
        /// Azure West US 2, Washington, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_WEST2")]
        AZURE_US_WEST2,

        /// <summary>
        /// Azure South Central US, Texas, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_SOUTH_CENTRAL")]
        AZURE_US_SOUTH_CENTRAL,

        /// <summary>
        /// Azure North Central US, Illinois, USA
        /// </summary>
        [EnumMember(Value = "AZURE_US_NORTH_CENTRAL")]
        AZURE_US_NORTH_CENTRAL,

        /// <summary>
        /// Azure UK South, London, UK
        /// </summary>
        [EnumMember(Value = "AZURE_UK_SOUTH")]
        AZURE_UK_SOUTH,

        /// <summary>
        /// Akamai São Paulo, Brazil
        /// </summary>
        [EnumMember(Value = "AKAMAI_BR_GRU")]
        AKAMAI_BR_GRU,

        /// <summary>
        /// Akamai Paris, France
        /// </summary>
        [EnumMember(Value = "AKAMAI_FR_PAR")]
        AKAMAI_FR_PAR,

        /// <summary>
        /// Akamai Osaka, Japan
        /// </summary>
        [EnumMember(Value = "AKAMAI_JP_OSA")]
        AKAMAI_JP_OSA,

        /// <summary>
        /// Akamai Seattle, USA
        /// </summary>
        [EnumMember(Value = "AKAMAI_US_SEA")]
        AKAMAI_US_SEA,

        /// <summary>
        /// OCI Frankfurt, Germany.  The Oracle Cloud integration is in beta and still undergoing testing.  Some issues or limitations may be present.
        /// </summary>
        [EnumMember(Value = "OCI_EU_FRANKFURT_1")]
        OCI_EU_FRANKFURT_1,

        /// <summary>
        /// OCI Ashburn, VA, USA.  The Oracle Cloud integration is in beta and still undergoing testing. Some issues or limitations may be present.
        /// </summary>
        [EnumMember(Value = "OCI_US_ASHBURN_1")]
        OCI_US_ASHBURN_1,

        /// <summary>
        /// NORTH_AMERICA
        /// </summary>
        [EnumMember(Value = "NORTH_AMERICA")]
        NORTH_AMERICA,

        /// <summary>
        /// SOUTH_AMERICA
        /// </summary>
        [EnumMember(Value = "SOUTH_AMERICA")]
        SOUTH_AMERICA,

        /// <summary>
        /// EUROPE
        /// </summary>
        [EnumMember(Value = "EUROPE")]
        EUROPE,

        /// <summary>
        /// AFRICA
        /// </summary>
        [EnumMember(Value = "AFRICA")]
        AFRICA,

        /// <summary>
        /// ASIA
        /// </summary>
        [EnumMember(Value = "ASIA")]
        ASIA,

        /// <summary>
        /// AUSTRALIA
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUSTRALIA,

        /// <summary>
        /// AWS
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS,

        /// <summary>
        /// GOOGLE
        /// </summary>
        [EnumMember(Value = "GOOGLE")]
        GOOGLE,

        /// <summary>
        /// EXTERNAL
        /// </summary>
        [EnumMember(Value = "EXTERNAL")]
        EXTERNAL,

        /// <summary>
        /// AUTO
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO
    }
}
