using System;
using BinarySerialization;
using EfsTools.Items.Base;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Base
{
    [Serializable]
    public class MultiLineStringsItemBase : ItemBase
    {
        [Ignore]
        public string[] Values
        {
            get => StringUtils.GetStringLines(RawValue, LineEnding.Linux);
            set => RawValue = StringUtils.GetString(value, LineEnding.Linux);
        }


        private string _rawValue;
        [JsonIgnore]
        [FieldOffset(0)]
        public string RawValue 
        { 
            get => _rawValue; 
            set => _rawValue = value;
        }
    }
}