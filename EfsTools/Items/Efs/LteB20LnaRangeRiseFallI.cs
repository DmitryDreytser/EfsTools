using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020145", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20LnaRangeRiseFall
    {
        [FieldCount(32)]
        public short[] Value { get; set; }
    }
}