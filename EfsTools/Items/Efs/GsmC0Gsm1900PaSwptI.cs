using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024991", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1900PaSwpt
    {
        public GsmTxPaSwptDataType GsmPaSwptData { get; set; }
    }
}