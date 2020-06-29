using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6158)]
    [Attributes(9)]
    public sealed class BcxBlockTxLin0
    {
        [FieldCount(64)]
        public short[] Value
        {
            get;
        }
    }
}