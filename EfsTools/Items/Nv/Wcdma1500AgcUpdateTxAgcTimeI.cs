using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6961)]
    [Attributes(9)]
    public sealed class Wcdma1500AgcUpdateTxAgcTime
    {
        public ushort Value { get; set; }
    }
}