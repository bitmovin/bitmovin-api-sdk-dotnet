using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Department
    /// </summary>
    public enum Department
    {
        /// <summary>
        /// Cast members and their portrayed characters
        /// </summary>
        [EnumMember(Value = "ACTING")]
        ACTING,

        /// <summary>
        /// Chief Animation Director, Animation Director, Character Designer, Color Design
        /// </summary>
        [EnumMember(Value = "ANIMATION")]
        ANIMATION,

        /// <summary>
        /// Casting Director
        /// </summary>
        [EnumMember(Value = "CASTING")]
        CASTING,

        /// <summary>
        /// Director of Photography
        /// </summary>
        [EnumMember(Value = "CINEMATOGRAPHY")]
        CINEMATOGRAPHY,

        /// <summary>
        /// Costume Designer
        /// </summary>
        [EnumMember(Value = "COSTUME_DESIGN")]
        COSTUME_DESIGN,

        /// <summary>
        /// Director
        /// </summary>
        [EnumMember(Value = "DIRECTING")]
        DIRECTING,

        /// <summary>
        /// Film Editor
        /// </summary>
        [EnumMember(Value = "FILM_EDITING")]
        FILM_EDITING,

        /// <summary>
        /// Department head Makeup Artist and Hair Stylist
        /// </summary>
        [EnumMember(Value = "MAKEUP_AND_HAIRSTYLING")]
        MAKEUP_AND_HAIRSTYLING,

        /// <summary>
        /// Film score Composer
        /// </summary>
        [EnumMember(Value = "MUSIC")]
        MUSIC,

        /// <summary>
        /// Producers and Executive Producers
        /// </summary>
        [EnumMember(Value = "PRODUCTION")]
        PRODUCTION,

        /// <summary>
        /// Production Designer
        /// </summary>
        [EnumMember(Value = "PRODUCTION_DESIGN")]
        PRODUCTION_DESIGN,

        /// <summary>
        /// Primary Sound Designer or Sound Mixer
        /// </summary>
        [EnumMember(Value = "SOUND")]
        SOUND,

        /// <summary>
        /// Visual Effects Supervisor
        /// </summary>
        [EnumMember(Value = "VISUAL_EFFECTS")]
        VISUAL_EFFECTS,

        /// <summary>
        /// Screenplay, Created By, or Story By credits
        /// </summary>
        [EnumMember(Value = "WRITING")]
        WRITING,

        /// <summary>
        /// Fallback when department cannot be determined
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
