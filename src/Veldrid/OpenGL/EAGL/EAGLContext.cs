using System;
using System.Runtime.InteropServices;
using Veldrid.MetalBindings;
using static Veldrid.MetalBindings.ObjectiveCRuntime;

namespace Veldrid.OpenGL.EAGL
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EAGLContext
    {
        public static ObjCClass s_class = new ObjCClass("EAGLContext");

        public readonly IntPtr NativePtr;

        public Bool8 renderBufferStorage(UIntPtr target, IntPtr drawable)
            => bool8_objc_msgSend(NativePtr, sel_renderBufferStorage, target, drawable);

        public Bool8 presentRenderBuffer(UIntPtr target)
            => bool8_objc_msgSend(NativePtr, sel_presentRenderBuffer, target);

        public static EAGLContext Create(EAGLRenderingAPI api)
        {
            EAGLContext ret = s_class.Alloc<EAGLContext>();
            objc_msgSend(ret.NativePtr, sel_initWithAPI, (uint)api);
            return ret;
        }

        public static Bool8 setCurrentContext(IntPtr context)
            => bool8_objc_msgSend(s_class, sel_setCurrentContext, context);

        public static EAGLContext currentContext
            => objc_msgSend<EAGLContext>(s_class, sel_currentContext);

        public void Release() => release(NativePtr);

        public static readonly Selector sel_initWithAPI = "initWithAPI:";
        public static readonly Selector sel_setCurrentContext = "setCurrentContext:";
        public static readonly Selector sel_renderBufferStorage = "renderbufferStorage:fromDrawable:";
        public static readonly Selector sel_presentRenderBuffer = "presentRenderbuffer:";
        public static readonly Selector sel_currentContext = "currentContext";
    }

    public enum EAGLRenderingAPI
    {
        OpenGLES1 = 1,
        OpenGLES2 = 2,
        OpenGLES3 = 3,
    }
}