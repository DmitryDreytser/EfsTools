using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3841)]
    [Attributes(9)]
    public sealed class C1Wcdma800LnaOffsetVsFreq4
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}