using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025473", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB28HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}