using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022491", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB5TxLinMaster2ChanRange1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}