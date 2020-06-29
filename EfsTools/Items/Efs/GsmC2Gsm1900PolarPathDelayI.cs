using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025075", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1900PolarPathDelay
    {
        public short PolarPathDelay { get; set; }
    }
}