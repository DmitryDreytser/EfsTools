using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4054)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxCompVsFreq3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}