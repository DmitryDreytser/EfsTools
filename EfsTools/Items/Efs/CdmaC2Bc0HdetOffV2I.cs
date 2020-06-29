using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021771", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0HdetOffV2
    {
        public ushort Value { get; set; }
    }
}