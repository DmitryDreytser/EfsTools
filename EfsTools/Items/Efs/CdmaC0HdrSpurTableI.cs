using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023755", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0HdrSpurTable
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }
}