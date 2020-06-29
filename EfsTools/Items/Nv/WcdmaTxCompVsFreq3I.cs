using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2012)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreq3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}