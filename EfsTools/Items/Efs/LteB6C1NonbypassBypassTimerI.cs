using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023968", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6C1NonbypassBypassTimer
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}