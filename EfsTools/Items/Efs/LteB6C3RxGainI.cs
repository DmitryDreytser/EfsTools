using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025278", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6C3RxGain
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}