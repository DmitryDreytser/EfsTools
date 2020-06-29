using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021647", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB41TxCompVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}