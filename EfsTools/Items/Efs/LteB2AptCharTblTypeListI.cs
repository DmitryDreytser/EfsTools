using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021389", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB2AptCharTblTypeList
    {
        [FieldCount(4)]
        public uint[] Value { get; set; }
    }
}