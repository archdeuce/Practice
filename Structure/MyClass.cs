using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public class MyClass
    {
        private string change;

        public string GetClassField()
        {
            return this.change;
        }

        public void SetClassField(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}