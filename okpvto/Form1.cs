using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okpvto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color _color = Color.Blue;
        bool _firts;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpremio_Click(object sender, EventArgs e)
        {
           MessageBox.Show("    ----------------- Te quiero Mi vida  ------------------      ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBoxresultst.SelectionColor = _color;
            if (_firts)
                richTextBoxresultst.SelectedText = textBox1.Text;
            else
                richTextBoxresultst.SelectedText = Environment.NewLine + textBox1.Text;
            _firts = false;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                _color = colorDialog1.Color;
                panelColor.BackColor = _color;

            }

        }
    }
}
