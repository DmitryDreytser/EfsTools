using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(716)]
    [Attributes(9)]
    public sealed class PcsImLevel4
    {
        public sbyte Value { get; set; }
    }
}