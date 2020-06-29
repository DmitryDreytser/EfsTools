using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3109)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg8F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}