using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1001)]
    [Attributes(9)]
    public sealed class C1GpsDaccQaccum0
    {
        public byte Value { get; set; }
    }
}