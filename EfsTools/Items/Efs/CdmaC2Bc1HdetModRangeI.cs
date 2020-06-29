using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024796", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1HdetModRange
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [FieldCount(8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }
}