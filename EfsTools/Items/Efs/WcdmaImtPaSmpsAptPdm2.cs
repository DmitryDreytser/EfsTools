using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020626", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaImtPaSmpsAptPdm2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}