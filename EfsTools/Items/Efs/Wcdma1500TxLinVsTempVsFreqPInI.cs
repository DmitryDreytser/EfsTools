using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025623", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLinVsTempVsFreqPIn
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }
}