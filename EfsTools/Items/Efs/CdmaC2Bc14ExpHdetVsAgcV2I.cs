using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022076", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}