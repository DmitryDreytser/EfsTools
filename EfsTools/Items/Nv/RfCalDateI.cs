using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(571)]
    [Attributes(9)]
    public sealed class RfCalDate
    {
        public uint Value { get; set; }
    }
}