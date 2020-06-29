using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(501)]
    [Attributes(9)]
    public sealed class Ant2LnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}