using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1650)]
    [Attributes(9)]
    public sealed class C0Bc1Lna1OffsetVsFreq
    {
        [FieldCount(48)]
        public sbyte[] Value
        {
            get;
        }
    }
}