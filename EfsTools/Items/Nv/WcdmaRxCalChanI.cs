using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1972)]
    [Attributes(9)]
    public sealed class WcdmaRxCalChan
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}