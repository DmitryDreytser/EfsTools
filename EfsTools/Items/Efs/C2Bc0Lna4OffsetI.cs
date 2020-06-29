using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021735", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Lna4Offset
    {
        public short Value { get; set; }
    }
}