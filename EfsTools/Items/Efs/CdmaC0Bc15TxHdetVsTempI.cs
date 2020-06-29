using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024762", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc15TxHdetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] HdetVsTemp
        {
            get;
        }
    }
}