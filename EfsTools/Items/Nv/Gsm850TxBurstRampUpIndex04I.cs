using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1110)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampUpIndex04
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}