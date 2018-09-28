using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10Exercise9
{
    public partial class Shirts : Form
    {
        public Shirts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exit button; Close the application
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Process; Displays what the user selected as well as the quantity
            MessageBox.Show($"You have selected {listBox1.SelectedItem}, Quantity: {QuantityText.Text}");
        }

        //private void Quantity(object sender, EventArgs e)
        //{
        //    // Quantity; they can enter how many they want
        //    // Do I need to convert the the Quantity number to a string in order to display it
            
        //}
    }
}
