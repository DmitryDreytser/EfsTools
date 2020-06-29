using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1816)]
    [Attributes(9)]
    public sealed class Wcdma800VgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}