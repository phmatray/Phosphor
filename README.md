# MudBlazor.Phosphor

A flexible, beautiful icon family for MudBlazor applications. This library provides seamless integration of [Phosphor Icons](https://phosphoricons.com/) with [MudBlazor](https://mudblazor.com/) components.

## Features

- **1,200+ Icons**: Access to the complete Phosphor Icons library
- **6 Icon Styles**: Choose from Thin, Light, Regular, Bold, Fill, and Duotone variants
- **MudBlazor Integration**: Works seamlessly with MudIcon and other MudBlazor components
- **Super Icons**: Specialized icon components with parameterized selection (e.g., dice values, battery levels)
- **Type-Safe**: Strongly-typed icon constants for IntelliSense support
- **.NET 8.0**: Built on the latest .NET platform

## Installation

```bash
dotnet add package MudBlazor.PhosphorIcons
```

## Quick Start

### 1. Add the namespace to your `_Imports.razor`:

```razor
@using MudBlazor.Phosphor
@using static Phosphor.Components.Icons
```

### 2. Include the Phosphor CSS in your app:

Add the Phosphor icon fonts to your project and reference them in your `App.razor` or `index.html`/`_Host.cshtml`:

```html
<link rel="stylesheet" href="path/to/phosphor-icons.css">
```

### 3. Use icons in your components:

```razor
@* Basic usage *@
<MudIcon Icon="@Phosphor.Regular.Heart" />
<MudIcon Icon="@Phosphor.Bold.Star" />
<MudIcon Icon="@Phosphor.Fill.ThumbsUp" />

@* With MudBlazor components *@
<MudButton StartIcon="@Phosphor.Regular.Airplane" Variant="Variant.Filled">
    Book Flight
</MudButton>

@* With color and size *@
<MudIcon Icon="@Phosphor.Regular.Radioactive"
         Color="Color.Warning"
         Size="Size.Large" />
```

## Icon Styles

Phosphor Icons come in six distinct styles:

```razor
<MudIcon Icon="@Phosphor.Thin.Heart" />      <!-- Thin -->
<MudIcon Icon="@Phosphor.Light.Heart" />     <!-- Light -->
<MudIcon Icon="@Phosphor.Regular.Heart" />   <!-- Regular (default) -->
<MudIcon Icon="@Phosphor.Bold.Heart" />      <!-- Bold -->
<MudIcon Icon="@Phosphor.Fill.Heart" />      <!-- Fill -->
<MudIcon Icon="@Phosphor.Duotone.Heart" />   <!-- Duotone -->
```

## Super Icons

Super Icons are specialized components that provide parameterized icon selection for related icon sets:

### SuperDiceIcon

Display dice with configurable values and styles:

```razor
<SuperDiceIcon Value="DiceValue.Six" Weight="IconWeight.Bold" />
<SuperDiceIcon Value="DiceValue.Three" Weight="IconWeight.Regular" />
```

### SuperBatteryIcon

Show battery levels with different charge states:

```razor
<SuperBatteryIcon Level="BatteryLevel.Full" Weight="IconWeight.Fill" />
<SuperBatteryIcon Level="BatteryLevel.Low" Weight="IconWeight.Regular" />
```

### Other Super Icons

- **SuperFileIcon**: Different file type icons
- **SuperGenderIcon**: Gender representation icons
- **SuperNumberIcon**: Numbered icons
- **SuperSmileyIcon**: Various smiley expressions

All Super Icons inherit from `SuperIcon` and support the `Weight` parameter to change icon styles dynamically.

## Examples

### In Buttons

```razor
<MudButton StartIcon="@Phosphor.Regular.Download" Color="Color.Primary">
    Download
</MudButton>

<MudIconButton Icon="@Phosphor.Bold.Trash" Color="Color.Error" />
```

### In Navigation

```razor
<MudNavLink Icon="@Phosphor.Regular.House" Href="/">Home</MudNavLink>
<MudNavLink Icon="@Phosphor.Regular.Gear" Href="/settings">Settings</MudNavLink>
```

### Different Colors

```razor
<MudIcon Icon="@Phosphor.Regular.Warning" Color="Color.Warning" />
<MudIcon Icon="@Phosphor.Regular.CheckCircle" Color="Color.Success" />
<MudIcon Icon="@Phosphor.Regular.Info" Color="Color.Info" />
```

### Custom Sizes

```razor
<MudIcon Icon="@Phosphor.Regular.Star" Size="Size.Small" />
<MudIcon Icon="@Phosphor.Regular.Star" Size="Size.Medium" />
<MudIcon Icon="@Phosphor.Regular.Star" Size="Size.Large" />
<MudIcon Icon="@Phosphor.Regular.Star" Style="font-size: 4rem;" />
```

## Project Structure

```
Phosphor/
├── MudBlazor.PhosphorIcons/    # Main library package
│   ├── Components/              # Super Icon components
│   ├── Abstractions/            # Base classes and interfaces
│   └── Models/                  # Enums and models
├── Phosphor/                    # Demo web application
│   └── Components/Pages/        # Example pages
├── Phosphor.UnitTests/          # Unit tests
├── build/                       # NUKE build configuration
├── input/                       # Source icon fonts
└── output/                      # Generated Icons.cs
```

## Building from Source

This project uses [NUKE](https://nuke.build/) as the build system.

### Prerequisites

- .NET 8.0 SDK or later
- Phosphor icon fonts (place in `input/fonts/` directory)

### Build Steps

```bash
# Clone the repository
git clone https://github.com/yourusername/Phosphor.git
cd Phosphor

# Run the build
./build.sh         # Linux/macOS
./build.cmd        # Windows (CMD)
./build.ps1        # Windows (PowerShell)
```

The build process will:
1. Clean the output directory
2. Parse icon font metadata from `selection.json` files
3. Generate the `Icons.cs` file with all icon constants
4. Build the solution

### Running the Demo

```bash
cd Phosphor
dotnet run
```

Then navigate to `https://localhost:5001` to see the demo application.

## Icon Generation

The icon constants are automatically generated from the Phosphor icon fonts using a custom NUKE build script. The build script:

1. Reads icon metadata from `input/fonts/{style}/selection.json`
2. Generates C# constants for each icon and style
3. Outputs the result to `output/Icons.cs`

The generated file structure:

```csharp
namespace Phosphor.Components
{
    public static class Icons
    {
        public static class Phosphor
        {
            public static class Bold
            {
                public const string Heart = "ph-bold ph-heart";
                // ... more icons
            }

            public static class Regular
            {
                public const string Heart = "ph-regular ph-heart";
                // ... more icons
            }

            // ... other styles
        }
    }
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

### Development Guidelines

1. Follow the existing code style
2. Add unit tests for new features
3. Update documentation as needed
4. Run the build script before submitting

## Resources

- [Phosphor Icons](https://phosphoricons.com/) - Official Phosphor Icons website
- [MudBlazor](https://mudblazor.com/) - Official MudBlazor documentation
- [NUKE Build](https://nuke.build/) - Build automation system

## License

Please check the LICENSE file for details.

## Acknowledgments

- [Phosphor Icons](https://phosphoricons.com/) for the beautiful icon set
- [MudBlazor](https://mudblazor.com/) for the excellent Blazor component library
