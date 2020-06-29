using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024074", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10TxCompVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}