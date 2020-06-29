using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6060)]
    [Attributes(9)]
    public sealed class BcxBlock1TxLinMaster3
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }
}