using System;
using System.Runtime.InteropServices;

namespace Veldrid.MetalBindings
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MTLBuffer
    {
        public readonly IntPtr NativePtr;
        public MTLBuffer(IntPtr ptr) => NativePtr = ptr;
        public bool IsNull => NativePtr == IntPtr.Zero;

        public void* contents() => ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_contents).ToPointer();

        public UIntPtr length => ObjectiveCRuntime.UIntPtr_objc_msgSend(NativePtr, sel_length);

        public void didModifyRange(NSRange range)
            => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_didModifyRange, range);

        public void addDebugMarker(NSString marker, NSRange range)
            => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_addDebugMarker, marker.NativePtr, range);

        public void removeAllDebugMarkers()
            => ObjectiveCRuntime.objc_msgSend(NativePtr, sel_removeAllDebugMarkers);

        public static readonly Selector sel_contents = "contents";
        public static readonly Selector sel_length = "length";
        public static readonly Selector sel_didModifyRange = "didModifyRange:";
        public static readonly Selector sel_addDebugMarker = "addDebugMarker:range:";
        public static readonly Selector sel_removeAllDebugMarkers = "removeAllDebugMarkers";
    }
}