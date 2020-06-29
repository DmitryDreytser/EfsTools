using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1907)]
    [Attributes(9)]
    public sealed class AuthenticationRequirePasswordEncryption
    {
        public byte Value { get; set; }
    }
}