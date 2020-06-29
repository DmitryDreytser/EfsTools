using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(291)]
    [Attributes(9)]
    public sealed class SilentRedialEnabled
    {
        public byte Value { get; set; }
    }
}