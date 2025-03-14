this simply exists because [Assembly Publicizer](https://github.com/CabbageCrow/AssemblyPublicizer) wasn't working on the main veldrid dll for some reason

# Veldrid

Veldrid is a cross-platform, graphics API-agnostic rendering and compute library for .NET. It provides a powerful, unified interface to a system's GPU and includes more advanced features than any other .NET library. Unlike other platform- or vendor-specific technologies, Veldrid can be used to create high-performance 3D applications that are truly portable.

___As of February 2023, I'm no longer able to publicly share updates to Veldrid and related libraries. If you're an active user or have contributed improvements in the past, feel free to reach out or join the [Discord server](https://discord.gg/s5EvvWJ) for more information about the status of Veldrid.___

Supported backends:

* Direct3D 11
* Vulkan
* Metal
* OpenGL 3
* OpenGL ES 3

[Veldrid documentation site](https://mellinoe.github.io/veldrid-docs/)

Join the Discord server:

[![Join the Discord server](https://img.shields.io/discord/757148685321895936?label=Veldrid)](https://discord.gg/s5EvvWJ)

Veldrid is available on NuGet:

[![NuGet](https://img.shields.io/nuget/v/Veldrid.svg)](https://www.nuget.org/packages/Veldrid)

Pre-release versions of Veldrid are also available from MyGet: https://www.myget.org/feed/mellinoe/package/nuget/Veldrid

![Sponza](https://i.imgur.com/p6juqm9.jpg)

### Build instructions

Veldrid  uses the standard .NET Core tooling. [Install the tools](https://www.microsoft.com/net/download/core) and build normally (`dotnet build`).

Run the NeoDemo program to see a quick demonstration of the rendering capabilities of the library.
