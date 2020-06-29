using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1015)]
    [Attributes(9)]
    public sealed class GsmUmtsCellBroadcastSmsServiceTableSize
    {
        public ushort Value { get; set; }
    }
}