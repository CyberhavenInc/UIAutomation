﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 4/5/2012
 * Time: 6:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    //using System;
    //using System.Management.Automation;
    
    /// <summary>
    /// Description of SearchCmdletBase.
    /// </summary>
    public class SearchCmdletBase : GetControlCollectionCmdletBase //HasTimeoutCmdletBase
    {
        public SearchCmdletBase()
        {
            this.CaseSensitive = false;
        }
        
        #region Parameters
        #endregion Parameters
    }
}
