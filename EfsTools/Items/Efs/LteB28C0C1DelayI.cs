using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025446", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB28C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}