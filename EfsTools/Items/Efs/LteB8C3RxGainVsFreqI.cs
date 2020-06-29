using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025174", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB8C3RxGainVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}