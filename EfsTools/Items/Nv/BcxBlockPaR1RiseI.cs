using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4561)]
    [Attributes(9)]
    public sealed class BcxBlockPaR1Rise
    {
        public byte Value { get; set; }
    }
}