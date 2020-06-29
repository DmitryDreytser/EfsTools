using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6602)]
    [Attributes(9)]
    public sealed class LteB17LnaPhaseCtrl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}