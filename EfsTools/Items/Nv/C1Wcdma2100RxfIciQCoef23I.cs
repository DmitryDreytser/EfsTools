using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5937)]
    [Attributes(9)]
    public sealed class C1Wcdma2100RxfIciQCoef23
    {
        public uint Value { get; set; }
    }
}