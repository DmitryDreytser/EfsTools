using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022153", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12PaRiseFallThreshold
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}