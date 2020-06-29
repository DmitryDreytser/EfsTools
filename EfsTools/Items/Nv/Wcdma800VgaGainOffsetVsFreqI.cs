using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1815)]
    [Attributes(9)]
    public sealed class Wcdma800VgaGainOffsetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}