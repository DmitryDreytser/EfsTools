using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5102)]
    [Attributes(9)]
    public sealed class C1Wcdma900LnaPhaseCtl
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}