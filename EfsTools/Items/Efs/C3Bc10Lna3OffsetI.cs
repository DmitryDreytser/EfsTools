using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023340", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc10Lna3Offset
    {
        public short Value { get; set; }
    }
}