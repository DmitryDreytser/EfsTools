using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2381)]
    [Attributes(9)]
    public sealed class DcsVhTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}