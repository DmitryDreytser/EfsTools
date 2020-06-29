using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Utils;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/policyman/carrier_policy.xml", false, 0x81FF)]
    [Attributes(9)]
    public sealed class CarrierPolicyXml
    {
        [FieldCount(0)]
        private byte[] _values;

        public string[] Values
        {
            get => StringUtils.GetStringLines(_values, LineEnding.Linux);
            set => _values = StringUtils.GetBytes(value, LineEnding.Linux);
        }
    }
}