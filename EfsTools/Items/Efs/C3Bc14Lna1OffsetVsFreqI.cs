using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023354", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14Lna1OffsetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}