using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6110)]
    [Attributes(9)]
    public sealed class C1BcxBlock1Lna4OffsetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}