using HomeWork3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Runners
{
    public class Run
    {
        Queue queue = new Queue();
        public void Start()
        {
            while (!queue.IsFree())
            {
                try
                {
                    queue.Get().Execute();
                }
                catch (Exception ex)
                {

                }
            }
        }



        public void AddCommand(IRunCommand runCommand)
        {
            queue.Add(runCommand);
        }
    }
}
