using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5181)]
    [Attributes(9)]
    public sealed class Bc10HdetSpn
    {
        public byte Value { get; set; }
    }
}