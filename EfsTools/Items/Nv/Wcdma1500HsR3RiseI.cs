using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7051)]
    [Attributes(9)]
    public sealed class Wcdma1500HsR3Rise
    {
        public short Value { get; set; }
    }
}