﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/31/2014
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Server.Logic.ObjectModel
{
    using System.Linq;
    using Core;
    using Objects;
    using Tmx.Interfaces.Remoting;

    /// <summary>
    /// Description of TestRunSelector.
    /// </summary>
    public class TestRunSelector
    {
        public virtual ITestRun GetNextInRowTestRun()
        {
            var testRunsThatPending = TestRunQueue.TestRuns.Where(testRun => testRun.IsPending());
            var testRunsThatPendingArray = testRunsThatPending as ITestRun[] ?? testRunsThatPending.ToArray();
            return !testRunsThatPendingArray.Any() ? null : testRunsThatPendingArray.OrderBy(testRun => testRun.CreatedTime).First();
        }
        
        public virtual void CancelTestRun(ITestRun testRun)
        {
            TaskPool.TasksForClients.Where(task => task.TestRunId == testRun.Id && !task.IsFinished() && !task.IsActive() && !task.IsCancel).ToList().ForEach(task => task.TaskStatus = TestTaskStatuses.Canceled);
            var activeTasks = TaskPool.TasksForClients.Where(task => task.TestRunId == testRun.Id && task.IsActive()).ToList();
            if (activeTasks.Any())
            {
                // 20150918
                // temporarily
                // until there'll be async execution of task here
                // linked lines of code 20150918-001
                // activeTasks.ForEach(task => { if (!task.IsCancel) task.TaskStatus = TestTaskStatuses.InterruptedByUser; });
                // TODO: provide all clients that ran active tasks with newly available tasks
                // however clients can't interrupt their tasks
                // 
                testRun.Status = TestRunStatuses.Canceling;
            }
            else
            {
                testRun.Status = TestRunStatuses.Canceled;
            }

            // TODO: set test run status Canceled after all isCancel tasks have finished
            
            // disconnecting clients
            // 20150807
            // ClientsCollection.Clients.RemoveAll(client => client.TestRunId == testRun.Id);

            // 20150909
            // no more unregistration of clients
            // testRun.UnregisterClients();
            // set time only for completely cancelled test runs
            // testRun.SetTimeTaken();
            if (TestRunStatuses.Canceled == testRun.Status)
                testRun.SetTimeTaken();

            // 20150909
            // RunNextInRowTestRun();
            if (TestRunStatuses.Canceled == testRun.Status)
                RunNextInRowTestRun();
        }
        
        public virtual void RunNextInRowTestRun()
        {
            var testRun = GetNextInRowTestRun();
            if (null == testRun) return;
            // 20150922
            // if (TestRunQueue.TestRuns.Any(tr => tr.IsActive() && tr.TestLabId == testRun.TestLabId)) return;
            if (TestRunQueue.TestRuns.Any(tr => tr.IsAcceptingNewClients() && tr.TestLabId == testRun.TestLabId)) return;
            testRun.SetStartTime();
            testRun.Status = TestRunStatuses.Running;
        }
    }
}
