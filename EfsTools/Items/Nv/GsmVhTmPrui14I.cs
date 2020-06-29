using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2425)]
    [Attributes(9)]
    public sealed class GsmVhTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}