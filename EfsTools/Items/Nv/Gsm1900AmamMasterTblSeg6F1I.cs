using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2550)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg6F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}