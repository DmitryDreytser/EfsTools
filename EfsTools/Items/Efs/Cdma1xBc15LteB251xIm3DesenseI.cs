using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024828", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB251xIm3Desense
    {
        [FieldCount(10)]
        public short[] Value
        {
            get;
        }
    }
}