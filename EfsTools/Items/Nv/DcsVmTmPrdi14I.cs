using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2417)]
    [Attributes(9)]
    public sealed class DcsVmTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}