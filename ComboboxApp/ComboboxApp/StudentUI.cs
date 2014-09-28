using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboboxApp
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
            studentComboBox.DisplayMember = "RegNo";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(nameTextBox.Text, regNoTextBox.Text, addressTextBox.Text);
            studentComboBox.Items.Add(aStudent);
            MessageBox.Show("Student added");
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedStudent = (Student) studentComboBox.SelectedItem;
            displayNameTextBox.Text = selectedStudent.Name;
            displayAddressTextBox.Text = selectedStudent.Address;
        }
    }
}
