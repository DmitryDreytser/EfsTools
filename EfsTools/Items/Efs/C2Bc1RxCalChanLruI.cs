using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021777", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1RxCalChanLru
    {
        [FieldCount(16)]
        public byte[] Value
        {
            get;
        }
    }
}