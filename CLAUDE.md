# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a MudBlazor icon library that integrates Phosphor Icons into MudBlazor components. The project consists of:
- A Blazor component library (`MudBlazor.PhosphorIcons`) that provides icon components
- A demo Blazor web application (`Phosphor`) showcasing the icons
- A NUKE build system that generates icon classes from Phosphor font files
- Unit tests using NUnit

## Build System

The project uses NUKE for build automation. Icon classes are generated from Phosphor font files located in the `input/fonts` directory.

### Common Commands

```bash
# Generate Icons.cs file from font definitions
./build.ps1 GenerateIconsClass  # Windows PowerShell
./build.sh GenerateIconsClass   # macOS/Linux
build.cmd GenerateIconsClass    # Windows CMD

# Build the solution
dotnet build

# Run tests
dotnet test

# Run the demo application
dotnet run --project Phosphor/Phosphor.csproj
```

## Architecture

### Icon Generation Pipeline
1. **Input**: Phosphor font files and metadata in `input/fonts/{style}/selection.json`
2. **Build Process**: NUKE build reads selection.json files and generates C# constants
3. **Output**: Generated `Icons.cs` file in `output/` directory
4. **Integration**: Icons.cs is linked into MudBlazor.PhosphorIcons project

### Component Architecture
- **SuperIcon Base Class**: Abstract base class extending MudIcon that handles icon weight selection
- **Super Icon Components**: Specialized icon components (SuperFileIcon, SuperBatteryIcon, etc.) that provide semantic icon variations
- **IconWeight Enum**: Supports Regular, Thin, Light, Bold, Fill, and Duotone styles
- **Icon References**: Generated static classes (PhosphorRegular, PhosphorThin, etc.) containing CSS class constants

### Key Design Patterns
1. **Pattern Matching**: Super icon components use switch expressions to map (Weight, Value) tuples to appropriate icon CSS classes
2. **Code Generation**: Build system generates icon constants from font metadata rather than hand-coding thousands of icon references
3. **Component Composition**: Icons inherit from MudBlazor's MudIcon for seamless integration

## Development Workflow

When adding new super icon components:
1. Create a new class inheriting from `SuperIcon` in `MudBlazor.PhosphorIcons/Components/`
2. Define an enum for the icon variations
3. Implement `GetIcon()` using pattern matching on Weight and Value parameters
4. Add a demo component in `Phosphor/Components/SuperIcons/`

When updating Phosphor fonts:
1. Replace font files in `input/fonts/` directory
2. Run the GenerateIconsClass target to regenerate Icons.cs
3. Test that existing super icons still work correctly

## Testing

- Unit tests are in the `Phosphor.UnitTests` project using NUnit
- Test individual icon name parsing and generation logic
- Run tests with `dotnet test`