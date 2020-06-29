using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2933)]
    [Attributes(9)]
    public sealed class Wcdma1800PaCompensateUpWithDvs
    {
        [FieldCount(10)]
        public short[] Value { get; set; }
    }
}