using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4605)]
    [Attributes(9)]
    public sealed class C1BcxBlockLna4OffsetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}