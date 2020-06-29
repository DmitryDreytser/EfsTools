using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021488", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18AptCharTblTypeList
    {
        [FieldCount(4)]
        public uint[] Value { get; set; }
    }
}