using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3916)]
    [Attributes(9)]
    public sealed class C1Bc11VgaGainOffsetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}