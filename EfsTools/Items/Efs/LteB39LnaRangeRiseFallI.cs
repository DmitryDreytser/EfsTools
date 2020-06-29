using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023564", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39LnaRangeRiseFall
    {
        [FieldCount(32)]
        public short[] Value { get; set; }
    }
}