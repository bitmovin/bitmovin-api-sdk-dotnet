using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SceneType
    /// </summary>
    public enum SceneType
    {
        /// <summary>
        /// Network, studio, or platform identification bumpers
        /// </summary>
        [EnumMember(Value = "LOGO_IDENT")]
        LOGO_IDENT,

        /// <summary>
        /// Opening sequence presenting title, credits, or thematic elements without in-world dialogue
        /// </summary>
        [EnumMember(Value = "OPENING_CREDITS")]
        OPENING_CREDITS,

        /// <summary>
        /// &quot;Previously on …&quot; montage sequences from prior episodes
        /// </summary>
        [EnumMember(Value = "RECAP")]
        RECAP,

        /// <summary>
        /// Teaser or preview for this title or its upcoming episode
        /// </summary>
        [EnumMember(Value = "PREVIEW_THIS_TITLE")]
        PREVIEW_THIS_TITLE,

        /// <summary>
        /// Promotion or trailer for a different title or programming
        /// </summary>
        [EnumMember(Value = "PROMOTION_OTHER_TITLE")]
        PROMOTION_OTHER_TITLE,

        /// <summary>
        /// Short bumper marking an act or advertising break
        /// </summary>
        [EnumMember(Value = "BREAK_BUMPER")]
        BREAK_BUMPER,

        /// <summary>
        /// Closing credits, acknowledgments, or copyright notices
        /// </summary>
        [EnumMember(Value = "END_CREDITS")]
        END_CREDITS,

        /// <summary>
        /// Commercial advertisements with promotional intent and call-to-action
        /// </summary>
        [EnumMember(Value = "ADS")]
        ADS,

        /// <summary>
        /// Main narrative, dialogue, or educational material
        /// </summary>
        [EnumMember(Value = "MAIN_CONTENT")]
        MAIN_CONTENT,

        /// <summary>
        /// Fallback when AI confidence is below minimum threshold
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
