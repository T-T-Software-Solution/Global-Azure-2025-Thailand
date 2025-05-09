# semantickernel-plugins Console App

## How to Run

You can build and run the console app using the provided VS Code task:

- Open this folder in Visual Studio Code.
- Press `Cmd+Shift+B` (macOS) or `Ctrl+Shift+B` (Windows/Linux) to run the default build task.
    - Or, open the Command Palette (`Cmd+Shift+P`), select `Run Task`
- Choose `2. Run semantickernel-plugins`. This will execute:

    ```
    dotnet run --project semantickernel-plugins/semantickernel-plugins.csproj
    ```

- Choose `3. Run Docker Compose Up`. This will execute:

    ```
    docker compose up --build
    ```

## NuGet Packages Used

The project uses the following NuGet packages (see `semantickernel-plugins/semantickernel-plugins.csproj` for details):

- `Microsoft.AspNetCore.Authentication.JwtBearer` (9.0.4)
- `Microsoft.AspNetCore.OpenApi` (9.0.3)
- `Microsoft.SemanticKernel` (1.49.0)
- `Serilog.AspNetCore` (9.0.0)
- `Serilog.Sinks.File` (7.0.0)
- `Swashbuckle.AspNetCore` (8.1.1)

## API Testing with Postman

A Postman collection is provided in the `postman` folder. You can use it to test the API endpoints easily:

- Open the `postman/Global-Azure-2025-Thailand.postman_collection.json` file in Postman.
- Follow the instructions in the collection to make requests to the API.