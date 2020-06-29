using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2522)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg2F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}