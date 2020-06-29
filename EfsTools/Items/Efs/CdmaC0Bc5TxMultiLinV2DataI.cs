using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023880", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc5TxMultiLinV2Data
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }
}