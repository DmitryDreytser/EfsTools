using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/hdr/cp/sap/backofftimel2", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Backofftimel2
    {
        public ushort Field1 { get; set; }


        public ushort Field2 { get; set; }


        public ushort Field3 { get; set; }


        public ushort Field4 { get; set; }


        public ushort Field5 { get; set; }


        public ushort Field6 { get; set; }


        public ushort Field7 { get; set; }


        public ushort Field8 { get; set; }


        public ushort Field9 { get; set; }


        public ushort Field10 { get; set; }
    }
}