using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6641)]
    [Attributes(9)]
    public sealed class LteB17C1RxGain
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}