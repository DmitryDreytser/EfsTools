using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020342", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18PaGainUpDownTime
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}