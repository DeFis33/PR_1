using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class MyClass : Component
    {
        int x, n, z, res;
        public int Result
        {
            get { return res; }
        }
        public MyClass(int my_x, int my_n, int my_z)
        {
            x = my_x;
            n = my_n;
            z = my_z;
            res = Power(x, n, z);
        }
        int Power(int x, int n, int z) 
        {
            if (x <= 0 || n <= 0 || z <= 0)
            {
                throw new Exception();
            }
            return x * n * z;
        }
    }
}