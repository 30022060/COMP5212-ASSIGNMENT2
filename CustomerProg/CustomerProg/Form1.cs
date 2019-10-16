using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //Clear Button
        {
            firstname_text.Text = string.Empty;
            lastname_text.Text = string.Empty;
            phone_text.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e) //Add Button
        {
            if(firstname_text.Text != ""
                && lastname_text.Text != ""
                && phone_text.Text != "")
            {
                MessageBox.Show("New customer has been added.");
                listBox1.Items.Add("Yes");
            }
            else
            {
                MessageBox.Show("ERROR. EMPTY TEXTBOX DETECTED.");
            }
        }

        private void button6_Click(object sender, EventArgs e) //Clear Listbox Button
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Listbox
        {
            
        }

        private void button5_Click(object sender, EventArgs e) //Delete Button
        {
            if (listBox1.Items.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR. NO DATA HAS BEEN SELECTED");
            }
            else
            {
                DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE\nSELECTED DATA?", "WARNING", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else if (result == DialogResult.No)
                {

                }
            }
   
        }
    }
}
