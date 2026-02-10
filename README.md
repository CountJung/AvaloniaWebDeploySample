# AvaloniaWebDeploySample

## Avalonia Controls Showcase for Web (WASM)

This project demonstrates various Avalonia UI controls running on WebAssembly (WASM). It serves as a comprehensive showcase of Avalonia's capabilities in web environments.

### Featured Controls

The showcase is organized by control categories:

#### 📝 Basic Input Controls
- **Button** - Interactive buttons with click counting, disabled states, and tooltips
- **TextBox** - Text input with live preview, multi-line support, and password masking
- **CheckBox** - Various checkbox states including three-state support
- **RadioButton** - Mutually exclusive option groups
- **ToggleSwitch** - On/off toggle controls

#### 🎯 Selection Controls
- **Slider** - Horizontal and vertical sliders with value display
- **ComboBox** - Dropdown selection controls
- **ListBox** - List selection with item binding
- **Numeric Input** - Numeric input with increment/decrement buttons (WASM-compatible)
- **DatePicker** - Date selection control (WASM-compatible)

#### 📊 Display Controls
- **TextBlock** - Text display with various styles (bold, italic, colored, formatted)
- **ProgressBar** - Determinate and indeterminate progress indicators
- **Badges/Labels** - Custom styled badge components

#### 📐 Layout Controls
- **StackPanel** - Horizontal and vertical stacking
- **Grid** - Row/column-based layouts
- **WrapPanel** - Wrapping content layouts
- **Border** - Various border styles and backgrounds

#### 🧭 Navigation Controls
- **TabControl** - Tabbed content navigation
- **Expander** - Collapsible content sections

#### 📋 Data Display Controls
- **TreeView** - Hierarchical data display
- **Data Tables** - Grid-based table layouts

---

## Quick Start - Use This Template

Those who want to quick use → Just use this template by clicking the "Use this template" button above!

## Quick Guide

### Set up your project and upload to GitHub:

1. Go to **Settings → Actions → General**: Make sure workflow permission has read and write
2. Edit your deployment action flow yml (name is free - name it as you wish)
3. Check this project's yml and rename it to your project
4. Go to **Settings → Pages**: Change branch to `gh-pages`
5. Enjoy your WASM Avalonia!

## Technologies Used

- **Avalonia UI 11.x** - Cross-platform .NET UI framework
- **WebAssembly (WASM)** - Browser-based execution
- **CommunityToolkit.Mvvm** - MVVM support library
- **GitHub Pages** - Static web hosting

## WASM Compatibility Notes

This showcase has been optimized for WebAssembly deployment:
- Uses `DatePicker` instead of `Calendar` for better WASM support
- Uses custom numeric input controls instead of `NumericUpDown` for better WASM compatibility
- All other controls are fully supported in WASM environments

## To Do

- [ ] Find out more clean Action: ex (publish/wwwroot → publish) 
