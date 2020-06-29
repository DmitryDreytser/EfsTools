using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7161)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciCalDataCar1
    {
        [FieldCount(17)]
        public uint[] Value { get; set; }
    }
}