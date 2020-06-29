using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021741", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0Im2Lpm2
    {
        [FieldCount(3)]
        public byte[] Value
        {
            get;
        }
    }
}