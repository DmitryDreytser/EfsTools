using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2054)]
    [Attributes(9)]
    public sealed class Wcdma1900PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}