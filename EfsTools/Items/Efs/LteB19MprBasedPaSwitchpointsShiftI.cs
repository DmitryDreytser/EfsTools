using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023099", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19MprBasedPaSwitchpointsShift
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}