using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5111)]
    [Attributes(9)]
    public sealed class Bc4P2RiseFallOff
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}