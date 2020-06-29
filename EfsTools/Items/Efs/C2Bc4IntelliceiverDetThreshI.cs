using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021826", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc4IntelliceiverDetThresh
    {
        [FieldCount(10)]
        public sbyte[] Value
        {
            get;
        }
    }
}