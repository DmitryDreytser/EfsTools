using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4870)]
    [Attributes(9)]
    public sealed class Gsm850CarrierSuppression
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}