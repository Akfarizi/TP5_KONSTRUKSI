using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300078
{
    public class DataGeneric<X>
    {
        private X data;

        public DataGeneric(X data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

}
