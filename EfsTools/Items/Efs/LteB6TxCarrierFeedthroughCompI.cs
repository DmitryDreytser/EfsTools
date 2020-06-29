using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023979", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6TxCarrierFeedthroughComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}