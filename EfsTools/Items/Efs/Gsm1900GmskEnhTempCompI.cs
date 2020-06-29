using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024601", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900GmskEnhTempComp
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }
}