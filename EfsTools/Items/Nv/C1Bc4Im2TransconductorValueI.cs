using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1532)]
    [Attributes(9)]
    public sealed class C1Bc4Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}