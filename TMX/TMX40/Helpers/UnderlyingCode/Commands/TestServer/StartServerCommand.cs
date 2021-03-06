﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/17/2014
 * Time: 7:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Helpers.UnderlyingCode.Commands.TestServer
{
    using System;
    using Server.Library.ObjectModel.ServerControl;
    using Tmx.Commands.TestServer;

    /// <summary>
    /// Description of StartServerCommand.
    /// </summary>
    class StartServerCommand : TmxCommand
    {
        internal StartServerCommand(CommonCmdletBase cmdlet) : base (cmdlet)
        {
        }
        
        internal override void Execute()
        {
            var cmdlet = (StartTmxServerCommand)Cmdlet;
            try {
                ServerControl.Port = cmdlet.Port;
                ServerControl.Start(@"http://localhost:" + cmdlet.Port);
            }
            catch (Exception eStartingServer) {
Console.WriteLine(eStartingServer.Message);
Console.WriteLine(eStartingServer.InnerException.Message);
            }
//            var hostname = Dns.GetHostName();
//            if (string.Empty != IPGlobalProperties.GetIPGlobalProperties().DomainName) {
//                hostname += ".";
//                hostname += IPGlobalProperties.GetIPGlobalProperties().DomainName;
//            }
//            Tmx.Server.ServerControl.Start(hostname, cmdlet.Port);
            
            // Tmx.Server.ServerControl.Start(cmdlet.Hostname, cmdlet.Port);
        }
    }
}
