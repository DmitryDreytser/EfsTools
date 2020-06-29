using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1952)]
    [Attributes(9)]
    public sealed class RfAntselGsm1900Tx
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}