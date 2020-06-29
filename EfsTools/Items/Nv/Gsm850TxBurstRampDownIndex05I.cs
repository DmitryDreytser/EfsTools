using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1126)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampDownIndex05
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}