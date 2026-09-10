# Ayubo Life

[![AppVeyor build](https://ci.appveyor.com/api/projects/status/github/PasinduUmayanga/Ayubo_Life?svg=true)](https://ci.appveyor.com/project/PasinduUmayanga/Ayubo-Life)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512bd4)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows%20Forms-0078d4)](https://learn.microsoft.com/dotnet/desktop/winforms/)

Ayubo Life is a C# Windows Forms desktop application for managing the main workflows of a vehicle rental and hire service. The application groups the operational screens for login, registration, home navigation, renting, hiring, and payment into a single .NET Framework solution.

## Why This Project Matters

Small rental businesses need a simple desktop tool to keep common service tasks organized. Ayubo Life demonstrates how a Windows Forms application can model the day-to-day flow of a rental service while keeping the code approachable for learning, maintenance, and future extension.

## Main Features

- Administrator and user entry screens.
- Customer registration workflow.
- Vehicle rent and hire forms.
- Payment screen for service transactions.
- Shared navigation helpers for moving between forms.
- Image and icon assets for the desktop UI.

## Technology Stack

- C#
- Windows Forms
- .NET Framework 4.7.2
- Visual Studio solution and MSBuild project files
- AppVeyor continuous integration

## Important Code Areas

- `Ayubo Life.sln` - Visual Studio solution entry point.
- `Ayubo Life/Program.cs` - application startup.
- `Ayubo Life/Home.cs` - main navigation screen behavior.
- `Ayubo Life/Registration.cs` - customer registration form.
- `Ayubo Life/Rent.cs` - rent workflow form.
- `Ayubo Life/Hire.cs` - hire workflow form.
- `Ayubo Life/Paymnet.cs` - payment workflow form.
- `Ayubo Life/Navigation.cs` - shared navigation logic.

## Build

Open `Ayubo Life.sln` in Visual Studio 2022 or newer and build the solution with the `Release` configuration.

From a Developer PowerShell prompt:

```powershell
nuget restore "Ayubo Life.sln"
msbuild "Ayubo Life.sln" /p:Configuration=Release /p:Platform="Any CPU" /m
```

The AppVeyor pipeline in `appveyor.yml` restores NuGet packages, caches NuGet package folders, runs a NuGet vulnerability check for PackageReference projects, builds the solution, and publishes the Release output as a build artifact.

## Dependency And Vulnerability Notes

This project currently does not use `PackageReference` or `packages.config` NuGet dependencies, so there are no NuGet packages for the standard `dotnet list package --vulnerable --include-transitive` audit to inspect. The only non-framework assembly reference is `Microsoft.VisualBasic.PowerPacks.dll`, which is included in the repository and referenced by the Windows Forms designer code.

When NuGet dependencies are added later, prefer `PackageReference` so AppVeyor can audit direct and transitive package vulnerabilities during the build.

## Repository Structure

```text
Ayubo Life/      Windows Forms source code, resources, and project file
Images/          UI images and icons used by the application
appveyor.yml     AppVeyor CI build configuration
README.md        Project overview and build notes
```
