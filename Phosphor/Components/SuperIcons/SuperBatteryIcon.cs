using Microsoft.AspNetCore.Components;
using static Phosphor.Components.SuperIcons.BatteryState;
using static Phosphor.Components.SuperIcons.BatteryLevel;
using static Phosphor.Components.SuperIcons.BatteryOrientation;
using static Phosphor.Models.IconWeight;

namespace Phosphor.Components.SuperIcons;

public class SuperBatteryIcon : SuperIcon
{
    [Parameter]
    public BatteryState State { get; set; } = Normal;

    [Parameter]
    public BatteryOrientation BatteryOrientation { get; set; } = Horizontal;

    [Parameter]
    public BatteryLevel Level { get; set; } = Empty;

    public override string GetIcon()
    {
        if (State != Normal)
        {
            return (Weight, BatteryOrientation, State) switch
            {
                // Regular
                (Regular, Horizontal, Charging) => Icons.Phosphor.Regular.BatteryCharging,
                (Regular, Horizontal, Plus) => Icons.Phosphor.Regular.BatteryPlus,
                (Regular, Horizontal, Warning) => Icons.Phosphor.Regular.BatteryWarning,
                (Regular, Vertical, Charging) => Icons.Phosphor.Regular.BatteryChargingVertical,
                (Regular, Vertical, Plus) => Icons.Phosphor.Regular.BatteryPlusVertical,
                (Regular, Vertical, Warning) => Icons.Phosphor.Regular.BatteryWarningVertical,
                // Thin
                (Thin, Horizontal, Charging) => Icons.Phosphor.Thin.BatteryCharging,
                (Thin, Horizontal, Plus) => Icons.Phosphor.Thin.BatteryPlus,
                (Thin, Horizontal, Warning) => Icons.Phosphor.Thin.BatteryWarning,
                (Thin, Vertical, Charging) => Icons.Phosphor.Thin.BatteryChargingVertical,
                (Thin, Vertical, Plus) => Icons.Phosphor.Thin.BatteryPlusVertical,
                (Thin, Vertical, Warning) => Icons.Phosphor.Thin.BatteryWarningVertical,
                // Light
                (Light, Horizontal, Charging) => Icons.Phosphor.Light.BatteryCharging,
                (Light, Horizontal, Plus) => Icons.Phosphor.Light.BatteryPlus,
                (Light, Horizontal, Warning) => Icons.Phosphor.Light.BatteryWarning,
                (Light, Vertical, Charging) => Icons.Phosphor.Light.BatteryChargingVertical,
                (Light, Vertical, Plus) => Icons.Phosphor.Light.BatteryPlusVertical,
                (Light, Vertical, Warning) => Icons.Phosphor.Light.BatteryWarningVertical,
                // Bold
                (Bold, Horizontal, Charging) => Icons.Phosphor.Bold.BatteryCharging,
                (Bold, Horizontal, Plus) => Icons.Phosphor.Bold.BatteryPlus,
                (Bold, Horizontal, Warning) => Icons.Phosphor.Bold.BatteryWarning,
                (Bold, Vertical, Charging) => Icons.Phosphor.Bold.BatteryChargingVertical,
                (Bold, Vertical, Plus) => Icons.Phosphor.Bold.BatteryPlusVertical,
                (Bold, Vertical, Warning) => Icons.Phosphor.Bold.BatteryWarningVertical,
                // Fill
                (Fill, Horizontal, Charging) => Icons.Phosphor.Fill.BatteryCharging,
                (Fill, Horizontal, Plus) => Icons.Phosphor.Fill.BatteryPlus,
                (Fill, Horizontal, Warning) => Icons.Phosphor.Fill.BatteryWarning,
                (Fill, Vertical, Charging) => Icons.Phosphor.Fill.BatteryChargingVertical,
                (Fill, Vertical, Plus) => Icons.Phosphor.Fill.BatteryPlusVertical,
                (Fill, Vertical, Warning) => Icons.Phosphor.Fill.BatteryWarningVertical,
                // Duotone
                (Duotone, Horizontal, Charging) => Icons.Phosphor.Duotone.BatteryCharging,
                (Duotone, Horizontal, Plus) => Icons.Phosphor.Duotone.BatteryPlus,
                (Duotone, Horizontal, Warning) => Icons.Phosphor.Duotone.BatteryWarning,
                (Duotone, Vertical, Charging) => Icons.Phosphor.Duotone.BatteryChargingVertical,
                (Duotone, Vertical, Plus) => Icons.Phosphor.Duotone.BatteryPlusVertical,
                (Duotone, Vertical, Warning) => Icons.Phosphor.Duotone.BatteryWarningVertical,
                // Default (should never happen)
                _ => Icons.Phosphor.Regular.BatteryEmpty,
            };
        }
        
        return (Weight, BatteryOrientation, Level) switch
        {
            // Regular
            (Regular, Horizontal, Empty) => Icons.Phosphor.Regular.BatteryEmpty,
            (Regular, Horizontal, Low) => Icons.Phosphor.Regular.BatteryLow,
            (Regular, Horizontal, Medium) => Icons.Phosphor.Regular.BatteryMedium,
            (Regular, Horizontal, High) => Icons.Phosphor.Regular.BatteryHigh,
            (Regular, Horizontal, Full) => Icons.Phosphor.Regular.BatteryFull,
            (Regular, Vertical, Empty) => Icons.Phosphor.Regular.BatteryVerticalEmpty,
            (Regular, Vertical, Low) => Icons.Phosphor.Regular.BatteryVerticalLow,
            (Regular, Vertical, Medium) => Icons.Phosphor.Regular.BatteryVerticalMedium,
            (Regular, Vertical, High) => Icons.Phosphor.Regular.BatteryVerticalHigh,
            (Regular, Vertical, Full) => Icons.Phosphor.Regular.BatteryVerticalFull,
            // Thin
            (Thin, Horizontal, Empty) => Icons.Phosphor.Thin.BatteryEmpty,
            (Thin, Horizontal, Low) => Icons.Phosphor.Thin.BatteryLow,
            (Thin, Horizontal, Medium) => Icons.Phosphor.Thin.BatteryMedium,
            (Thin, Horizontal, High) => Icons.Phosphor.Thin.BatteryHigh,
            (Thin, Horizontal, Full) => Icons.Phosphor.Thin.BatteryFull,
            (Thin, Vertical, Empty) => Icons.Phosphor.Thin.BatteryVerticalEmpty,
            (Thin, Vertical, Low) => Icons.Phosphor.Thin.BatteryVerticalLow,
            (Thin, Vertical, Medium) => Icons.Phosphor.Thin.BatteryVerticalMedium,
            (Thin, Vertical, High) => Icons.Phosphor.Thin.BatteryVerticalHigh,
            (Thin, Vertical, Full) => Icons.Phosphor.Thin.BatteryVerticalFull,
            // Light
            (Light, Horizontal, Empty) => Icons.Phosphor.Light.BatteryEmpty,
            (Light, Horizontal, Low) => Icons.Phosphor.Light.BatteryLow,
            (Light, Horizontal, Medium) => Icons.Phosphor.Light.BatteryMedium,
            (Light, Horizontal, High) => Icons.Phosphor.Light.BatteryHigh,
            (Light, Horizontal, Full) => Icons.Phosphor.Light.BatteryFull,
            (Light, Vertical, Empty) => Icons.Phosphor.Light.BatteryVerticalEmpty,
            (Light, Vertical, Low) => Icons.Phosphor.Light.BatteryVerticalLow,
            (Light, Vertical, Medium) => Icons.Phosphor.Light.BatteryVerticalMedium,
            (Light, Vertical, High) => Icons.Phosphor.Light.BatteryVerticalHigh,
            (Light, Vertical, Full) => Icons.Phosphor.Light.BatteryVerticalFull,
            // Bold
            (Bold, Horizontal, Empty) => Icons.Phosphor.Bold.BatteryEmpty,
            (Bold, Horizontal, Low) => Icons.Phosphor.Bold.BatteryLow,
            (Bold, Horizontal, Medium) => Icons.Phosphor.Bold.BatteryMedium,
            (Bold, Horizontal, High) => Icons.Phosphor.Bold.BatteryHigh,
            (Bold, Horizontal, Full) => Icons.Phosphor.Bold.BatteryFull,
            (Bold, Vertical, Empty) => Icons.Phosphor.Bold.BatteryVerticalEmpty,
            (Bold, Vertical, Low) => Icons.Phosphor.Bold.BatteryVerticalLow,
            (Bold, Vertical, Medium) => Icons.Phosphor.Bold.BatteryVerticalMedium,
            (Bold, Vertical, High) => Icons.Phosphor.Bold.BatteryVerticalHigh,
            (Bold, Vertical, Full) => Icons.Phosphor.Bold.BatteryVerticalFull,
            // Fill
            (Fill, Horizontal, Empty) => Icons.Phosphor.Fill.BatteryEmpty,
            (Fill, Horizontal, Low) => Icons.Phosphor.Fill.BatteryLow,
            (Fill, Horizontal, Medium) => Icons.Phosphor.Fill.BatteryMedium,
            (Fill, Horizontal, High) => Icons.Phosphor.Fill.BatteryHigh,
            (Fill, Horizontal, Full) => Icons.Phosphor.Fill.BatteryFull,
            (Fill, Vertical, Empty) => Icons.Phosphor.Fill.BatteryVerticalEmpty,
            (Fill, Vertical, Low) => Icons.Phosphor.Fill.BatteryVerticalLow,
            (Fill, Vertical, Medium) => Icons.Phosphor.Fill.BatteryVerticalMedium,
            (Fill, Vertical, High) => Icons.Phosphor.Fill.BatteryVerticalHigh,
            (Fill, Vertical, Full) => Icons.Phosphor.Fill.BatteryVerticalFull,
            // Duotone
            (Duotone, Horizontal, Empty) => Icons.Phosphor.Duotone.BatteryEmpty,
            (Duotone, Horizontal, Low) => Icons.Phosphor.Duotone.BatteryLow,
            (Duotone, Horizontal, Medium) => Icons.Phosphor.Duotone.BatteryMedium,
            (Duotone, Horizontal, High) => Icons.Phosphor.Duotone.BatteryHigh,
            (Duotone, Horizontal, Full) => Icons.Phosphor.Duotone.BatteryFull,
            (Duotone, Vertical, Empty) => Icons.Phosphor.Duotone.BatteryVerticalEmpty,
            (Duotone, Vertical, Low) => Icons.Phosphor.Duotone.BatteryVerticalLow,
            (Duotone, Vertical, Medium) => Icons.Phosphor.Duotone.BatteryVerticalMedium,
            (Duotone, Vertical, High) => Icons.Phosphor.Duotone.BatteryVerticalHigh,
            (Duotone, Vertical, Full) => Icons.Phosphor.Duotone.BatteryVerticalFull,
            _ => Icons.Phosphor.Regular.BatteryEmpty,
        };
    }
}

public enum BatteryState
{
    Normal,
    Charging,
    Plus,
    Warning,
}

public enum BatteryLevel
{
    Empty,
    Low,
    Medium,
    High,
    Full,
}

public enum BatteryOrientation
{
    Horizontal,
    Vertical,
}