using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6965)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLinMaster2
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}