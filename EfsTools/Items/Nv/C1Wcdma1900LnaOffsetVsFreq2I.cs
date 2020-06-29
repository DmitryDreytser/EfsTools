using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3807)]
    [Attributes(9)]
    public sealed class C1Wcdma1900LnaOffsetVsFreq2
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}