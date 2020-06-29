using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2939)]
    [Attributes(9)]
    public sealed class Wcdma1800HsR1Rise
    {
        public short Value { get; set; }
    }
}