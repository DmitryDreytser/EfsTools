using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2983)]
    [Attributes(9)]
    public sealed class Wcdma1900UtranTxLimVsTempOffset
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}