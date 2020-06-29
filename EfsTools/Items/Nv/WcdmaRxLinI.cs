using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(514)]
    [Attributes(9)]
    public sealed class WcdmaRxLin
    {
        [FieldCount(17)]
        public ushort[] Value { get; set; }
    }
}