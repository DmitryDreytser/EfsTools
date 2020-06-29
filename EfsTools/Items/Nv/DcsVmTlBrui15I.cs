using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2181)]
    [Attributes(9)]
    public sealed class DcsVmTlBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}