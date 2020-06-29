using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1106)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampUpIndex00
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}