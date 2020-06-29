using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2799)]
    [Attributes(9)]
    public sealed class C0Bc5RxCalChanLru
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}