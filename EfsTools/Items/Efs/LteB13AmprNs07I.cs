using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020140", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB13AmprNs07
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}