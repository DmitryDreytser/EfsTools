using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022583", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB11RxfIciCalDataCar1
    {
        [FieldCount(17)]
        public uint[] Value
        {
            get;
        }
    }
}