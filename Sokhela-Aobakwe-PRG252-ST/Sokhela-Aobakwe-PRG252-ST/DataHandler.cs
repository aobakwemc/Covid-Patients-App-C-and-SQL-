using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sokhela_Aobakwe_PRG252_ST
{
    internal class DataHandler
    {
        string connectToDB = @"Data Source=DESKTOP-GEN5MLJ\SQLEXPRESS01;Initial Catalog=ZONE15;Integrated Security=True";
		
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string surname;
		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}
		private string gender;
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}
		private DateTime dateAdmitted;
		public DateTime DateAdmitted
		{
			get { return dateAdmitted; }
			set { dateAdmitted = value; }
		}
        public DataHandler(int id, string name,  string surname, string gender, DateTime dateAdmitted)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            DateAdmitted = dateAdmitted;
        }
		public DataHandler()
		{
			//default constructor.
		}

		public void insertPatient(int patientID, string patientName, string patientSurname, string patientGender, DateTime dtAdmitted) 
		{
			SqlConnection conn = new SqlConnection(connectToDB);
			try
			{
				conn.Open();
                //If inserting into all columns, no need to specify column names - just follow column order
                string insertQuery = $"insert into Patients values('{patientID}', '{patientName}','{patientSurname}', '{patientGender}', '{dateAdmitted}')";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Patient details saved to database.");
            }
            catch (Exception)
			{
				System.Windows.Forms.MessageBox.Show("Error connecting to database.");
			}
			finally
			{
                conn.Close();
            }
		}
		public void deletePatient(int patientID) //first find the patient to delete the patient
		{
			SqlConnection conn = new SqlConnection(connectToDB);
			try
			{
				conn.Open(); //open db connection

				string deleteQuery = $"delete from Patients where PatientID = {patientID}";
				SqlCommand cmd = new SqlCommand(deleteQuery, conn);
				cmd.ExecuteNonQuery();
				System.Windows.Forms.MessageBox.Show("Patient deleted from database.");
			}
			catch (Exception)
			{
				System.Windows.Forms.MessageBox.Show("Error connecting to database.");
			}
			finally { conn.Close(); }
		}    
		public DataTable searchPatient(int patientID)
		{
			SqlConnection conn = new SqlConnection(connectToDB);
			
            try
			{
				conn.Open();
			}
			catch (Exception)
			{
				System.Windows.Forms.MessageBox.Show("Error connecting to database.");
			}
            string searchQuery = $"select * from Patients where PatientID = {patientID}";

            SqlCommand cmd = new SqlCommand(searchQuery, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);
			DataTable myDataTbl = new DataTable();
			adapter.Fill(myDataTbl);

			conn.Close();
			return myDataTbl;
		}
		public void updatePatient(int patientID, string patientName, string patientSurname, string patientGender, DateTime dtAdmitted) 
		{
            //first find the patient to update the patient
            SqlConnection conn = new SqlConnection(connectToDB);
			try
			{
				conn.Open();

				string updateQuery = $"update Patients set Name='{patientName}', Surname='{patientSurname}', Gender='{patientGender}', DateAdmitted='{dtAdmitted}' where PatientID={patientID}";
				SqlCommand cmd = new SqlCommand(updateQuery, conn);
				cmd.ExecuteNonQuery();
				System.Windows.Forms.MessageBox.Show("Patient details updated!");
			}
			catch (Exception)
			{
				System.Windows.Forms.MessageBox.Show("Error connecting to database.");
			}
			finally { conn.Close(); }
		}	
		public DataTable viewAll() 
		{
			SqlConnection conn = new SqlConnection(connectToDB);
			
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayAll", conn);
			DataTable myDataTbl = new DataTable();
			adapter.Fill(myDataTbl);

			return myDataTbl;
        }	
	}
}
