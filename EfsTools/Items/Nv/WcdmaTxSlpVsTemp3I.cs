using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2016)]
    [Attributes(9)]
    public sealed class WcdmaTxSlpVsTemp3
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}