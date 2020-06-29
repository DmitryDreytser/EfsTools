using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6495)]
    [Attributes(9)]
    public sealed class LteB13RxGainVsTemp
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}