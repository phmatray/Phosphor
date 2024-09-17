using Microsoft.AspNetCore.Components;
using Phosphor.Components;
using static MudBlazor.Phosphor.IconWeight;

namespace MudBlazor.Phosphor;

public class SuperSmileyIcon : SuperIcon
{
    [Parameter]
    public SmileyFace Face { get; set; } = SmileyFace.Normal;
    
    public override string GetIcon()
    {
        return (Weight, Face) switch
        {
            // Regular
            (Regular, SmileyFace.Normal) => global::Phosphor.Components.Icons.Phosphor.Regular.Smiley,
            (Regular, SmileyFace.Angry) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyAngry,
            (Regular, SmileyFace.Blank) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyBlank,
            (Regular, SmileyFace.Meh) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyMeh,
            (Regular, SmileyFace.Melting) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyMelting,
            (Regular, SmileyFace.Nervous) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyNervous,
            (Regular, SmileyFace.Sad) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileySad,
            (Regular, SmileyFace.Sticker) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileySticker,
            (Regular, SmileyFace.Wink) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyWink,
            (Regular, SmileyFace.XEyes) => global::Phosphor.Components.Icons.Phosphor.Regular.SmileyXEyes,
            // Thin
            (Thin, SmileyFace.Normal) => global::Phosphor.Components.Icons.Phosphor.Thin.Smiley,
            (Thin, SmileyFace.Angry) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyAngry,
            (Thin, SmileyFace.Blank) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyBlank,
            (Thin, SmileyFace.Meh) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyMeh,
            (Thin, SmileyFace.Melting) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyMelting,
            (Thin, SmileyFace.Nervous) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyNervous,
            (Thin, SmileyFace.Sad) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileySad,
            (Thin, SmileyFace.Sticker) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileySticker,
            (Thin, SmileyFace.Wink) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyWink,
            (Thin, SmileyFace.XEyes) => global::Phosphor.Components.Icons.Phosphor.Thin.SmileyXEyes,
            // Light
            (Light, SmileyFace.Normal) => global::Phosphor.Components.Icons.Phosphor.Light.Smiley,
            (Light, SmileyFace.Angry) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyAngry,
            (Light, SmileyFace.Blank) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyBlank,
            (Light, SmileyFace.Meh) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyMeh,
            (Light, SmileyFace.Melting) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyMelting,
            (Light, SmileyFace.Nervous) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyNervous,
            (Light, SmileyFace.Sad) => global::Phosphor.Components.Icons.Phosphor.Light.SmileySad,
            (Light, SmileyFace.Sticker) => global::Phosphor.Components.Icons.Phosphor.Light.SmileySticker,
            (Light, SmileyFace.Wink) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyWink,
            (Light, SmileyFace.XEyes) => global::Phosphor.Components.Icons.Phosphor.Light.SmileyXEyes,
            // Bold
            (Bold, SmileyFace.Normal) => global::Phosphor.Components.Icons.Phosphor.Bold.Smiley,
            (Bold, SmileyFace.Angry) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyAngry,
            (Bold, SmileyFace.Blank) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyBlank,
            (Bold, SmileyFace.Meh) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyMeh,
            (Bold, SmileyFace.Melting) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyMelting,
            (Bold, SmileyFace.Nervous) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyNervous,
            (Bold, SmileyFace.Sad) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileySad,
            (Bold, SmileyFace.Sticker) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileySticker,
            (Bold, SmileyFace.Wink) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyWink,
            (Bold, SmileyFace.XEyes) => global::Phosphor.Components.Icons.Phosphor.Bold.SmileyXEyes,
            // Fill
            (Fill, SmileyFace.Normal) => global::Phosphor.Components.Icons.Phosphor.Fill.Smiley,
            (Fill, SmileyFace.Angry) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyAngry,
            (Fill, SmileyFace.Blank) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyBlank,
            (Fill, SmileyFace.Meh) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyMeh,
            (Fill, SmileyFace.Melting) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyMelting,
            (Fill, SmileyFace.Nervous) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyNervous,
            (Fill, SmileyFace.Sad) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileySad,
            (Fill, SmileyFace.Sticker) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileySticker,
            (Fill, SmileyFace.Wink) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyWink,
            (Fill, SmileyFace.XEyes) => global::Phosphor.Components.Icons.Phosphor.Fill.SmileyXEyes,
            // Duotone
            (Duotone, SmileyFace.Normal) => global::Phosphor.Components.Icons.Phosphor.Duotone.Smiley,
            (Duotone, SmileyFace.Angry) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyAngry,
            (Duotone, SmileyFace.Blank) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyBlank,
            (Duotone, SmileyFace.Meh) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyMeh,
            (Duotone, SmileyFace.Melting) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyMelting,
            (Duotone, SmileyFace.Nervous) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyNervous,
            (Duotone, SmileyFace.Sad) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileySad,
            (Duotone, SmileyFace.Sticker) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileySticker,
            (Duotone, SmileyFace.Wink) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyWink,
            (Duotone, SmileyFace.XEyes) => global::Phosphor.Components.Icons.Phosphor.Duotone.SmileyXEyes,
            _ => global::Phosphor.Components.Icons.Phosphor.Regular.Smiley, 
        };
    }
}

public enum SmileyFace
{
    Normal,
    Angry,
    Blank,
    Meh,
    Melting,
    Nervous,
    Sad,
    Sticker,
    Wink,
    XEyes,
}