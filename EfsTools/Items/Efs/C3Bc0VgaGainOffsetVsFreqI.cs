using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023250", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc0VgaGainOffsetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}