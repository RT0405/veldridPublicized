﻿using System;

namespace Veldrid.OpenGL
{
    public class OpenGLSwapchain : Swapchain
    {
        public readonly OpenGLGraphicsDevice _gd;
        public readonly OpenGLSwapchainFramebuffer _framebuffer;
        public readonly Action<uint, uint> _resizeAction;
        public bool _disposed;

        public override Framebuffer Framebuffer => _framebuffer;
        public override bool SyncToVerticalBlank { get => _gd.SyncToVerticalBlank; set => _gd.SyncToVerticalBlank = value; }
        public override string Name { get; set; } = "OpenGL Context Swapchain";
        public override bool IsDisposed => _disposed;

        public OpenGLSwapchain(
            OpenGLGraphicsDevice gd,
            OpenGLSwapchainFramebuffer framebuffer,
            Action<uint, uint> resizeAction)
        {
            _gd = gd;
            _framebuffer = framebuffer;
            _resizeAction = resizeAction;
        }

        public override void Resize(uint width, uint height)
        {
            _framebuffer.Resize(width, height);
            _resizeAction?.Invoke(width, height);
        }

        public override void Dispose()
        {
            _disposed = true;
        }
    }
}
