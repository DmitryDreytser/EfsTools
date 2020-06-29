using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4035)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}