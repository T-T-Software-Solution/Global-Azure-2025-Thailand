# semantickernel-plugins Console App

## How to Run

You can build and run the console app using the provided VS Code task:

1. Open this folder in Visual Studio Code.
2. Press `Cmd+Shift+B` (macOS) or `Ctrl+Shift+B` (Windows/Linux) to run the default build task.
    - Or, open the Command Palette (`Cmd+Shift+P`), select `Run Task`, and choose `2. Run semantickernel-plugins`.

This will execute:

```
dotnet run --project semantickernel-plugins/semantickernel-plugins.csproj
```

## NuGet Packages Used

The project uses the following NuGet packages:

- `Microsoft.Extensions.Configuration` (9.0.4)
- `Microsoft.Extensions.Configuration.Json` (9.0.4)
- `Microsoft.SemanticKernel` (1.48.0)

See `semantickernel-plugins/semantickernel-plugins.csproj` for details.