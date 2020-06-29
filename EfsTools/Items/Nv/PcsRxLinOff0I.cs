using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(325)]
    [Attributes(9)]
    public sealed class PcsRxLinOff0
    {
        public byte Value { get; set; }
    }
}