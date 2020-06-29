using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020158", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20TxRotAnglePaState
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}