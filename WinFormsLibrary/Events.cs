using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary
{
    public class AccountEventArgs : EventArgs
    {
        public string Message { get; }

        public long Age { get; }

        public AccountEventArgs(string message, long age)
        {
            this.Message = message;
            this.Age = age;
        }
    }
}
