using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5381)]
    [Attributes(9)]
    public sealed class Gsm900KvVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}