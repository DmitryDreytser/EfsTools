using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5140)]
    [Attributes(9)]
    public sealed class Bc3HdrP3RiseFallOff
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}