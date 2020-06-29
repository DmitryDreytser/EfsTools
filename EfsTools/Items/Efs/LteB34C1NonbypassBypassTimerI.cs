using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023686", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB34C1NonbypassBypassTimer
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}