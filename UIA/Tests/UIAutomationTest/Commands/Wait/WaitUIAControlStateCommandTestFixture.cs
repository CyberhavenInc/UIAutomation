﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 2/12/2014
 * Time: 1:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationTest.Commands.Wait
{
    using System;
    using System.Diagnostics;
    using System.Windows.Automation;
    using MbUnit.Framework;using NUnit.Framework;

    /// <summary>
    /// Description of WaitUIAControlStateCommandTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture][NUnit.Framework.TestFixture]
    public class WaitUIAControlStateCommandTestFixture
    {
        [MbUnit.Framework.SetUp][NUnit.Framework.SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspace();
        }
        
        [MbUnit.Framework.TearDown][NUnit.Framework.TearDown]
        public void DisposeRunspace()
        {
            MiddleLevelCode.DisposeRunspace();
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void ControlTypeName_Existing()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{controlType=\"button\";name=\"" +
                expectedName +
                "\"})) { 1; } else { 0; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void ControlTypeAutomationId_Existing()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{controlType=\"button\";automationid=\"" +
                expectedAutomationId +
                "\"})) { 1; } else { 0; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void ControlType_Existing()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{controlType=\"button\"})) { 1; } else { 0; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void Name_Existing()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{name=\"" +
                expectedName +
                "\"})) { 1; } else { 0; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void AutomationId_Existing()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{automationid=\"" +
                expectedAutomationId +
                "\"})) { 1; } else { 0; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void ControlTypeNameAutomationId_Existing()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{controlType=\"button\";name=\"" +
                expectedName +
                "\";automationid=\"" +
                expectedAutomationId +
                "\"})) { 1; } else { 0; }");
        }
        
        // ==========================================================================================================
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void Name_NonExisting()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{name=\"" +
                expectedAutomationId +
                "\"})) { 0; } else { 1; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void AutomationId_NonExisting()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{automationid=\"" +
                expectedName +
                "\"})) { 0; } else { 1; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void ControlTypeNameAutomationId_NonExisting()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                0);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{controlType=\"radiobutton\";name=\"" +
                expectedName +
                "\";automationid=\"" +
                expectedAutomationId +
                "\"})) { 0; } else { 1; }");
        }
        
        // ==========================================================================================================
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void NameAutomationId_NonExisting_Delay()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                TimeoutsAndDelays.Control_Delay4000);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{name=\"" +
                expectedName +
                "\";automationid=\"" +
                expectedAutomationId +
                "\"})) { 1; } else { 0; }");
        }
        
        [MbUnit.Framework.Test][NUnit.Framework.Test]
        [MbUnit.Framework.Category("Slow")]
        [MbUnit.Framework.Category("WinForms")]
        [MbUnit.Framework.Category("Wait-UiaControlState")]
        public void ControlTypeNameAutomationId_NonExisting_Delay()
        {
            const string expectedName = "btnName";
            const string expectedAutomationId = "btnAuId";
            MiddleLevelCode.StartProcessWithFormAndControl(
                UIAutomationTestForms.Forms.WinFormsEmpty,
                0,
                ControlType.Button,
                expectedName,
                expectedAutomationId,
                TimeoutsAndDelays.Control_Delay4000);
            
            CmdletUnitTest.TestRunspace.RunAndEvaluateAreEqual1(
                @"if ((Get-UiaWindow -pn " +
                MiddleLevelCode.TestFormProcess +
                " -au " +
                MiddleLevelCode.TestFormNameEmpty +
                " | Wait-UiaControlState -SearchCriteria @{controlType=\"button\";name=\"" +
                expectedName +
                "\";automationid=\"" +
                expectedAutomationId +
                "\"})) { 1; } else { 0; }");
        }
    }
}
