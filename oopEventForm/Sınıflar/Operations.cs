using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopEventForm.Sınıflar
{
    class Operations
    {
        Maths m;
        public int a { get; set; }
        public int b { get; set; }
        public Operations(int x, int y)
        {
            m = new Maths();
            m.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }
        public void SampleEventHandler()
        {
            MessageBox.Show("Sample Event Handler çağrıldı");
        }
        public int AddOperation()
        {
            return m.Add(a, b);
        }
        public int SubstractOperation()
        {
            return m.Substract(a, b);
        }
    }
}
