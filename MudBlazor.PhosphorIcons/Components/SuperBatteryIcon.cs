using static MudBlazor.Phosphor.BatteryState;
using static MudBlazor.Phosphor.BatteryLevel;
using static MudBlazor.Phosphor.BatteryOrientation;

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
                (Regular, Horizontal, Charging) => PhosphorRegular.BatteryCharging,
                (Regular, Horizontal, Plus) => PhosphorRegular.BatteryPlus,
                (Regular, Horizontal, Warning) => PhosphorRegular.BatteryWarning,
                (Regular, Vertical, Charging) => PhosphorRegular.BatteryChargingVertical,
                (Regular, Vertical, Plus) => PhosphorRegular.BatteryPlusVertical,
                (Regular, Vertical, Warning) => PhosphorRegular.BatteryWarningVertical,
                // Thin
                (Thin, Horizontal, Charging) => PhosphorThin.BatteryCharging,
                (Thin, Horizontal, Plus) => PhosphorThin.BatteryPlus,
                (Thin, Horizontal, Warning) => PhosphorThin.BatteryWarning,
                (Thin, Vertical, Charging) => PhosphorThin.BatteryChargingVertical,
                (Thin, Vertical, Plus) => PhosphorThin.BatteryPlusVertical,
                (Thin, Vertical, Warning) => PhosphorThin.BatteryWarningVertical,
                // Light
                (Light, Horizontal, Charging) => PhosphorLight.BatteryCharging,
                (Light, Horizontal, Plus) => PhosphorLight.BatteryPlus,
                (Light, Horizontal, Warning) => PhosphorLight.BatteryWarning,
                (Light, Vertical, Charging) => PhosphorLight.BatteryChargingVertical,
                (Light, Vertical, Plus) => PhosphorLight.BatteryPlusVertical,
                (Light, Vertical, Warning) => PhosphorLight.BatteryWarningVertical,
                // Bold
                (Bold, Horizontal, Charging) => PhosphorBold.BatteryCharging,
                (Bold, Horizontal, Plus) => PhosphorBold.BatteryPlus,
                (Bold, Horizontal, Warning) => PhosphorBold.BatteryWarning,
                (Bold, Vertical, Charging) => PhosphorBold.BatteryChargingVertical,
                (Bold, Vertical, Plus) => PhosphorBold.BatteryPlusVertical,
                (Bold, Vertical, Warning) => PhosphorBold.BatteryWarningVertical,
                // Fill
                (Fill, Horizontal, Charging) => PhosphorFill.BatteryCharging,
                (Fill, Horizontal, Plus) => PhosphorFill.BatteryPlus,
                (Fill, Horizontal, Warning) => PhosphorFill.BatteryWarning,
                (Fill, Vertical, Charging) => PhosphorFill.BatteryChargingVertical,
                (Fill, Vertical, Plus) => PhosphorFill.BatteryPlusVertical,
                (Fill, Vertical, Warning) => PhosphorFill.BatteryWarningVertical,
                // Duotone
                (Duotone, Horizontal, Charging) => PhosphorDuotone.BatteryCharging,
                (Duotone, Horizontal, Plus) => PhosphorDuotone.BatteryPlus,
                (Duotone, Horizontal, Warning) => PhosphorDuotone.BatteryWarning,
                (Duotone, Vertical, Charging) => PhosphorDuotone.BatteryChargingVertical,
                (Duotone, Vertical, Plus) => PhosphorDuotone.BatteryPlusVertical,
                (Duotone, Vertical, Warning) => PhosphorDuotone.BatteryWarningVertical,
                // Default (should never happen)
                _ => PhosphorRegular.BatteryEmpty,
            };
        }
        
        return (Weight, BatteryOrientation, Level) switch
        {
            // Regular
            (Regular, Horizontal, Empty) => PhosphorRegular.BatteryEmpty,
            (Regular, Horizontal, Low) => PhosphorRegular.BatteryLow,
            (Regular, Horizontal, Medium) => PhosphorRegular.BatteryMedium,
            (Regular, Horizontal, High) => PhosphorRegular.BatteryHigh,
            (Regular, Horizontal, Full) => PhosphorRegular.BatteryFull,
            (Regular, Vertical, Empty) => PhosphorRegular.BatteryVerticalEmpty,
            (Regular, Vertical, Low) => PhosphorRegular.BatteryVerticalLow,
            (Regular, Vertical, Medium) => PhosphorRegular.BatteryVerticalMedium,
            (Regular, Vertical, High) => PhosphorRegular.BatteryVerticalHigh,
            (Regular, Vertical, Full) => PhosphorRegular.BatteryVerticalFull,
            // Thin
            (Thin, Horizontal, Empty) => PhosphorThin.BatteryEmpty,
            (Thin, Horizontal, Low) => PhosphorThin.BatteryLow,
            (Thin, Horizontal, Medium) => PhosphorThin.BatteryMedium,
            (Thin, Horizontal, High) => PhosphorThin.BatteryHigh,
            (Thin, Horizontal, Full) => PhosphorThin.BatteryFull,
            (Thin, Vertical, Empty) => PhosphorThin.BatteryVerticalEmpty,
            (Thin, Vertical, Low) => PhosphorThin.BatteryVerticalLow,
            (Thin, Vertical, Medium) => PhosphorThin.BatteryVerticalMedium,
            (Thin, Vertical, High) => PhosphorThin.BatteryVerticalHigh,
            (Thin, Vertical, Full) => PhosphorThin.BatteryVerticalFull,
            // Light
            (Light, Horizontal, Empty) => PhosphorLight.BatteryEmpty,
            (Light, Horizontal, Low) => PhosphorLight.BatteryLow,
            (Light, Horizontal, Medium) => PhosphorLight.BatteryMedium,
            (Light, Horizontal, High) => PhosphorLight.BatteryHigh,
            (Light, Horizontal, Full) => PhosphorLight.BatteryFull,
            (Light, Vertical, Empty) => PhosphorLight.BatteryVerticalEmpty,
            (Light, Vertical, Low) => PhosphorLight.BatteryVerticalLow,
            (Light, Vertical, Medium) => PhosphorLight.BatteryVerticalMedium,
            (Light, Vertical, High) => PhosphorLight.BatteryVerticalHigh,
            (Light, Vertical, Full) => PhosphorLight.BatteryVerticalFull,
            // Bold
            (Bold, Horizontal, Empty) => PhosphorBold.BatteryEmpty,
            (Bold, Horizontal, Low) => PhosphorBold.BatteryLow,
            (Bold, Horizontal, Medium) => PhosphorBold.BatteryMedium,
            (Bold, Horizontal, High) => PhosphorBold.BatteryHigh,
            (Bold, Horizontal, Full) => PhosphorBold.BatteryFull,
            (Bold, Vertical, Empty) => PhosphorBold.BatteryVerticalEmpty,
            (Bold, Vertical, Low) => PhosphorBold.BatteryVerticalLow,
            (Bold, Vertical, Medium) => PhosphorBold.BatteryVerticalMedium,
            (Bold, Vertical, High) => PhosphorBold.BatteryVerticalHigh,
            (Bold, Vertical, Full) => PhosphorBold.BatteryVerticalFull,
            // Fill
            (Fill, Horizontal, Empty) => PhosphorFill.BatteryEmpty,
            (Fill, Horizontal, Low) => PhosphorFill.BatteryLow,
            (Fill, Horizontal, Medium) => PhosphorFill.BatteryMedium,
            (Fill, Horizontal, High) => PhosphorFill.BatteryHigh,
            (Fill, Horizontal, Full) => PhosphorFill.BatteryFull,
            (Fill, Vertical, Empty) => PhosphorFill.BatteryVerticalEmpty,
            (Fill, Vertical, Low) => PhosphorFill.BatteryVerticalLow,
            (Fill, Vertical, Medium) => PhosphorFill.BatteryVerticalMedium,
            (Fill, Vertical, High) => PhosphorFill.BatteryVerticalHigh,
            (Fill, Vertical, Full) => PhosphorFill.BatteryVerticalFull,
            // Duotone
            (Duotone, Horizontal, Empty) => PhosphorDuotone.BatteryEmpty,
            (Duotone, Horizontal, Low) => PhosphorDuotone.BatteryLow,
            (Duotone, Horizontal, Medium) => PhosphorDuotone.BatteryMedium,
            (Duotone, Horizontal, High) => PhosphorDuotone.BatteryHigh,
            (Duotone, Horizontal, Full) => PhosphorDuotone.BatteryFull,
            (Duotone, Vertical, Empty) => PhosphorDuotone.BatteryVerticalEmpty,
            (Duotone, Vertical, Low) => PhosphorDuotone.BatteryVerticalLow,
            (Duotone, Vertical, Medium) => PhosphorDuotone.BatteryVerticalMedium,
            (Duotone, Vertical, High) => PhosphorDuotone.BatteryVerticalHigh,
            (Duotone, Vertical, Full) => PhosphorDuotone.BatteryVerticalFull,
            _ => PhosphorRegular.BatteryEmpty,
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