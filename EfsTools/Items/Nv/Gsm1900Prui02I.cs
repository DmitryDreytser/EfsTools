using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2137)]
    [Attributes(9)]
    public sealed class Gsm1900Prui02
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}