using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(766)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex11
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}