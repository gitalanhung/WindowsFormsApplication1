using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //MessageBox.Show("");
            //jjjjjjjjjjjjjjjjjjjj
        }

        List<int> dic = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                dic.Add(i);

            dic.ForEach(i => i += 10);
            foreach (int i in dic)
                Console.WriteLine(i.ToString());
        }
    }
}
