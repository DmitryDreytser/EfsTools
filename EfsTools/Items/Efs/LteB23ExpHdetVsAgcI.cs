using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024296", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23ExpHdetVsAgc
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}