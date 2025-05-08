# Global Azure 2025 Thailand - hello-ai Console App

## Prerequisites

- .NET 9.0 SDK or later installed on your machine ([Download here](https://dotnet.microsoft.com/download)).
- (Optional) Visual Studio Code for easier development and running tasks.
- Internet access to restore NuGet packages.

## How to Run

You can build and run the console app using the provided VS Code task:

1. Open this folder in Visual Studio Code.
2. Press `Cmd+Shift+B` (macOS) or `Ctrl+Shift+B` (Windows/Linux) to run the default build task.
   - Or, open the Command Palette (`Cmd+Shift+P`), select `Run Task`, and choose `1. Build and run hello-ai`.

This will execute:

```
dotnet run --project hello-ai/hello-ai.csproj
```

## NuGet Packages Used

The project uses the following NuGet packages:

- `Microsoft.Extensions.Configuration` (9.0.4)
- `Microsoft.Extensions.Configuration.Json` (9.0.4)
- `Microsoft.SemanticKernel` (1.48.0)

See `hello-ai/hello-ai.csproj` for details.