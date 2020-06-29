using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6964)]
    [Attributes(9)]
    public sealed class Wcdma1500RxDelay
    {
        public short Value { get; set; }
    }
}