using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        private void программаРасчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMath_Click(sender, e);
        }
        private void btnMath_Click(object sender, EventArgs e)
        {
            try
            {
                MyClass obj1 = new MyClass(Convert.ToInt32(textBoxPrice.Text), Convert.ToInt32(textBoxPeriod.Text), Convert.ToInt32(textBoxPeople.Text));
                textBoxResult.Text = obj1.Result.ToString();
            }
            catch 
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPeriod.Clear();
                textBoxPeople.Clear();
                textBoxResult.Clear();
            }
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPeriod.Clear();
            textBoxPeople.Clear();
            textBoxResult.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }
    }
}
