using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5426)]
    [Attributes(9)]
    public sealed class Gsm1800PmeasG3F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}