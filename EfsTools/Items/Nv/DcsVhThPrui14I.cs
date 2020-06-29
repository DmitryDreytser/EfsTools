using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2486)]
    [Attributes(9)]
    public sealed class DcsVhThPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}