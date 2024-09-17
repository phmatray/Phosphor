using Microsoft.AspNetCore.Components;

namespace MudBlazor.Phosphor;

public abstract class SuperIcon : MudIcon
{
    public SuperIcon()
    {
        Icon = GetIcon();
    }
    
    [Parameter]
    public IconWeight Weight { get; set; } = IconWeight.Regular;
    
    // Make Icon not user settable
    public new string Icon
    {
        get => GetIcon();
        private set => base.Icon = value;
    }

    protected override void OnParametersSet()
    {
        Icon = GetIcon();
    }
    
    public abstract string GetIcon();
}