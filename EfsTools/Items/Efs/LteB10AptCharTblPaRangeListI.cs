using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024107", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10AptCharTblPaRangeList
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}