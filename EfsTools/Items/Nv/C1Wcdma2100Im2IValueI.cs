using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3784)]
    [Attributes(9)]
    public sealed class C1Wcdma2100Im2IValue
    {
        public byte Value { get; set; }
    }
}