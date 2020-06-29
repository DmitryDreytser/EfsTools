using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021886", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Lna3Offset
    {
        public short Value { get; set; }
    }
}