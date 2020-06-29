using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020981", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4LnaRangeFall5Car1
    {
        public short Value { get; set; }
    }
}