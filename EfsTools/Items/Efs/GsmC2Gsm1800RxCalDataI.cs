using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024970", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1800RxCalData
    {
        public byte RxCalChanSize { get; set; }

        [FieldCount(16)]
        public short[] RxCalChanList { get; set; }

        [FieldCount(4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }
}