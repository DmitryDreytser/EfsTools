using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2446)]
    [Attributes(9)]
    public sealed class GsmVlThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}