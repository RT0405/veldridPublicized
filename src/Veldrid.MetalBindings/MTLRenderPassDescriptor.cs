using System;
using System.Runtime.InteropServices;
using static Veldrid.MetalBindings.ObjectiveCRuntime;

namespace Veldrid.MetalBindings
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLRenderPassDescriptor
    {
        public static readonly ObjCClass s_class = new ObjCClass(nameof(MTLRenderPassDescriptor));
        public readonly IntPtr NativePtr;
        public static MTLRenderPassDescriptor New() => s_class.AllocInit<MTLRenderPassDescriptor>();

        public MTLRenderPassColorAttachmentDescriptorArray colorAttachments
            => objc_msgSend<MTLRenderPassColorAttachmentDescriptorArray>(NativePtr, sel_colorAttachments);

        public MTLRenderPassDepthAttachmentDescriptor depthAttachment
            => objc_msgSend<MTLRenderPassDepthAttachmentDescriptor>(NativePtr, sel_depthAttachment);

        public MTLRenderPassStencilAttachmentDescriptor stencilAttachment
            => objc_msgSend<MTLRenderPassStencilAttachmentDescriptor>(NativePtr, sel_stencilAttachment);

        public static readonly Selector sel_colorAttachments = "colorAttachments";
        public static readonly Selector sel_depthAttachment = "depthAttachment";
        public static readonly Selector sel_stencilAttachment = "stencilAttachment";
    }
}