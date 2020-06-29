using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023076", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19RxDelay
    {
        public short Value { get; set; }
    }
}