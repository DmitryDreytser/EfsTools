using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5110)]
    [Attributes(9)]
    public sealed class Bc3P2RiseFallOff
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}