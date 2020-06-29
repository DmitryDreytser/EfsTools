using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4006)]
    [Attributes(9)]
    public sealed class WcdmaBc4LnaOffsetVsFreq2
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}