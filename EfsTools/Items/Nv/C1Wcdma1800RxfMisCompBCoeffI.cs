using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6393)]
    [Attributes(9)]
    public sealed class C1Wcdma1800RxfMisCompBCoeff
    {
        public short Value { get; set; }
    }
}