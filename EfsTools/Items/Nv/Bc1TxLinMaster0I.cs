using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1627)]
    [Attributes(9)]
    public sealed class Bc1TxLinMaster0
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2
        {
            get;
        }
    }
}