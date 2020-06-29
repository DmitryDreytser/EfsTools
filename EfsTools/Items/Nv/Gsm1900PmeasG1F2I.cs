using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5352)]
    [Attributes(9)]
    public sealed class Gsm1900PmeasG1F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}