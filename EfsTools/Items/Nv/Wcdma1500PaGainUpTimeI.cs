using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7002)]
    [Attributes(9)]
    public sealed class Wcdma1500PaGainUpTime
    {
        public short Value { get; set; }
    }
}