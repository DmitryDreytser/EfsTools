using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024275", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23TxRotAnglePaState
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}