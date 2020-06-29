using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023571", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}