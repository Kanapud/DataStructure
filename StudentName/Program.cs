using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace StudentName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
