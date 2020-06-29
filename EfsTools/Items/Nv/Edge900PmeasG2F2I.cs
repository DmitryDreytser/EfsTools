using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5546)]
    [Attributes(9)]
    public sealed class Edge900PmeasG2F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}