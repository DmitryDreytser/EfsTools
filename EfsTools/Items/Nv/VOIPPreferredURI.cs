using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4230)]
    [Attributes(9)]
    public sealed class VoipPreferredUrl
    {
        public ushort Value { get; set; }
    }
}