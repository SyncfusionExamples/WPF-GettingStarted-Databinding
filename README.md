# WPF Domain UpDown (SfDomainUpDown) – Getting Started and Data Binding

This sample shows how to use the Syncfusion WPF SfDomainUpDown control to build intuitive, keyboard-friendly pickers for discrete values with full MVVM-friendly data binding. It demonstrates binding to collections, selecting and editing values, wrap/spin behavior, templates for complex items, theming, and best practices for a production-ready experience.

## Features
- Bind to IEnumerable/ObservableCollection for dynamic item lists
- Select values via spin buttons, keyboard, and mouse wheel
- Optional text editing with parsing and read-only modes
- Wrap behavior when spinning past the first/last item
- DisplayMemberPath/ItemTemplate for rich item visualization
- SelectedItem/SelectedIndex two-way binding for MVVM
- Watermark/placeholder and null-value handling
- Theming via Syncfusion built-in visual styles

## Getting Started
1. Create or open a WPF project in Visual Studio (e.g., SfDomainUpDown-GettingStarted).
2. Install the NuGet package: Syncfusion.SfInput.WPF.
   - In Visual Studio: Tools > NuGet Package Manager > Manage NuGet Packages for Solution… > Browse “Syncfusion.SfInput.WPF” > Install.
3. Add the Syncfusion XML namespace in your XAML root:
   - xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
4. Place an SfDomainUpDown in your Window/Page and bind it to your ViewModel:
   - ItemsSource: collection of items to display
   - SelectedItem or SelectedIndex: current selection
   - DisplayMemberPath or ItemTemplate: how items are shown
   - Optional behavior: IsWrapEnabled, IsEditable, SpinButtonAlignment, Watermark
5. Apply a theme if desired using Syncfusion SkinStorage (VisualStyle):
   - syncfusion:SkinStorage.VisualStyle="Office2019Colorful" (or any preferred theme)

## Usage Tips
- For complex objects, prefer ItemTemplate or DisplayMemberPath for clear display.
- Use two-way binding on SelectedItem/SelectedIndex to keep the ViewModel in sync.
- Enable IsWrapEnabled for continuous cycling through items.
- Set IsEditable to allow users to type values and handle parsing/validation as needed.
- Align spin buttons via SpinButtonAlignment to suit your layout.
- Provide a Watermark to guide users when no value is selected.
- Handle SelectionChanged to react to user choices (e.g., filtering or commands).

## About the Sample
This sample focuses on the essentials for data binding with SfDomainUpDown: wiring ItemsSource, choosing a selection model, configuring spin and wrap behavior, and theming. Extend it by adding validation rules, custom parsing, commands, and richer item templates to match your application’s workflow and branding.

