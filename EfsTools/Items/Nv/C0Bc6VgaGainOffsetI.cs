using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1255)]
    [Attributes(9)]
    public sealed class C0Bc6VgaGainOffset
    {
        public short Value { get; set; }
    }
}