using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1036)]
    [Attributes(9)]
    public sealed class C1CdmaLna4Rise
    {
        public sbyte Value { get; set; }
    }
}