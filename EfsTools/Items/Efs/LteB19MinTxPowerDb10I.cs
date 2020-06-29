using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024948", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19MinTxPowerDb10
    {
        public ushort Enable { get; set; }


        public short Value { get; set; }
    }
}