using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022151", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}