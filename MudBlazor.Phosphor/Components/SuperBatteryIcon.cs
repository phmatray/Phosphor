using Microsoft.AspNetCore.Components;
using Phosphor.Components;
using static MudBlazor.Phosphor.BatteryState;
using static MudBlazor.Phosphor.BatteryLevel;
using static MudBlazor.Phosphor.BatteryOrientation;
using static MudBlazor.Phosphor.IconWeight;

namespace MudBlazor.Phosphor;

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
                (Regular, Horizontal, Charging) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryCharging,
                (Regular, Horizontal, Plus) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryPlus,
                (Regular, Horizontal, Warning) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryWarning,
                (Regular, Vertical, Charging) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryChargingVertical,
                (Regular, Vertical, Plus) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryPlusVertical,
                (Regular, Vertical, Warning) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryWarningVertical,
                // Thin
                (Thin, Horizontal, Charging) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryCharging,
                (Thin, Horizontal, Plus) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryPlus,
                (Thin, Horizontal, Warning) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryWarning,
                (Thin, Vertical, Charging) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryChargingVertical,
                (Thin, Vertical, Plus) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryPlusVertical,
                (Thin, Vertical, Warning) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryWarningVertical,
                // Light
                (Light, Horizontal, Charging) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryCharging,
                (Light, Horizontal, Plus) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryPlus,
                (Light, Horizontal, Warning) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryWarning,
                (Light, Vertical, Charging) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryChargingVertical,
                (Light, Vertical, Plus) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryPlusVertical,
                (Light, Vertical, Warning) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryWarningVertical,
                // Bold
                (Bold, Horizontal, Charging) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryCharging,
                (Bold, Horizontal, Plus) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryPlus,
                (Bold, Horizontal, Warning) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryWarning,
                (Bold, Vertical, Charging) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryChargingVertical,
                (Bold, Vertical, Plus) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryPlusVertical,
                (Bold, Vertical, Warning) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryWarningVertical,
                // Fill
                (Fill, Horizontal, Charging) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryCharging,
                (Fill, Horizontal, Plus) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryPlus,
                (Fill, Horizontal, Warning) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryWarning,
                (Fill, Vertical, Charging) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryChargingVertical,
                (Fill, Vertical, Plus) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryPlusVertical,
                (Fill, Vertical, Warning) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryWarningVertical,
                // Duotone
                (Duotone, Horizontal, Charging) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryCharging,
                (Duotone, Horizontal, Plus) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryPlus,
                (Duotone, Horizontal, Warning) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryWarning,
                (Duotone, Vertical, Charging) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryChargingVertical,
                (Duotone, Vertical, Plus) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryPlusVertical,
                (Duotone, Vertical, Warning) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryWarningVertical,
                // Default (should never happen)
                _ => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryEmpty,
            };
        }
        
        return (Weight, BatteryOrientation, Level) switch
        {
            // Regular
            (Regular, Horizontal, Empty) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryEmpty,
            (Regular, Horizontal, Low) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryLow,
            (Regular, Horizontal, Medium) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryMedium,
            (Regular, Horizontal, High) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryHigh,
            (Regular, Horizontal, Full) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryFull,
            (Regular, Vertical, Empty) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryVerticalEmpty,
            (Regular, Vertical, Low) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryVerticalLow,
            (Regular, Vertical, Medium) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryVerticalMedium,
            (Regular, Vertical, High) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryVerticalHigh,
            (Regular, Vertical, Full) => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryVerticalFull,
            // Thin
            (Thin, Horizontal, Empty) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryEmpty,
            (Thin, Horizontal, Low) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryLow,
            (Thin, Horizontal, Medium) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryMedium,
            (Thin, Horizontal, High) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryHigh,
            (Thin, Horizontal, Full) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryFull,
            (Thin, Vertical, Empty) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryVerticalEmpty,
            (Thin, Vertical, Low) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryVerticalLow,
            (Thin, Vertical, Medium) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryVerticalMedium,
            (Thin, Vertical, High) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryVerticalHigh,
            (Thin, Vertical, Full) => global::Phosphor.Components.Icons.Phosphor.Thin.BatteryVerticalFull,
            // Light
            (Light, Horizontal, Empty) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryEmpty,
            (Light, Horizontal, Low) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryLow,
            (Light, Horizontal, Medium) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryMedium,
            (Light, Horizontal, High) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryHigh,
            (Light, Horizontal, Full) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryFull,
            (Light, Vertical, Empty) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryVerticalEmpty,
            (Light, Vertical, Low) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryVerticalLow,
            (Light, Vertical, Medium) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryVerticalMedium,
            (Light, Vertical, High) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryVerticalHigh,
            (Light, Vertical, Full) => global::Phosphor.Components.Icons.Phosphor.Light.BatteryVerticalFull,
            // Bold
            (Bold, Horizontal, Empty) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryEmpty,
            (Bold, Horizontal, Low) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryLow,
            (Bold, Horizontal, Medium) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryMedium,
            (Bold, Horizontal, High) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryHigh,
            (Bold, Horizontal, Full) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryFull,
            (Bold, Vertical, Empty) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryVerticalEmpty,
            (Bold, Vertical, Low) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryVerticalLow,
            (Bold, Vertical, Medium) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryVerticalMedium,
            (Bold, Vertical, High) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryVerticalHigh,
            (Bold, Vertical, Full) => global::Phosphor.Components.Icons.Phosphor.Bold.BatteryVerticalFull,
            // Fill
            (Fill, Horizontal, Empty) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryEmpty,
            (Fill, Horizontal, Low) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryLow,
            (Fill, Horizontal, Medium) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryMedium,
            (Fill, Horizontal, High) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryHigh,
            (Fill, Horizontal, Full) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryFull,
            (Fill, Vertical, Empty) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryVerticalEmpty,
            (Fill, Vertical, Low) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryVerticalLow,
            (Fill, Vertical, Medium) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryVerticalMedium,
            (Fill, Vertical, High) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryVerticalHigh,
            (Fill, Vertical, Full) => global::Phosphor.Components.Icons.Phosphor.Fill.BatteryVerticalFull,
            // Duotone
            (Duotone, Horizontal, Empty) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryEmpty,
            (Duotone, Horizontal, Low) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryLow,
            (Duotone, Horizontal, Medium) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryMedium,
            (Duotone, Horizontal, High) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryHigh,
            (Duotone, Horizontal, Full) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryFull,
            (Duotone, Vertical, Empty) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryVerticalEmpty,
            (Duotone, Vertical, Low) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryVerticalLow,
            (Duotone, Vertical, Medium) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryVerticalMedium,
            (Duotone, Vertical, High) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryVerticalHigh,
            (Duotone, Vertical, Full) => global::Phosphor.Components.Icons.Phosphor.Duotone.BatteryVerticalFull,
            _ => global::Phosphor.Components.Icons.Phosphor.Regular.BatteryEmpty,
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