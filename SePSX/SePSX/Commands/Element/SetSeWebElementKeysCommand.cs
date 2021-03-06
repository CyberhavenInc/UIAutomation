﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/19/2012
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSX.Commands
{
    using System.Management.Automation;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of SetSeWebElementKeysCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "SeWebElementKeys")]
    [OutputType(typeof(IWebElement))]
    public class SetSeWebElementKeysCommand : WebElementCmdletBase
    {
        public SetSeWebElementKeysCommand()
        {
        }
        
        #region Parameters
        [Parameter(Mandatory = true,
                   Position = 0)]
        public string Text { get; set; }
        #endregion Parameters
        
        protected override void ProcessRecord()
        {
            checkInputWebElementOnly(InputObject);
            
            var command =
                new SeSetWebElementKeysCommand(this);
            command.Execute();
//            SeHelper.SendWebElementKeys(
//                this,
//                ((IWebElement[])this.InputObject),
//                this.Text);
        }
    }
}
