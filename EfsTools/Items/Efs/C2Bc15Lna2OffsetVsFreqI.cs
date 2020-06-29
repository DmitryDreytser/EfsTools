using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022089", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Lna2OffsetVsFreq
    {
        [FieldCount(48)]
        public sbyte[] Value
        {
            get;
        }
    }
}