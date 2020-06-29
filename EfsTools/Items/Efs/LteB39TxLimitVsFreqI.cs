using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023599", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39TxLimitVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}