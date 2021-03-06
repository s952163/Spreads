// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using DirectFiles;
using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport("Kernel32", EntryPoint = "VirtualQuery", CharSet = CharSet.Unicode, SetLastError = true)]
        internal extern static UIntPtr VirtualQuery(SafeMemoryMappedViewHandle lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);
    }
}
