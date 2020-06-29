using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1066)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampUpIndex04
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}