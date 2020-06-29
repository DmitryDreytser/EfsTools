using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022692", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40LnaRangeRiseFallNbModeIfreq
    {
        [FieldCount(12)]
        public byte[] Value { get; set; }
    }
}