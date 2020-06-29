using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023759", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteC0SpursTable
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }
}