using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1075)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampUpIndex13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}