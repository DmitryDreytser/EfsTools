using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1776)]
    [Attributes(9)]
    public sealed class C1Bc0VgaGainOffset
    {
        public short Value { get; set; }
    }
}