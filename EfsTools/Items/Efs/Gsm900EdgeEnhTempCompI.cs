using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024603", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm900EdgeEnhTempComp
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }
}