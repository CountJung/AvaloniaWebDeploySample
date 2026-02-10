# GitHub Copilot Instructions

## Repository Overview

This is an **Avalonia UI WebAssembly (WASM) showcase project** demonstrating various Avalonia controls running in a web browser. The project serves as a template for deploying Avalonia applications to GitHub Pages.

## Project Structure

```
AvaloniaWebDeploySample/
├── AvaloniaWebDeploySample/          # Core library project (shared code)
│   ├── ViewModels/                   # MVVM ViewModels
│   ├── Views/                        # AXAML views and code-behind
│   ├── Assets/                       # Images, fonts, and resources
│   └── App.axaml                     # Application entry point
├── AvaloniaWebDeploySample.Browser/  # Browser/WASM entry point
├── AvaloniaWebDeploySample.Desktop/  # Desktop entry point
└── .github/workflows/                # CI/CD workflows
```

## Technology Stack

- **Avalonia UI 11.1.0** - Cross-platform .NET UI framework
- **.NET 8.0** - Target framework
- **WebAssembly (WASM)** - Browser execution via `net8.0-browser` target
- **CommunityToolkit.Mvvm 8.2.0** - MVVM implementation (source generators)
- **GitHub Pages** - Deployment platform

## Coding Standards

### Language Features
- **C# Language Version**: Latest
- **Nullable Reference Types**: Enabled - Always use nullable annotations appropriately
- **Unsafe Code**: Allowed (required for WASM interop)

### MVVM Patterns
- Use `CommunityToolkit.Mvvm` source generators for properties and commands
- ViewModels inherit from `ViewModelBase`
- Use `[ObservableProperty]` for bindable properties
- Use `[RelayCommand]` for commands
- Implement partial methods (`OnPropertyChanged`) for property change logic

### File Naming
- AXAML files: Use `.axaml` extension (Avalonia XAML)
- Code-behind: Match AXAML file name with `.axaml.cs` extension
- ViewModels: Suffix with `ViewModel` (e.g., `MainViewModel.cs`)
- Views: Suffix with `View` or `Window` (e.g., `MainView.axaml`)

### Code Style
- Use nullable reference types correctly (`string?` for nullable strings)
- Use collection initializers for ObservableCollections
- Follow standard C# naming conventions (PascalCase for public, camelCase for private)
- Private fields use underscore prefix when needed (e.g., `_clickCount`)

## Build & Deployment

### Building the Project
```bash
# Restore dependencies
dotnet restore

# Build the browser project
dotnet build AvaloniaWebDeploySample.Browser/AvaloniaWebDeploySample.Browser.csproj

# Publish for WASM
dotnet publish AvaloniaWebDeploySample.Browser/AvaloniaWebDeploySample.Browser.csproj -c Release
```

### WASM Workload
The project requires the `wasm-tools` workload:
```bash
dotnet workload install wasm-tools
```

### GitHub Pages Deployment
- Deployment is automated via `.github/workflows/deploy.yml`
- Triggers on push to `master` branch or manual dispatch
- Output is deployed to `gh-pages` branch
- Base path is adjusted for GitHub Pages subdirectory

## Project-Specific Guidelines

### Adding New Controls
1. Add properties to `MainViewModel.cs` using `[ObservableProperty]` attribute
2. Create UI in `MainView.axaml` using Avalonia XAML syntax
3. Use data binding to connect ViewModel properties to UI controls
4. Group related controls in sections with appropriate headers

### Working with Avalonia XAML
- Use Avalonia's control library (not WPF/UWP controls)
- Fluent Theme is enabled by default
- Binding syntax: `{Binding PropertyName}` or `{Binding Path=PropertyName}`
- Command binding: `Command="{Binding CommandName}"`
- Resources defined in `App.axaml` are globally available

### Dependencies
- Avoid adding unnecessary dependencies
- Use built-in Avalonia controls when possible
- If adding NuGet packages, ensure they are compatible with:
  - .NET 8.0
  - WebAssembly/Browser environment
  - Avalonia 11.x

### Common Patterns in This Project
```csharp
// Observable property with change notification
[ObservableProperty]
private string _propertyName = "default";

// Partial method for property changes
partial void OnPropertyNameChanged(string value)
{
    // React to property change
}

// Relay command
[RelayCommand]
private void DoSomething()
{
    // Command logic
}

// Collection initialization
public ObservableCollection<string> Items { get; } = new()
{
    "Item 1",
    "Item 2"
};
```

## Testing
- Currently no automated tests are configured
- Manual testing via browser after deployment
- Test WASM functionality in the browser at the GitHub Pages URL

## Known Limitations
- WebAssembly has some platform limitations compared to native desktop
- Not all .NET APIs are available in the browser environment
- File system access is restricted in WASM
- Performance characteristics differ from native platforms

## When Making Changes
- Preserve the showcase/demo nature of the project
- Maintain MVVM separation (don't put logic in code-behind)
- Test changes locally with `dotnet run` on Desktop project if possible
- Verify WASM compatibility for any new code
- Update README.md if adding new control demonstrations
- Keep the deployment workflow functional for GitHub Pages

## Resources
- [Avalonia Documentation](https://docs.avaloniaui.net/)
- [CommunityToolkit.Mvvm Docs](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/)
- [.NET WebAssembly](https://learn.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/webassembly)
