using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.User_Control
{
    public partial class EmployeeUC : UserControl
    {
        FunctionClass f = new FunctionClass();
        String sqlquery;
        //TODO: Add Phone Number Regex,Name and Other Regex
        String emailpattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3})$";
        String usernamepattern = "^[a-zA-Z0-9]{4,15}$";
        String passwordpattern = "^[a-zA-Z0-9]{5,15}$";
        String phonepattern = "^0\\d{3}\\d{7}$";
        public EmployeeUC()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EmpNameTextBox.Text) && !String.IsNullOrWhiteSpace(EmpPhoneTextBox.Text) && !String.IsNullOrWhiteSpace(EmpGenderComBox.Text) && !String.IsNullOrWhiteSpace(EmpEmailTextBox.Text) && !String.IsNullOrWhiteSpace(EmpUsernameTextBox.Text) && !String.IsNullOrWhiteSpace(EmpPasswordTextBox.Text) && Regex.IsMatch(EmpEmailTextBox.Text, emailpattern) == true && Regex.IsMatch(EmpUsernameTextBox.Text, usernamepattern) == true && Regex.IsMatch(EmpPhoneTextBox.Text, phonepattern) == true && Regex.IsMatch(EmpPasswordTextBox.Text, passwordpattern) == true)
            {

                String empname = EmpNameTextBox.Text;
                String empnum = EmpPhoneTextBox.Text;
                String empdob = EmpDob.Text;
                String empgender = EmpGenderComBox.Text;
                String empemail = EmpEmailTextBox.Text;
                String empusername = EmpUsernameTextBox.Text;
                String emppass = EmpPasswordTextBox.Text;
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                try
                {
                    sqlquery = "insert into cinema.employee (emp_name,emp_phone,emp_dob,emp_gender,emp_email,emp_username,emp_password) values ('" + empname + "','" + empnum + "','"+empdob+"','" + empgender + "','" + empemail + "','" + empusername + "','" + emppass + "')";
                    f.SetData(sqlquery, "New Employee Added.");
                    ClearAllFields();
                }

                catch (SqlException exp)
                {
                    if (exp.Number == 2627)  //2627 is unique or primary key constraint error code
                    {
                        MessageBox.Show("Email or Username Already Exists, Enter a unique Email or Username.", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                if (Regex.IsMatch(EmpEmailTextBox.Text, emailpattern) == false)
                {
                    MessageBox.Show("Enter valid Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(EmpUsernameTextBox.Text, usernamepattern) == false)
                {
                    MessageBox.Show("Enter valid username. (Only alphabets and numbers are allowed)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(EmpPhoneTextBox.Text, phonepattern) == false)
                {
                    MessageBox.Show("Enter valid phone number (03331234567), Length should be 11", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(EmpPasswordTextBox.Text, passwordpattern) == false)
                {
                    MessageBox.Show("Enter valid password. Minimum Length: 5", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void ClearAllFields()
        {
            EmpNameTextBox.Clear();
            EmpPhoneTextBox.Clear();
            EmpGenderComBox.SelectedIndex = -1;
            EmpEmailTextBox.Clear();
            EmpUsernameTextBox.Clear();
            EmpPasswordTextBox.Clear();
            EditEmpIDTextBox.Clear();
            EditEmpNameTextBox.Clear();
            EditEmpPhoneTextBox.Clear();
            EditEmpGenderComBox.SelectedIndex = -1;
            EditEmpEmailTextBox.Clear();
            EditEmpUsernameTextBox.Clear(); 
            EditEmpPasswordTextBox.Clear();
            DelEmpIDTextBox.Clear();
            DelEmpNameTextBox.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                sqlquery = "select emp_id as EmployeeID,emp_name as EmployeeName, emp_phone as EmployeePhone, emp_dob as EmployeeDOB, emp_gender as EmployeeGender,emp_email as EmployeeEmail,emp_username as EmployeeUsername,emp_password as EmployeePassword from cinema.employee";
                DataSet d = f.GetData(sqlquery);
                EditEmpDetailsGridView.DataSource = d.Tables[0];
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                sqlquery = "select emp_id as EmployeeID,emp_name as EmployeeName, emp_phone as EmployeePhone,emp_dob as EmployeeDOB,emp_gender as EmployeeGender, emp_email as EmployeeEmail,emp_username as EmployeeUsername,emp_password as EmployeePassword from cinema.employee";
                DataSet d = f.GetData(sqlquery);
                DelEmpGridView.DataSource = d.Tables[0];
            }
        }

        private void EmpNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmpPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmpEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EmpEmailTextBox.Text, emailpattern) == true)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.EmpEmailTextBox, "Enter valid email address.");
                return;
            }
        }

        private void EmpUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EmpUsernameTextBox.Text, usernamepattern) == true)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.EmpUsernameTextBox, "Enter valid username. (Only alphabets and numbers are allowed)");
                return;
            }
        }

        private void EmpPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditEmpNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditEmpPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditEmpUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EditEmpUsernameTextBox.Text, usernamepattern) == true)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.EditEmpUsernameTextBox, "Enter valid username. (Only alphabets and numbers are allowed)");
                return;
            }
        }

        private void EditEmpEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EditEmpEmailTextBox.Text, emailpattern) == true)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.EditEmpEmailTextBox, "Enter valid email address.");
                return;
            }
        }

        private void EditEmpPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubmitEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EditEmpIDTextBox.Text) && !String.IsNullOrWhiteSpace(EditEmpNameTextBox.Text) && !String.IsNullOrWhiteSpace(EditEmpPhoneTextBox.Text) && !String.IsNullOrWhiteSpace(EditEmpGenderComBox.Text) && !String.IsNullOrWhiteSpace(EditEmpEmailTextBox.Text) && !String.IsNullOrWhiteSpace(EditEmpUsernameTextBox.Text) && !String.IsNullOrWhiteSpace(EditEmpPasswordTextBox.Text) && Regex.IsMatch(EditEmpEmailTextBox.Text, emailpattern) == true && Regex.IsMatch(EditEmpUsernameTextBox.Text, usernamepattern) == true && Regex.IsMatch(EditEmpPhoneTextBox.Text, phonepattern) == true && Regex.IsMatch(EditEmpPasswordTextBox.Text, passwordpattern) == true)
            {

                try
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    errorProvider3.Clear();
                    errorProvider4.Clear();
                    sqlquery = "update cinema.employee set emp_name = '" + EditEmpNameTextBox.Text + "',emp_phone = '" + EditEmpPhoneTextBox.Text + "',emp_dob = '"+EditEmpDob.Text+"',emp_gender = '" + EditEmpGenderComBox.Text + "',emp_email = '" + EditEmpEmailTextBox.Text + "',emp_username = '" + EditEmpUsernameTextBox.Text + "',emp_password = '" + EditEmpPasswordTextBox.Text + "' where emp_id = " + EditEmpIDTextBox.Text + "";
                    f.SetData(sqlquery, "Employee details have been edited.");
                    tabControl1_SelectedIndexChanged(this, null);
                    ClearAllFields();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Email or Username Already Exists, Enter a unique Email or Username.", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (Regex.IsMatch(EditEmpEmailTextBox.Text, emailpattern) == false)
                {
                    MessageBox.Show("Enter valid Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(EditEmpUsernameTextBox.Text, usernamepattern) == false)
                {
                    MessageBox.Show("Enter valid username. (Only alphabets and numbers are allowed)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(Regex.IsMatch(EditEmpPhoneTextBox.Text, phonepattern) == false)
                {
                    MessageBox.Show("Enter valid phone number (03331234567), Length should be 11", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Regex.IsMatch(EditEmpPasswordTextBox.Text, passwordpattern) == false)
                {
                    MessageBox.Show("Enter valid password. Minimum Length: 5", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Insert All Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void EditEmpDetailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && EditEmpDetailsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    EditEmpDetailsGridView.CurrentRow.Selected = true;
                    DataGridViewRow selrow = this.EditEmpDetailsGridView.Rows[e.RowIndex];
                    EditEmpIDTextBox.Text = selrow.Cells["EmployeeID"].FormattedValue.ToString();
                    EditEmpNameTextBox.Text = selrow.Cells["EmployeeName"].FormattedValue.ToString();
                    EditEmpPhoneTextBox.Text = selrow.Cells["EmployeePhone"].FormattedValue.ToString();
                    EditEmpDob.Text = selrow.Cells["EmployeeDOB"].FormattedValue.ToString();
                    EditEmpGenderComBox.Text = selrow.Cells["EmployeeGender"].FormattedValue.ToString();
                    EditEmpEmailTextBox.Text = selrow.Cells["EmployeeEmail"].FormattedValue.ToString();
                    EditEmpUsernameTextBox.Text = selrow.Cells["EmployeeUsername"].FormattedValue.ToString();
                    EditEmpPasswordTextBox.Text = selrow.Cells["EmployeePassword"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DelEmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && DelEmpGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DelEmpGridView.CurrentRow.Selected = true;
                DataGridViewRow selrow = this.DelEmpGridView.Rows[e.RowIndex];
                DelEmpIDTextBox.Text = selrow.Cells["EmployeeID"].FormattedValue.ToString();
                DelEmpNameTextBox.Text = selrow.Cells["EmployeeName"].FormattedValue.ToString();
            }
            }
            catch (Exception ex)
            {

            }
        }

        private void DelEmpButton_Click(object sender, EventArgs e)
        {
            if (DelEmpIDTextBox.Text != "" && DelEmpNameTextBox.Text != "")
            {
                if (MessageBox.Show("Delete Employee?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    sqlquery = "delete from cinema.employee where emp_id =" + DelEmpIDTextBox.Text + "";
                    f.SetData(sqlquery, "Employee Deleted.");
                    tabControl1_SelectedIndexChanged(this, null); //reload form
                    DelEmpIDTextBox.Clear();
                    DelEmpNameTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("No Employee is Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmployeeUC_Leave(object sender, EventArgs e)
        {
            ClearAllFields(); 
        }

        private void EmployeeUC_Load(object sender, EventArgs e)
        {

        }

        private void EmpPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EmpPhoneTextBox.Text, phonepattern) == true)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.EmpPhoneTextBox, "Enter valid phone number (03331234567), Length should be 11");
                return;
            }
        }

        private void EditEmpPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EditEmpPhoneTextBox.Text, phonepattern) == true)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.EditEmpPhoneTextBox, "Enter valid phone number (03331234567), Length should be 11");
                return;
            }
        }

        private void EmpPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EmpPasswordTextBox.Text, passwordpattern) == true)
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(this.EmpPasswordTextBox, "Enter valid password. Minimum Length: 5");
                return;
            }
        }

        private void EditEmpPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(EditEmpPasswordTextBox.Text, passwordpattern) == true)
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(this.EditEmpPasswordTextBox, "Enter valid password. Minimum Length: 5");
                return;
            }
        }

        private void EmpUsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditEmpUsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
