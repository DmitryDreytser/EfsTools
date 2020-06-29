using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024003", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6AptCharTblSmps3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}