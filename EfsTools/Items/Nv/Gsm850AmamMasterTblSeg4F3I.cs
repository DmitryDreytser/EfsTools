using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3097)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg4F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}