using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6168)]
    [Attributes(9)]
    public sealed class C0BcxBlockIm2Cal
    {
        [FieldCount(7)]
        public byte[] Value
        {
            get;
        }
    }
}