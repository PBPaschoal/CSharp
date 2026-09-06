using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExercicioPG75 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (checkBox1.Checked == true) {
                if (label1.BackColor == Color.Red) {
                    label1.BackColor = Color.Blue;
                }
                else {
                    label1.BackColor = Color.Red;
                }
            }
            else {
                MessageBox.Show("The box is not checked");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            button1.Click += new EventHandler(button1_Click);
        }
    }
}
