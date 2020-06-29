using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022270", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB24PaSmpsGstTemp
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}