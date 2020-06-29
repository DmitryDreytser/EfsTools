using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1095)]
    [Attributes(9)]
    public sealed class Gsm1900TxFreqComp
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}