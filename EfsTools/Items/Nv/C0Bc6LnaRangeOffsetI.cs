using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1225)]
    [Attributes(9)]
    public sealed class C0Bc6LnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}