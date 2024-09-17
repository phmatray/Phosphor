using Microsoft.AspNetCore.Components;
using Phosphor.Components;
using static MudBlazor.Phosphor.DiceValue;
using static MudBlazor.Phosphor.IconWeight;

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
            (Regular, One) => global::Phosphor.Components.Icons.Phosphor.Regular.DiceOne,
            (Regular, Two) => global::Phosphor.Components.Icons.Phosphor.Regular.DiceTwo,
            (Regular, Three) => global::Phosphor.Components.Icons.Phosphor.Regular.DiceThree,
            (Regular, Four) => global::Phosphor.Components.Icons.Phosphor.Regular.DiceFour,
            (Regular, Five) => global::Phosphor.Components.Icons.Phosphor.Regular.DiceFive,
            (Regular, Six) => global::Phosphor.Components.Icons.Phosphor.Regular.DiceSix,
            // Thin
            (Thin, One) => global::Phosphor.Components.Icons.Phosphor.Thin.DiceOne,
            (Thin, Two) => global::Phosphor.Components.Icons.Phosphor.Thin.DiceTwo,
            (Thin, Three) => global::Phosphor.Components.Icons.Phosphor.Thin.DiceThree,
            (Thin, Four) => global::Phosphor.Components.Icons.Phosphor.Thin.DiceFour,
            (Thin, Five) => global::Phosphor.Components.Icons.Phosphor.Thin.DiceFive,
            (Thin, Six) => global::Phosphor.Components.Icons.Phosphor.Thin.DiceSix,
            // Light
            (Light, One) => global::Phosphor.Components.Icons.Phosphor.Light.DiceOne,
            (Light, Two) => global::Phosphor.Components.Icons.Phosphor.Light.DiceTwo,
            (Light, Three) => global::Phosphor.Components.Icons.Phosphor.Light.DiceThree,
            (Light, Four) => global::Phosphor.Components.Icons.Phosphor.Light.DiceFour,
            (Light, Five) => global::Phosphor.Components.Icons.Phosphor.Light.DiceFive,
            (Light, Six) => global::Phosphor.Components.Icons.Phosphor.Light.DiceSix,
            // Bold
            (Bold, One) => global::Phosphor.Components.Icons.Phosphor.Bold.DiceOne,
            (Bold, Two) => global::Phosphor.Components.Icons.Phosphor.Bold.DiceTwo,
            (Bold, Three) => global::Phosphor.Components.Icons.Phosphor.Bold.DiceThree,
            (Bold, Four) => global::Phosphor.Components.Icons.Phosphor.Bold.DiceFour,
            (Bold, Five) => global::Phosphor.Components.Icons.Phosphor.Bold.DiceFive,
            (Bold, Six) => global::Phosphor.Components.Icons.Phosphor.Bold.DiceSix,
            // Fill
            (Fill, One) => global::Phosphor.Components.Icons.Phosphor.Fill.DiceOne,
            (Fill, Two) => global::Phosphor.Components.Icons.Phosphor.Fill.DiceTwo,
            (Fill, Three) => global::Phosphor.Components.Icons.Phosphor.Fill.DiceThree,
            (Fill, Four) => global::Phosphor.Components.Icons.Phosphor.Fill.DiceFour,
            (Fill, Five) => global::Phosphor.Components.Icons.Phosphor.Fill.DiceFive,
            (Fill, Six) => global::Phosphor.Components.Icons.Phosphor.Fill.DiceSix,
            // Duotone
            (Duotone, One) => global::Phosphor.Components.Icons.Phosphor.Duotone.DiceOne,
            (Duotone, Two) => global::Phosphor.Components.Icons.Phosphor.Duotone.DiceTwo,
            (Duotone, Three) => global::Phosphor.Components.Icons.Phosphor.Duotone.DiceThree,
            (Duotone, Four) => global::Phosphor.Components.Icons.Phosphor.Duotone.DiceFour,
            (Duotone, Five) => global::Phosphor.Components.Icons.Phosphor.Duotone.DiceFive,
            (Duotone, Six) => global::Phosphor.Components.Icons.Phosphor.Duotone.DiceSix,
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