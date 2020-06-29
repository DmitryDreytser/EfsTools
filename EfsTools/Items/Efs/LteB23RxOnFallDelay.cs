using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024348", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23RxOnFallDelay
    {
        public ushort Value { get; set; }
    }
}