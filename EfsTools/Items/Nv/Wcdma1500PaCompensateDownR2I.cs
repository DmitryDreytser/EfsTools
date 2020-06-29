using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6978)]
    [Attributes(9)]
    public sealed class Wcdma1500PaCompensateDownR2
    {
        public short Value { get; set; }
    }
}