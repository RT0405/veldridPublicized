﻿namespace Veldrid.OpenGL.NoAllocEntryList
{
    public struct NoAllocSetPipelineEntry
    {
        public readonly Tracked<Pipeline> Pipeline;

        public NoAllocSetPipelineEntry(Tracked<Pipeline> pipeline)
        {
            Pipeline = pipeline;
        }
    }
}