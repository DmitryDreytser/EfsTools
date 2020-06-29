using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021473", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB13AptCharTblSmps0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}