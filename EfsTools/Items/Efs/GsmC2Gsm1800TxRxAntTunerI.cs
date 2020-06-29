using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025098", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1800TxRxAntTuner
    {
        public RfcommonAntTunerDataType AntTunerRx { get; set; }


        public RfcommonAntTunerDataType AntTunerTx { get; set; }
    }
}