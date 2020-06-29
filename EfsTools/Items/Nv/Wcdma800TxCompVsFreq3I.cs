using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2058)]
    [Attributes(9)]
    public sealed class Wcdma800TxCompVsFreq3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}