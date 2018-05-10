# F# Quickstart

## Install Mono and F#

### Linux installation

    apt install mono-complete fsharp

### Mac installation

- Install [Mono using Mac package](http://www.mono-project.com/download/stable/) (the version in Homebrew is older)
- Install [Visual Studio Code](https://code.visualstudio.com/download)
- Go back to VS Code, press `Cmd+P` and enter: `ext install Ionide-fsharp`

Source: [Use F# on Mac](http://fsharp.org/use/mac/)

## Install Paket (dependency manager)

```
mkdir .paket
wget https://github.com/fsprojects/Paket/releases/download/5.161.3/paket.bootstrapper.exe -O .paket/paket.exe
mono .paket/paket.exe install
```

Commit `.paket/paket.exe` into your repo.

Visit the [latest release page](https://github.com/fsprojects/Paket/releases/latest) to get the current link for `paket.bootstrapper.exe`.

Note: There is a way to install Paket globally, but this is not standard practice and involves compiling the binary yourself, which is not recommended.

Source: [Paket Manual Setup](https://fsprojects.github.io/Paket/getting-started.html#Manual-setup)

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

## Sources

- [Paket Installation Options](https://fsprojects.github.io/Paket/installation.html)
- ['mono' could not be spawned](https://github.com/ionide/ionide-atom-fsharp/issues/128)
