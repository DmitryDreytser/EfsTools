using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(932)]
    [Attributes(9)]
    public sealed class ProcessIncomingCsDataCallAsInternal
    {
        public byte Value { get; set; }
    }
}