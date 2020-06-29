using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1274)]
    [Attributes(9)]
    public sealed class GsmPaTempCompIndex1
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}