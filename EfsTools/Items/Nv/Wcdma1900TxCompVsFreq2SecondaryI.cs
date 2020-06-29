using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4972)]
    [Attributes(9)]
    public sealed class Wcdma1900TxCompVsFreq2Secondary
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}