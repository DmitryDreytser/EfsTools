using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4979)]
    [Attributes(9)]
    public sealed class Wcdma800TxCompVsFreqSecPdmList
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}