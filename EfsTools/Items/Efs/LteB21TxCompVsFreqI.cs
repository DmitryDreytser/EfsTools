using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023171", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21TxCompVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}