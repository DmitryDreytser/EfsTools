using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025082", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1800PowerLevels
    {
        [FieldCount(16)]
        public short[] GsmPowerLevels { get; set; }
    }
}