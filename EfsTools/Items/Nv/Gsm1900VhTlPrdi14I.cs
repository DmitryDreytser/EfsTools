using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2387)]
    [Attributes(9)]
    public sealed class Gsm1900VhTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}