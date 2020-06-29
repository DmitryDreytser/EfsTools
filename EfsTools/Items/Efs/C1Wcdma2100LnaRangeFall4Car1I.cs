using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020930", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma2100LnaRangeFall4Car1
    {
        public short Value { get; set; }
    }
}