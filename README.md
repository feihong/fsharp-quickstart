# F# Quickstart

## Installation

### Linux installation

As of July 2016, you can install Mono 4.2.1 using apt on Ubuntu 16.04. Latest version of Mono is 4.4.1.

```
apt install mono-complete fsharp
```

### Mac installation

The easiest thing to do is just install [Xamarin Studio](http://xamarin.com/studio).

## Install Paket (dependency manager)

```
git clone git@github.com:fsprojects/Paket
cd Paket
./build.sh
sudo ./install.sh
```

## Run script

```
fsharpi hello.fsx
```

## Compiling and running

```
fsharpc -o hello.exe hello.fs
mono hello.exe
```

## Editor

Open Atom and install the `ionide-fsharp` and `ionide-paket` packages.

On Mac, make sure that the Mono Path field is set to `/usr/local/bin`, then restart Atom.

## Upgrading Mono

### Mac

Open Xamarin Studio and select `Check for Updates...` from the menu. Will probably take a long time, as it will download all dependencies before starting the installation process.

## Sources

- [Paket Installation Options](https://fsprojects.github.io/Paket/installation.html)
- ['mono' could not be spawned](https://github.com/ionide/ionide-atom-fsharp/issues/128)
