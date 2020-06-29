using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1180)]
    [Attributes(9)]
    public sealed class Wcdma1900TxSlpVsTemp1
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}