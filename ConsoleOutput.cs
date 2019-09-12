using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacTest
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
