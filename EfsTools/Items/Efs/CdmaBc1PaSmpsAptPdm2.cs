using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020515", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc1PaSmpsAptPdm2
    {
        [FieldCount(64)]
        public ushort[] Value
        {
            get;
        }
    }
}