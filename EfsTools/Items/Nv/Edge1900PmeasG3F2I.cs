using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5571)]
    [Attributes(9)]
    public sealed class Edge1900PmeasG3F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}