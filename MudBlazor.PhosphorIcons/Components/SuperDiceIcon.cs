using static MudBlazor.Phosphor.DiceValue;

namespace MudBlazor.Phosphor;

public class SuperDiceIcon : SuperIcon
{
    [Parameter]
    public DiceValue Value { get; set; } = One;

    public override string GetIcon()
    {
        return (Weight, Value) switch
        {
            // Regular
            (Regular, One) => PhosphorRegular.DiceOne,
            (Regular, Two) => PhosphorRegular.DiceTwo,
            (Regular, Three) => PhosphorRegular.DiceThree,
            (Regular, Four) => PhosphorRegular.DiceFour,
            (Regular, Five) => PhosphorRegular.DiceFive,
            (Regular, Six) => PhosphorRegular.DiceSix,
            // Thin
            (Thin, One) => PhosphorThin.DiceOne,
            (Thin, Two) => PhosphorThin.DiceTwo,
            (Thin, Three) => PhosphorThin.DiceThree,
            (Thin, Four) => PhosphorThin.DiceFour,
            (Thin, Five) => PhosphorThin.DiceFive,
            (Thin, Six) => PhosphorThin.DiceSix,
            // Light
            (Light, One) => PhosphorLight.DiceOne,
            (Light, Two) => PhosphorLight.DiceTwo,
            (Light, Three) => PhosphorLight.DiceThree,
            (Light, Four) => PhosphorLight.DiceFour,
            (Light, Five) => PhosphorLight.DiceFive,
            (Light, Six) => PhosphorLight.DiceSix,
            // Bold
            (Bold, One) => PhosphorBold.DiceOne,
            (Bold, Two) => PhosphorBold.DiceTwo,
            (Bold, Three) => PhosphorBold.DiceThree,
            (Bold, Four) => PhosphorBold.DiceFour,
            (Bold, Five) => PhosphorBold.DiceFive,
            (Bold, Six) => PhosphorBold.DiceSix,
            // Fill
            (Fill, One) => PhosphorFill.DiceOne,
            (Fill, Two) => PhosphorFill.DiceTwo,
            (Fill, Three) => PhosphorFill.DiceThree,
            (Fill, Four) => PhosphorFill.DiceFour,
            (Fill, Five) => PhosphorFill.DiceFive,
            (Fill, Six) => PhosphorFill.DiceSix,
            // Duotone
            (Duotone, One) => PhosphorDuotone.DiceOne,
            (Duotone, Two) => PhosphorDuotone.DiceTwo,
            (Duotone, Three) => PhosphorDuotone.DiceThree,
            (Duotone, Four) => PhosphorDuotone.DiceFour,
            (Duotone, Five) => PhosphorDuotone.DiceFive,
            (Duotone, Six) => PhosphorDuotone.DiceSix,
        };
    }
}

public enum DiceValue
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six
}