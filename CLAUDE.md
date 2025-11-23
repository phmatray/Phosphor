# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a MudBlazor icon library that integrates Phosphor Icons (1,200+ icons in 6 styles) into MudBlazor components. The project consists of:
- **Phosphor.MudBlazor**: Blazor component library providing icon components
- **Phosphor**: Demo Blazor web application showcasing the icons
- **build**: NUKE build system that auto-generates icon classes from Phosphor font files
- **Phosphor.UnitTests**: Unit tests using NUnit
- **input/fonts**: Source Phosphor font files with metadata (selection.json)
- **output**: Generated Icons.cs file (linked into library project)

## Common Commands

```bash
# Generate Icons.cs from font definitions (regenerate after updating fonts)
./build.ps1 GenerateIconsClass  # Windows PowerShell
./build.sh GenerateIconsClass   # macOS/Linux
build.cmd GenerateIconsClass    # Windows CMD

# Build the solution using NUKE
./build.sh Compile  # Generates icons + builds solution

# Build the solution using dotnet CLI
dotnet build

# Create NuGet package (generates icons, builds, and packs)
./build.sh Pack  # Creates package in artifacts/ directory

# Run all tests
dotnet test

# Run specific test
dotnet test --filter "FullyQualifiedName~YourTestName"

# Run the demo application (https://localhost:5001)
dotnet run --project Phosphor/Phosphor.csproj

# Clean output directory
./build.ps1 Clean  # or ./build.sh Clean
```

## Architecture

### Icon Generation Pipeline
The build system automatically generates thousands of icon constants from font metadata:

1. **Input**: Each font style has `input/fonts/{style}/selection.json` containing icon metadata
2. **Build Process** (`build/Build.cs`):
   - Reads all 6 style selection.json files (Bold, Duotone, Fill, Light, Regular, Thin)
   - Parses icon names from JSON using QuickType models
   - Converts kebab-case names to PascalCase properties (e.g., `thumbs-up` → `ThumbsUp`)
   - Generates CSS class strings (e.g., `"ph-bold ph-thumbs-up"`)
   - Uses custom C# builders (`ClassBuilder`, `NamespaceBuilder`) to generate source code
3. **Output**: Generates `output/Icons.cs` with nested static classes:
   ```csharp
   namespace Phosphor.Components {
       public static class Icons {
           public static class Phosphor {
               public static class Bold { public const string Heart = "ph-bold ph-heart"; }
               public static class Regular { public const string Heart = "ph ph-heart"; }
               // ... other styles
           }
       }
   }
   ```
4. **Integration**: Icons.cs is linked into Phosphor.MudBlazor.csproj as a compile item

### Component Architecture

**SuperIcon Pattern**: Abstract base class that enables parameterized icon selection
- Extends `MudBlazor.MudIcon` for seamless integration
- Overrides `Icon` property to make it read-only (computed from parameters)
- Implements `OnParametersSet()` to refresh icon when Weight changes
- Subclasses define custom enums and implement `GetIcon()` with switch expressions

**Example SuperIcon Implementation**:
```csharp
public class SuperDiceIcon : SuperIcon {
    [Parameter] public DiceValue Value { get; set; } = One;

    public override string GetIcon() => (Weight, Value) switch {
        (Regular, One) => PhosphorRegular.DiceOne,
        (Bold, Six) => PhosphorBold.DiceSix,
        // ... all (6 weights × N values) combinations
    };
}
```

**Existing Super Icons**:
- `SuperDiceIcon` - Dice faces (One through Six)
- `SuperBatteryIcon` - Battery levels (Empty, Low, Medium, High, Full, Charging)
- `SuperFileIcon` - File types (with ~40 variations per weight)
- `SuperNumberIcon` - Numbered icons
- `SuperGenderIcon` - Gender representation icons
- `SuperSmileyIcon` - Smiley expressions

**IconWeight Enum**: `Regular`, `Thin`, `Light`, `Bold`, `Fill`, `Duotone`

### Key Design Patterns

1. **Tuple Pattern Matching**: Super icons use `(Weight, Value) switch` expressions to map parameter combinations to icon CSS classes. This creates an exhaustive matrix of all possible icon states.

2. **Code Generation over Hand-Coding**: The NUKE build system parses font metadata and generates thousands of type-safe C# constants. This eliminates manual maintenance and ensures consistency with Phosphor Icons updates.

3. **Component Lifecycle Integration**: SuperIcon overrides Blazor's `OnParametersSet()` to recompute the icon string whenever parameters change, ensuring reactive updates.

4. **Enum Qualification**: When enum values conflict with common names (e.g., `Lock`), use fully-qualified names in pattern matching: `(Regular, FileValue.Lock)` instead of `(Regular, Lock)`.

## Development Workflow

### Adding New Super Icon Components
1. Create new class in `Phosphor.MudBlazor/Components/` inheriting from `SuperIcon`
2. Define an enum for icon variations (e.g., `public enum BatteryLevel { Empty, Low, High }`)
3. Add `[Parameter] public YourEnum Value { get; set; }`
4. Implement `GetIcon()` with exhaustive pattern matching for all (Weight × Value) combinations
5. Handle all 6 weights: Regular, Thin, Light, Bold, Fill, Duotone
6. Use fully-qualified enum names if ambiguous (e.g., `FileValue.Lock`)
7. Add demo page in `Phosphor/Components/SuperIcons/` or `Phosphor/Components/Pages/`

### Updating Phosphor Fonts
1. Download new Phosphor font files from phosphoricons.com
2. Replace files in `input/fonts/{style}/` directories (keep selection.json structure)
3. Run `./build.sh GenerateIconsClass` to regenerate Icons.cs
4. Build solution and verify no compilation errors
5. Test super icon components to ensure all icon references remain valid
6. Run unit tests with `dotnet test`

### Modifying the Build System
- Build logic is in `build/Build.cs` (NUKE target definitions)
- C# code generation helpers are in `build/Helpers/CSharpBuilders.cs`
- JSON models are in `build/Helpers/QuicktypeModels.cs`
- Default target is `GenerateIconsClass` (runs automatically via `Main()`)
- Build system uses .NET 10.0