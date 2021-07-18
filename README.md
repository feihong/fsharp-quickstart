# F# Quickstart

## Install Mono and F#

### Mac installation

- Install [.NET Core SDK](https://dotnet.microsoft.com/download)
- Install [Visual Studio Code](https://code.visualstudio.com/download)
- Go back to VS Code, press `Cmd+P` and enter: `ext install Ionide-fsharp`

Source: [Use F# on Mac](http://fsharp.org/use/mac/)

### Linux installation

    apt install mono-complete fsharp

After installation, add `alias fsi='dotnet fsi'` to your `~/.bash_profile`.

## Paket (dependency manager)

Install Packet locally:

```
dotnet new tool-manifest
dotnet tool install Paket
```

Make sure to commit `.config/dotnet-tools.json`.

Source: [Paket installation](https://fsprojects.github.io/Paket/installation.html)

Create `paket.dependencies` file:

    dotnet paket init

Install dependencies:

    dotnet paket install

Add package to a project:

    dotnet add fsharp-quickstart.fsproj package Colorful.Console

## Run script

```
dotnet fsi hello.fsx
```

## Compiling and running

Create new project

    dotnet new console --language F#

Build

    dotnet build

Run

    dotnet run

## Links

- [Rosetta Code examples for F#](http://www.rosettacode.org/wiki/Category:F_Sharp)
- [Get started with F# with the .NET Core CLI](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line)
- [Interactive programming with F#](https://docs.microsoft.com/en-us/dotnet/fsharp/tools/fsharp-interactive/)
- [Discriminated Unions](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/discriminated-unions)
- [Modules](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/modules)

## Notes

I don't think Paket is all that useful, seems like just Nuget works fine.

### Visual Studio Code

To execute code in F# Interactive, highlight the section of code you wish to send to FSI and then type `Alt+Enter`.
