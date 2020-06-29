using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2301)]
    [Attributes(9)]
    public sealed class GsmVhThBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}