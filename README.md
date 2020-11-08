# F# Quickstart

## Install Mono and F#

### Linux installation

    apt install mono-complete fsharp

### Mac installation

- Install [.NET Core SDK](https://dotnet.microsoft.com/download)
- Install [Visual Studio Code](https://code.visualstudio.com/download)
- Go back to VS Code, press `Cmd+P` and enter: `ext install Ionide-fsharp`

Source: [Use F# on Mac](http://fsharp.org/use/mac/)

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

## Visual Studio Code

### Execute code in F# Interactive

Highlight the section of code you wish to send to FSI and then type `Alt+Enter`.

## Sources

- [Get started with F# with the .NET Core CLI](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line)
