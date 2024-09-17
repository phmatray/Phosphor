using static MudBlazor.Phosphor.SmileyFace;

namespace MudBlazor.Phosphor;

public class SuperSmileyIcon : SuperIcon
{
    [Parameter]
    public SmileyFace Face { get; set; } = Normal;
    
    public override string GetIcon()
    {
        return (Weight, Face) switch
        {
            // Regular
            (Regular, Normal) => PhosphorRegular.Smiley,
            (Regular, Angry) => PhosphorRegular.SmileyAngry,
            (Regular, Blank) => PhosphorRegular.SmileyBlank,
            (Regular, Meh) => PhosphorRegular.SmileyMeh,
            (Regular, Melting) => PhosphorRegular.SmileyMelting,
            (Regular, Nervous) => PhosphorRegular.SmileyNervous,
            (Regular, Sad) => PhosphorRegular.SmileySad,
            (Regular, Sticker) => PhosphorRegular.SmileySticker,
            (Regular, Wink) => PhosphorRegular.SmileyWink,
            (Regular, XEyes) => PhosphorRegular.SmileyXEyes,
            // Thin
            (Thin, Normal) => PhosphorThin.Smiley,
            (Thin, Angry) => PhosphorThin.SmileyAngry,
            (Thin, Blank) => PhosphorThin.SmileyBlank,
            (Thin, Meh) => PhosphorThin.SmileyMeh,
            (Thin, Melting) => PhosphorThin.SmileyMelting,
            (Thin, Nervous) => PhosphorThin.SmileyNervous,
            (Thin, Sad) => PhosphorThin.SmileySad,
            (Thin, Sticker) => PhosphorThin.SmileySticker,
            (Thin, Wink) => PhosphorThin.SmileyWink,
            (Thin, XEyes) => PhosphorThin.SmileyXEyes,
            // Light
            (Light, Normal) => PhosphorLight.Smiley,
            (Light, Angry) => PhosphorLight.SmileyAngry,
            (Light, Blank) => PhosphorLight.SmileyBlank,
            (Light, Meh) => PhosphorLight.SmileyMeh,
            (Light, Melting) => PhosphorLight.SmileyMelting,
            (Light, Nervous) => PhosphorLight.SmileyNervous,
            (Light, Sad) => PhosphorLight.SmileySad,
            (Light, Sticker) => PhosphorLight.SmileySticker,
            (Light, Wink) => PhosphorLight.SmileyWink,
            (Light, XEyes) => PhosphorLight.SmileyXEyes,
            // Bold
            (Bold, Normal) => PhosphorBold.Smiley,
            (Bold, Angry) => PhosphorBold.SmileyAngry,
            (Bold, Blank) => PhosphorBold.SmileyBlank,
            (Bold, Meh) => PhosphorBold.SmileyMeh,
            (Bold, Melting) => PhosphorBold.SmileyMelting,
            (Bold, Nervous) => PhosphorBold.SmileyNervous,
            (Bold, Sad) => PhosphorBold.SmileySad,
            (Bold, Sticker) => PhosphorBold.SmileySticker,
            (Bold, Wink) => PhosphorBold.SmileyWink,
            (Bold, XEyes) => PhosphorBold.SmileyXEyes,
            // Fill
            (Fill, Normal) => PhosphorFill.Smiley,
            (Fill, Angry) => PhosphorFill.SmileyAngry,
            (Fill, Blank) => PhosphorFill.SmileyBlank,
            (Fill, Meh) => PhosphorFill.SmileyMeh,
            (Fill, Melting) => PhosphorFill.SmileyMelting,
            (Fill, Nervous) => PhosphorFill.SmileyNervous,
            (Fill, Sad) => PhosphorFill.SmileySad,
            (Fill, Sticker) => PhosphorFill.SmileySticker,
            (Fill, Wink) => PhosphorFill.SmileyWink,
            (Fill, XEyes) => PhosphorFill.SmileyXEyes,
            // Duotone
            (Duotone, Normal) => PhosphorDuotone.Smiley,
            (Duotone, Angry) => PhosphorDuotone.SmileyAngry,
            (Duotone, Blank) => PhosphorDuotone.SmileyBlank,
            (Duotone, Meh) => PhosphorDuotone.SmileyMeh,
            (Duotone, Melting) => PhosphorDuotone.SmileyMelting,
            (Duotone, Nervous) => PhosphorDuotone.SmileyNervous,
            (Duotone, Sad) => PhosphorDuotone.SmileySad,
            (Duotone, Sticker) => PhosphorDuotone.SmileySticker,
            (Duotone, Wink) => PhosphorDuotone.SmileyWink,
            (Duotone, XEyes) => PhosphorDuotone.SmileyXEyes,
            _ => PhosphorRegular.Smiley, 
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