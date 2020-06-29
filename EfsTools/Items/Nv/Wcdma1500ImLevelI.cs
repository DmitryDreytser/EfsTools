using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6930)]
    [Attributes(9)]
    public sealed class Wcdma1500ImLevel
    {
        public short Value { get; set; }
    }
}