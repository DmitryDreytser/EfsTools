using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020430", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38C1LnaPhaseCtrl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}