using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AzureCloudRegion
    /// </summary>
    public enum AzureCloudRegion
    {
        /// <summary>
        /// California
        /// </summary>
        [EnumMember(Value = "US_WEST")]
        US_WEST,

        /// <summary>
        /// Washington
        /// </summary>
        [EnumMember(Value = "US_WEST2")]
        US_WEST2,

        /// <summary>
        /// Iowa
        /// </summary>
        [EnumMember(Value = "US_CENTRAL")]
        US_CENTRAL,

        /// <summary>
        /// Virginia
        /// </summary>
        [EnumMember(Value = "US_EAST")]
        US_EAST,

        /// <summary>
        /// Virginia
        /// </summary>
        [EnumMember(Value = "US_EAST2")]
        US_EAST2,

        /// <summary>
        /// Illinois
        /// </summary>
        [EnumMember(Value = "US_NORTH_CENTRAL")]
        US_NORTH_CENTRAL,

        /// <summary>
        /// Texas
        /// </summary>
        [EnumMember(Value = "US_SOUTH_CENTRAL")]
        US_SOUTH_CENTRAL,

        /// <summary>
        /// Wyoming
        /// </summary>
        [EnumMember(Value = "US_WEST_CENTRAL")]
        US_WEST_CENTRAL,

        /// <summary>
        /// Toronto
        /// </summary>
        [EnumMember(Value = "CANADA_CENTRAL")]
        CANADA_CENTRAL,

        /// <summary>
        /// Quebec City
        /// </summary>
        [EnumMember(Value = "CANADA_EAST")]
        CANADA_EAST,

        /// <summary>
        /// São Paulo State
        /// </summary>
        [EnumMember(Value = "BRAZIL_SOUTH")]
        BRAZIL_SOUTH,

        /// <summary>
        /// Rio de Janeiro - Reserved for Brazil South customers requiring scenario-based in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "BRAZIL_SOUTHEAST")]
        BRAZIL_SOUTHEAST,

        /// <summary>
        /// Ireland
        /// </summary>
        [EnumMember(Value = "EUROPE_NORTH")]
        EUROPE_NORTH,

        /// <summary>
        /// Netherlands
        /// </summary>
        [EnumMember(Value = "EUROPE_WEST")]
        EUROPE_WEST,

        /// <summary>
        /// London
        /// </summary>
        [EnumMember(Value = "UK_SOUTH")]
        UK_SOUTH,

        /// <summary>
        /// Cardiff
        /// </summary>
        [EnumMember(Value = "UK_WEST")]
        UK_WEST,

        /// <summary>
        /// Paris
        /// </summary>
        [EnumMember(Value = "FRANCE_CENTRAL")]
        FRANCE_CENTRAL,

        /// <summary>
        /// Marseille - Reserved for France Central customers requiring in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "FRANCE_SOUTH")]
        FRANCE_SOUTH,

        /// <summary>
        /// Zürich
        /// </summary>
        [EnumMember(Value = "SWITZERLAND_NORTH")]
        SWITZERLAND_NORTH,

        /// <summary>
        /// Geneva - Reserved for Switzerland North customers requiring in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "SWITZERLAND_WEST")]
        SWITZERLAND_WEST,

        /// <summary>
        /// Berlin - Reserved for Germany West Central customers requiring in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "GERMANY_NORTH")]
        GERMANY_NORTH,

        /// <summary>
        /// Frankfurt
        /// </summary>
        [EnumMember(Value = "GERMANY_WESTCENTRAL")]
        GERMANY_WESTCENTRAL,

        /// <summary>
        /// Stavanger - Reserved for Norway East customers requiring in-country diaster recovery
        /// </summary>
        [EnumMember(Value = "NORWAY_WEST")]
        NORWAY_WEST,

        /// <summary>
        /// Oslo
        /// </summary>
        [EnumMember(Value = "NORWAY_EAST")]
        NORWAY_EAST,

        /// <summary>
        /// Hong Kong
        /// </summary>
        [EnumMember(Value = "ASIA_EAST")]
        ASIA_EAST,

        /// <summary>
        /// Singapore
        /// </summary>
        [EnumMember(Value = "ASIA_SOUTHEAST")]
        ASIA_SOUTHEAST,

        /// <summary>
        /// Tokyo, Saitama
        /// </summary>
        [EnumMember(Value = "JAPAN_EAST")]
        JAPAN_EAST,

        /// <summary>
        /// Osaka
        /// </summary>
        [EnumMember(Value = "JAPAN_WEST")]
        JAPAN_WEST,

        /// <summary>
        /// New South Wales
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_EAST")]
        AUSTRALIA_EAST,

        /// <summary>
        /// Victoria
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_SOUTHEAST")]
        AUSTRALIA_SOUTHEAST,

        /// <summary>
        /// Canberra
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_CENTRAL")]
        AUSTRALIA_CENTRAL,

        /// <summary>
        /// Canberra - Reserved for Australia Central customers requiring in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_CENTRAL2")]
        AUSTRALIA_CENTRAL2,

        /// <summary>
        /// Pune
        /// </summary>
        [EnumMember(Value = "INDIA_CENTRAL")]
        INDIA_CENTRAL,

        /// <summary>
        /// Chennai
        /// </summary>
        [EnumMember(Value = "INDIA_SOUTH")]
        INDIA_SOUTH,

        /// <summary>
        /// Mumbai
        /// </summary>
        [EnumMember(Value = "INDIA_WEST")]
        INDIA_WEST,

        /// <summary>
        /// Seoul
        /// </summary>
        [EnumMember(Value = "KOREA_CENTRAL")]
        KOREA_CENTRAL,

        /// <summary>
        /// Busan
        /// </summary>
        [EnumMember(Value = "KOREA_SOUTH")]
        KOREA_SOUTH,

        /// <summary>
        /// Abu Dhabi - Reserved for UAE North customers requiring in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "UAE_CENTRAL")]
        UAE_CENTRAL,

        /// <summary>
        /// Dubai
        /// </summary>
        [EnumMember(Value = "UAE_NORTH")]
        UAE_NORTH,

        /// <summary>
        /// Johannesburg
        /// </summary>
        [EnumMember(Value = "SOUTHAFRICA_NORTH")]
        SOUTHAFRICA_NORTH,

        /// <summary>
        /// Cape Town - Reserved for South Africa North customers requiring in-country disaster recovery
        /// </summary>
        [EnumMember(Value = "SOUTHAFRICA_WEST")]
        SOUTHAFRICA_WEST,

        /// <summary>
        /// Beijing
        /// </summary>
        [EnumMember(Value = "CHINA_NORTH")]
        CHINA_NORTH,

        /// <summary>
        /// Shanghai
        /// </summary>
        [EnumMember(Value = "CHINA_EAST")]
        CHINA_EAST,

        /// <summary>
        /// Beijing
        /// </summary>
        [EnumMember(Value = "CHINA_NORTH2")]
        CHINA_NORTH2,

        /// <summary>
        /// Shanghai
        /// </summary>
        [EnumMember(Value = "CHINA_EAST2")]
        CHINA_EAST2,

        /// <summary>
        /// Frankfurt - No longer listed by https://azure.microsoft.com/en-us/global-infrastructure/data-residency
        /// </summary>
        [EnumMember(Value = "GERMANY_CENTRAL")]
        GERMANY_CENTRAL,

        /// <summary>
        /// Magdeburg - No longer listed by https://azure.microsoft.com/en-us/global-infrastructure/data-residency
        /// </summary>
        [EnumMember(Value = "GERMANY_NORTHEAST")]
        GERMANY_NORTHEAST,

        /// <summary>
        /// US Government Virginia - Reserved for US government entities and their partners only
        /// </summary>
        [EnumMember(Value = "GOV_US_VIRGINIA")]
        GOV_US_VIRGINIA,

        /// <summary>
        /// US Government Iowa - Reserved for US government entities and their partners only
        /// </summary>
        [EnumMember(Value = "GOV_US_IOWA")]
        GOV_US_IOWA,

        /// <summary>
        /// US Government Arizona - Reserved for US government entities and their partners only
        /// </summary>
        [EnumMember(Value = "GOV_US_ARIZONA")]
        GOV_US_ARIZONA,

        /// <summary>
        /// US Government Texas - Reserved for US government entities and their partners only
        /// </summary>
        [EnumMember(Value = "GOV_US_TEXAS")]
        GOV_US_TEXAS,

        /// <summary>
        /// Virginia - Reserved for exclusive use by the Department of Defense
        /// </summary>
        [EnumMember(Value = "GOV_US_DOD_EAST")]
        GOV_US_DOD_EAST,

        /// <summary>
        /// Iowa - Reserved for exclusive use by the Department of Defense
        /// </summary>
        [EnumMember(Value = "GOV_US_DOD_CENTRAL")]
        GOV_US_DOD_CENTRAL
    }
}
