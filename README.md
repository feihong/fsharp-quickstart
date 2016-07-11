# F# Quickstart

## Linux installation

As of July 2016, you can install Mono 4.2.1 using apt on Ubuntu 16.04. Latest version of Mono is 4.4.1.

```
apt install mono-complete fsharp
```

## Mac installation

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
