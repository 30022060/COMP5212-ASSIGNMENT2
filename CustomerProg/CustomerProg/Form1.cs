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
        Customer c1 = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //Clear Button
        {
            firstname_text.Clear();
            lastname_text.Clear();
            phone_text.Clear();
        }

        private void button3_Click(object sender, EventArgs e) //Add Button
        {
            if(firstname_text.Text != ""
                && lastname_text.Text != ""
                && phone_text.Text != "")
            {
                MessageBox.Show("New customer has been added.");
                c1.fName = firstname_text.Text;
                c1.lName = lastname_text.Text;
                c1.phone = phone_text.Text;
                listBox1.Items.Add(c1.GetCustomer());

                firstname_text.Clear();
                lastname_text.Clear();
                phone_text.Clear();
            }
            else
            {
                MessageBox.Show("All textboxes must be filled to continue.");
            }
        }

        private void button6_Click(object sender, EventArgs e) //Clear Listbox Button
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Listbox
        {
            listBox1.HorizontalScrollbar = true;
        }

        private void button5_Click(object sender, EventArgs e) //Delete Button
        {

        }
    }
}
