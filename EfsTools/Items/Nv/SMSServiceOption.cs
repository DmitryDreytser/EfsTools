using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4366)]
    [Attributes(9)]
    public sealed class SmsServiceOption
    {
        public uint Value { get; set; }
    }
}