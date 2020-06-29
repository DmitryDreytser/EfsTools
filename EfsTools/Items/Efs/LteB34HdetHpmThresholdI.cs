using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024729", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB34HdetHpmThreshold
    {
        public ushort Enable { get; set; }


        public ushort Value { get; set; }
    }
}