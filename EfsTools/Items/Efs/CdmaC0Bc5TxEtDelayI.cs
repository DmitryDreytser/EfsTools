using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025510", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc5TxEtDelay
    {
        public int Delay { get; set; }
    }
}