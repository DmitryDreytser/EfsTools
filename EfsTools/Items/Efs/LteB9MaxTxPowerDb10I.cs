using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023535", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB9MaxTxPowerDb10
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}