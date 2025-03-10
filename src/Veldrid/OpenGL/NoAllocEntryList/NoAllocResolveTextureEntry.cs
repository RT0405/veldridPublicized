﻿namespace Veldrid.OpenGL.NoAllocEntryList
{
    public struct NoAllocResolveTextureEntry
    {
        public readonly Tracked<Texture> Source;
        public readonly Tracked<Texture> Destination;

        public NoAllocResolveTextureEntry(Tracked<Texture> source, Tracked<Texture> destination)
        {
            Source = source;
            Destination = destination;
        }
    }
}