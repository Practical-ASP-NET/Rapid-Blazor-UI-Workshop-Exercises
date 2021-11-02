# Get up and running

You'll find two folders in this repository: a .NET 5 and a .NET 6 version of the exercices.

If you want to use .NET 6 you'll need either:

a) Visual Studio 2022 ([download here](https://visualstudio.microsoft.com/vs/preview/))
b) or the .NET 6 SDK plus your favourite editor ([download the SDK here](https://dotnet.microsoft.com/download/dotnet/6.0))

**AFAIK it isn't possible to use Visual Studio 2019 to work with a .NET 6 project.**

## Make sure you have Node installed

The project(s) have been configured to use Tailwind CSS and therefore require Node as part of the build process.

If you don't have Node installed you'll see a message asking you to do so when you attempt to build/run either of the projects.

You can [download and install Node.js from here](https://nodejs.org).

## Using Visual Studio 2022

You should be able to open BlazorWorkshopNet6\BlazorUIWorkshop.csproj in VS2022 without any issues.

From there you can launch the project (run it without debugging to enable the new VS2022 Hot Reload to automatically reflect your changes in the browser).

## Using another editor and the .NET 6 SDK

So long as you have a version of the .NET 6 SDK installed you can also run the .NET 6 project from the command line/terminal.

``` powershell
CD BlazorWorkshopNet6
dotnet watch run
```

This launches the project in 'watch' mode, meaning you should automatically see your changes reflected in the browser.

## Using Visual Studio 2019

You'll need to use the .NET 5 version of the project.

You should be able to open BlazorUIWorkshopNet5\BlazorUIWorkshopNet5.csproj and launch the application from VS.

See you in the workshop!