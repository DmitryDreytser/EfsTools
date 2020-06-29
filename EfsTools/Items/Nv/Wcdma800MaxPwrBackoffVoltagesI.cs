using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2720)]
    [Attributes(9)]
    public sealed class Wcdma800MaxPwrBackoffVoltages
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}