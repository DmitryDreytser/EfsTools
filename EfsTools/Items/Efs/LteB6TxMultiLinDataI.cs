using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024007", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6TxMultiLinData
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }
}