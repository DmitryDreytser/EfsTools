using System;
using EfsTools.Attributes;
using EfsTools.Utils;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/data/default_andsf.xml", false, 0x81B6)]
    [Attributes(9)]
    public sealed class DefaultAndsfXml
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