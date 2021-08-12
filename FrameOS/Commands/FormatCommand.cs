﻿using FrameOS.Systems.CommandSystem;
using System;
using System.Collections.Generic;
using System.Text;
using FrameOS.FileSystem;
using sys = Cosmos.System;

namespace FrameOS.Commands
{
    class FormatCommand : ICommand
    {
        public void Run(CommandArg[] commandArgs)
        {
            if (commandArgs.Length != 1)
            {
                Console.WriteLine("Invalid Paramaters");
                return;
            }

            string drive = commandArgs[0].String;

            Console.WriteLine("Formating drive " + drive);

            Filesystem.Format(drive);

            Console.WriteLine("Rebooting the system");

            sys.Power.Reboot();
        }
    }
}
