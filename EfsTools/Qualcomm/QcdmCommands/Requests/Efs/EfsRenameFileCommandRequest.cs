﻿using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsRename)]
    internal class EfsRenameFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly string _newPath;

        private readonly string _path;

        public EfsRenameFileCommandRequest(string path, string newPath)
        {
            _path = path;
            _newPath = newPath;
        }

        public override byte[] GetData()
        {
            var data = new byte[6 + _path.Length + _newPath.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(Encoding.ASCII.GetBytes(_path), 0, data, 4, _path.Length);
            data[4 + _path.Length] = 0;
            Array.Copy(Encoding.ASCII.GetBytes(_newPath), 0, data, 5 + _path.Length, _newPath.Length);
            data[5 + _path.Length + _newPath.Length] = 0;
            return data;
        }
    }
}