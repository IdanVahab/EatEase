using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    class UnDefTask : Task
    {
        private string taskTitle;
        private string taskInfo;

        public UnDefTask(string taskTitle, string taskInfo,bool manager, DateTime startDate, DateTime dueDate, List<Employee> employees) : base(manager, startDate, dueDate, employees)
        {
            this.TaskTitle = taskTitle;
            this.TaskInfo = taskInfo;
        }

        public string TaskTitle { get => taskTitle; set => taskTitle = value; }
        public string TaskInfo { get => taskInfo; set => taskInfo = value; }

        public override string ToString()
        {
            return "Task : "+this.taskTitle+"\nTask info : "+this.taskInfo+"\n"+base.ToString();
        }
    }
}
