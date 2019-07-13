using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public class Handler
    {
        public void Execute()
        {
            MyClass myClassInstance = new MyClass();
            myClassInstance.SetClassField("Initial class field value.");

            MyStruct myStructureInstance = new MyStruct();
            myStructureInstance.SetStructureField("Initial class field value.");

            this.Change(myClassInstance);
            this.Change(myStructureInstance);

            Console.WriteLine($"Class field is: {myClassInstance.GetClassField()}");
            Console.WriteLine($"Structure field is: {myStructureInstance.GetStructureField()}");
        }

        public void Change(MyStruct myStructInstance)
        {
            myStructInstance.SetStructureField("Structure has been changed!");
        }

        private void Change(MyClass myClassInstance)
        {
            myClassInstance.SetClassField("Class has been changed!");
        }
    }
}
