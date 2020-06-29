using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4810)]
    [Attributes(9)]
    public sealed class Bc4TxPdm3
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}