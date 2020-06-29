using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2221)]
    [Attributes(9)]
    public sealed class DcsVlTmBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}