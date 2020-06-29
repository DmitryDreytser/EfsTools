using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025497", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB29C1RxGainVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}