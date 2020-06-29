using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023668", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB34TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}