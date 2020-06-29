using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2143)]
    [Attributes(9)]
    public sealed class Gsm1900Prui08
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}