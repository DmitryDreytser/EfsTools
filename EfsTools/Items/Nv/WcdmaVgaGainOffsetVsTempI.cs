using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(858)]
    [Attributes(9)]
    public sealed class WcdmaVgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}