using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021549", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900SarBackOffLimitSlot4
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}