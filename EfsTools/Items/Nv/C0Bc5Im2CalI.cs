using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5582)]
    [Attributes(9)]
    public sealed class C0Bc5Im2Cal
    {
        [FieldCount(7)]
        public byte[] Value
        {
            get;
        }
    }
}