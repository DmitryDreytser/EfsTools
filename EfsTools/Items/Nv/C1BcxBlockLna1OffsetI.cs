using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4606)]
    [Attributes(9)]
    public sealed class C1BcxBlockLna1Offset
    {
        public short Value { get; set; }
    }
}