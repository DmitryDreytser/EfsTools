using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(240)]
    [Attributes(9)]
    public sealed class QncEnabledFlag
    {
        public byte Value { get; set; }
    }
}