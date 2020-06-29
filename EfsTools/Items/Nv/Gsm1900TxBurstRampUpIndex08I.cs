using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1070)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampUpIndex08
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}