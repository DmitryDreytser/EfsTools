using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6566)]
    [Attributes(9)]
    public sealed class LteB7TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}