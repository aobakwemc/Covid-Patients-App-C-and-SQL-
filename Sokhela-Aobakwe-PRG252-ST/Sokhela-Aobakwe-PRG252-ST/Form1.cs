using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokhela_Aobakwe_PRG252_ST
{
    public partial class Form1 : Form
    {
        DataHandler myDH = new DataHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gpxPatientReg_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            myDH.insertPatient(Convert.ToInt32(txtPatientIDReg.Text), txtNameReg.Text, txtSurnameReg.Text,txtGenderReg.Text,dtpDtAdmitReg.Value);
            //method works successfully
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIDAppend.Text=="")
            {
                MessageBox.Show("Please enter & find a patient to delete.");
            }
            if (txtIDAppend.Text!="")
            {
                myDH.deletePatient(Convert.ToInt32(txtIDAppend.Text));
            }
            //logic works successfully
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDAppend.Text=="")
            {
                MessageBox.Show("Please enter & find a patient to update.");
            }
            if (txtIDAppend.Text!="")
            {
                myDH.updatePatient(Convert.ToInt32(txtIDAppend.Text), txtNameAppend.Text, txtSurnameAppend.Text, txtGenderAppend.Text, dtpDtAdmitAppend.Value);
            }
            //logic works successfully
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIDDisplay.Text=="")
            {
                MessageBox.Show("Please enter a valid ID.");
            }
            if (txtIDDisplay.Text!="")
            {
                dgvDisplay.DataSource = myDH.searchPatient(Convert.ToInt32(txtIDDisplay.Text));
            }
            //logic works successfully   
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtIDAppend.Text == "")
            {
                MessageBox.Show("Please enter a valid ID.");
            }
            if (txtIDAppend.Text != "")
            {
                dgvDisplay.DataSource = myDH.searchPatient(Convert.ToInt32(txtIDAppend.Text));
            }
            //logic works successfully
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = myDH.viewAll();
            //method + stored procedure works successfully
        }

        private void txtIDDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
