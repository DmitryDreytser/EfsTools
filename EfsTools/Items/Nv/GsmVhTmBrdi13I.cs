using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2251)]
    [Attributes(9)]
    public sealed class GsmVhTmBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}