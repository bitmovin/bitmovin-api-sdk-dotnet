using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SceneType
    /// </summary>
    public enum SceneType
    {
        /// <summary>
        /// Opening sequence presenting title, credits, and/or thematic elements; no in-world character dialogue
        /// </summary>
        [EnumMember(Value = "OPENING_TITLES")]
        OPENING_TITLES,

        /// <summary>
        /// Episode-specific title/chapter card (e.g., &quot;S02E04 — The Pact&quot;)
        /// </summary>
        [EnumMember(Value = "EPISODE_TITLE_CARD")]
        EPISODE_TITLE_CARD,

        /// <summary>
        /// Production/distributor logo stingers (e.g., MGM, WB, New Line)
        /// </summary>
        [EnumMember(Value = "STUDIO_LOGO_BUMPER")]
        STUDIO_LOGO_BUMPER,

        /// <summary>
        /// Network/platform idents/slates (e.g., &quot;A Netflix Original&quot;, channel idents)
        /// </summary>
        [EnumMember(Value = "NETWORK_OR_PLATFORM_IDENT")]
        NETWORK_OR_PLATFORM_IDENT,

        /// <summary>
        /// &quot;Previously on …&quot; montage sequences from previous episodes
        /// </summary>
        [EnumMember(Value = "RECAP")]
        RECAP,

        /// <summary>
        /// Teaser for this or the next episode of the same title
        /// </summary>
        [EnumMember(Value = "PREVIEW_THIS_TITLE")]
        PREVIEW_THIS_TITLE,

        /// <summary>
        /// Network promo for a different show on the same network/platform (schedule-centric)
        /// </summary>
        [EnumMember(Value = "PROMO_OTHER_TITLE")]
        PROMO_OTHER_TITLE,

        /// <summary>
        /// Full/standard trailer for a different title (cinematic style, not schedule-centric)
        /// </summary>
        [EnumMember(Value = "TRAILER_OTHER_TITLE")]
        TRAILER_OTHER_TITLE,

        /// <summary>
        /// Commercial advertisements with promotional intent and call-to-action
        /// </summary>
        [EnumMember(Value = "ADS")]
        ADS,

        /// <summary>
        /// Short bumpers marking act/ad breaks (incl. anime eyecatches)
        /// </summary>
        [EnumMember(Value = "ACT_BREAK_EYECATCH")]
        ACT_BREAK_EYECATCH,

        /// <summary>
        /// Technical/packaging: test bars, countdowns, black/slates, legal-only cards
        /// </summary>
        [EnumMember(Value = "TECHNICAL_SLATE_OR_TEST")]
        TECHNICAL_SLATE_OR_TEST,

        /// <summary>
        /// Main narrative, dialogue, or educational material (default)
        /// </summary>
        [EnumMember(Value = "MAIN_CONTENT")]
        MAIN_CONTENT,

        /// <summary>
        /// Narrative content interspersed within end credits
        /// </summary>
        [EnumMember(Value = "MID_CREDIT_SCENE")]
        MID_CREDIT_SCENE,

        /// <summary>
        /// Narrative content appearing after all credits finish
        /// </summary>
        [EnumMember(Value = "POST_CREDIT_SCENE")]
        POST_CREDIT_SCENE,

        /// <summary>
        /// Closing credits, copyright notices, staff acknowledgments
        /// </summary>
        [EnumMember(Value = "END_CREDITS")]
        END_CREDITS,

        /// <summary>
        /// Fallback when AI confidence below minimum threshold
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
