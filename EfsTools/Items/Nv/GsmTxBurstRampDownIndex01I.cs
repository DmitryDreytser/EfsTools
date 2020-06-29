using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(756)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex01
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}