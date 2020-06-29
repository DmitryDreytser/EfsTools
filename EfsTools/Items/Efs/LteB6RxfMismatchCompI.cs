using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023935", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}