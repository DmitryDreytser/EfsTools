﻿using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsCloseDir)]
    internal class EfsCloseDirectoryCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly int _directory;

        public EfsCloseDirectoryCommandRequest(int dir)
        {
            _directory = dir;
        }

        public override byte[] GetData()
        {
            var data = new byte[8];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_directory), 0, data, 4, 4);
            return data;
        }
    }
}