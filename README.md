# F# Quickstart

## Installation

### Linux installation

As of July 2016, you can install Mono 4.2.1 using apt on Ubuntu 16.04. Latest version of Mono is 4.4.1.

```
apt install mono-complete fsharp
```

### Mac installation

- Install [Visual Studio Code]()
- Add Mono `/bin` to PATH: `export PATH=$PATH:/Library/Frameworks/Mono.framework/Versions/Current/bin/`
- Go back to VS Code, press `Cmd+P` and enter: `ext install Ionide-fsharp`

Source: [Use F# on Mac](http://fsharp.org/use/mac/)

## Install Paket (dependency manager)

```
mdkir .paket
wget https://github.com/fsprojects/Paket/releases/download/3.35.3/paket.bootstrapper.exe -P .paket
mono .paket/packet.bootstrapper.exe
```

Commit `.paket/paket.bootstrapper.exe` into your repo and add `.paket/paket.exe` to your .gitignore file

Visit the [latest release page](https://github.com/fsprojects/Paket/releases/latest) to get the current link for `paket.bootstrapper.exe`.

Note: There is a way to install Paket globally, but this is not standard practice and involves compiling the binary yourself, which is not recommended.

## Run script

```
fsharpi hello.fsx
```

## Compiling and running

```
fsharpc -o hello.exe hello.fs
mono hello.exe
```

## Visual Studio Code

### Execute code in F# Interactive

Highlight the section of code you wish to send to FSI and then type `Alt+Enter`.

## Upgrading Mono

### Mac

Open Xamarin Studio and select `Check for Updates...` from the menu. Will probably take a long time, as it will download all dependencies before starting the installation process.

## Sources

- [Paket Installation Options](https://fsprojects.github.io/Paket/installation.html)
- ['mono' could not be spawned](https://github.com/ionide/ionide-atom-fsharp/issues/128)
