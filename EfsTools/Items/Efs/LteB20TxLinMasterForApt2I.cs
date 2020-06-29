using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021229", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20TxLinMasterForApt2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}