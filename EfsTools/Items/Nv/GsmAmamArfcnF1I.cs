using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2758)]
    [Attributes(9)]
    public sealed class GsmAmamArfcnF1
    {
        public ushort Value { get; set; }
    }
}