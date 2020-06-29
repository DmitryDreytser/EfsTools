using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021534", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm850SarBackOffLimitSlot4
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}