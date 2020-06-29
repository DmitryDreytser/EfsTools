using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6861)]
    [Attributes(9)]
    public sealed class RcProcessErrors
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}