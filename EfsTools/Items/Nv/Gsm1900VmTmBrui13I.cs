using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2243)]
    [Attributes(9)]
    public sealed class Gsm1900VmTmBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}