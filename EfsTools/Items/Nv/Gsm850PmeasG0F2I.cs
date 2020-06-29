using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5327)]
    [Attributes(9)]
    public sealed class Gsm850PmeasG0F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}