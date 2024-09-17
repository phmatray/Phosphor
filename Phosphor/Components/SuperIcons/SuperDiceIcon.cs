using Microsoft.AspNetCore.Components;
using static Phosphor.Components.SuperIcons.DiceValue;
using static Phosphor.Models.IconWeight;

namespace Phosphor.Components.SuperIcons;

public class SuperDiceIcon : SuperIcon
{
    [Parameter]
    public DiceValue Value { get; set; } = One;

    public override string GetIcon()
    {
        return (Weight, Value) switch
        {
            // Regular
            (Regular, One) => Icons.Phosphor.Regular.DiceOne,
            (Regular, Two) => Icons.Phosphor.Regular.DiceTwo,
            (Regular, Three) => Icons.Phosphor.Regular.DiceThree,
            (Regular, Four) => Icons.Phosphor.Regular.DiceFour,
            (Regular, Five) => Icons.Phosphor.Regular.DiceFive,
            (Regular, Six) => Icons.Phosphor.Regular.DiceSix,
            // Thin
            (Thin, One) => Icons.Phosphor.Thin.DiceOne,
            (Thin, Two) => Icons.Phosphor.Thin.DiceTwo,
            (Thin, Three) => Icons.Phosphor.Thin.DiceThree,
            (Thin, Four) => Icons.Phosphor.Thin.DiceFour,
            (Thin, Five) => Icons.Phosphor.Thin.DiceFive,
            (Thin, Six) => Icons.Phosphor.Thin.DiceSix,
            // Light
            (Light, One) => Icons.Phosphor.Light.DiceOne,
            (Light, Two) => Icons.Phosphor.Light.DiceTwo,
            (Light, Three) => Icons.Phosphor.Light.DiceThree,
            (Light, Four) => Icons.Phosphor.Light.DiceFour,
            (Light, Five) => Icons.Phosphor.Light.DiceFive,
            (Light, Six) => Icons.Phosphor.Light.DiceSix,
            // Bold
            (Bold, One) => Icons.Phosphor.Bold.DiceOne,
            (Bold, Two) => Icons.Phosphor.Bold.DiceTwo,
            (Bold, Three) => Icons.Phosphor.Bold.DiceThree,
            (Bold, Four) => Icons.Phosphor.Bold.DiceFour,
            (Bold, Five) => Icons.Phosphor.Bold.DiceFive,
            (Bold, Six) => Icons.Phosphor.Bold.DiceSix,
            // Fill
            (Fill, One) => Icons.Phosphor.Fill.DiceOne,
            (Fill, Two) => Icons.Phosphor.Fill.DiceTwo,
            (Fill, Three) => Icons.Phosphor.Fill.DiceThree,
            (Fill, Four) => Icons.Phosphor.Fill.DiceFour,
            (Fill, Five) => Icons.Phosphor.Fill.DiceFive,
            (Fill, Six) => Icons.Phosphor.Fill.DiceSix,
            // Duotone
            (Duotone, One) => Icons.Phosphor.Duotone.DiceOne,
            (Duotone, Two) => Icons.Phosphor.Duotone.DiceTwo,
            (Duotone, Three) => Icons.Phosphor.Duotone.DiceThree,
            (Duotone, Four) => Icons.Phosphor.Duotone.DiceFour,
            (Duotone, Five) => Icons.Phosphor.Duotone.DiceFive,
            (Duotone, Six) => Icons.Phosphor.Duotone.DiceSix,
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