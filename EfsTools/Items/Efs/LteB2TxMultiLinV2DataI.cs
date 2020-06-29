using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023894", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB2TxMultiLinV2Data
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }
}