using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2430)]
    [Attributes(9)]
    public sealed class GsmVhTmPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}