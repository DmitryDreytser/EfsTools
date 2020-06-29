using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021859", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc4TxLin3
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}