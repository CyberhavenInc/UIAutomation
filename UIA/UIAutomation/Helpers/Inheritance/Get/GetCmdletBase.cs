﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 29.11.2011
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System.Management.Automation;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Description of GetCmdletBase.
    /// </summary>
    public class GetCmdletBase : HasTimeoutCmdletBase
    {
        #region Parameters
        [My][Parameter(Mandatory = false)]
        internal new SwitchParameter PassThru { get; set; }
        
        [My][Parameter(Mandatory = false)]
//        [My][Parameter(Mandatory = false,
//                   ParameterSetName = "Win32")]
//        [My][Parameter(Mandatory = false,
//                   ParameterSetName = "UIAuto")]
        //[My][Parameter(Mandatory = false,
        //           ParameterSetName = "Window")]
        //[My][Parameter(Mandatory = false,
        //           ParameterSetName = "First")]
        // 20130228
        //[My][Parameter(Mandatory = false,
        //           ParameterSetName = "SearchCriteria")]
        public Hashtable[] SearchCriteria { get; set; }
        #endregion Parameters
        
        // protected internal List<IUiElement> GetFilteredElementsCollection(GetCmdletBase cmdlet, List<IUiElement> elementCollection)
//        protected internal List<IUiElement> GetFilteredElementsCollection(List<IUiElement> elementCollection)
//        {
//            List<IUiElement> resultCollection = new List<IUiElement>();
//            
//            
//            
//            return resultCollection;
//        }
    }
}
