using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6549)]
    [Attributes(9)]
    public sealed class LteB7LnaPhaseCtrl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}