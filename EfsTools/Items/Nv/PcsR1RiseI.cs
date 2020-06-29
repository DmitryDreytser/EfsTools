using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(337)]
    [Attributes(9)]
    public sealed class PcsR1Rise
    {
        public byte Value { get; set; }
    }
}