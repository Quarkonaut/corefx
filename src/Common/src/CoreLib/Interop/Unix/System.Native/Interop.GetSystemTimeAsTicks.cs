// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal unsafe partial class Sys
    {
        [DllImport(Interop.Libraries.SystemNative, EntryPoint = "SystemNative_GetSystemTimeAsTicks")]
        internal static extern long GetSystemTimeAsTicks();
    }
}
