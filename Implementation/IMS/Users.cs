using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
	public partial class Users : Sample2
	{
		int edit = 0; //this 0 is indication operation to save and 1 is to update.
		int userID;
		short stat;
		public Users()
		{
			InitializeComponent();
		}

		retrieval r = new retrieval();

		private void Users_Load(object sender, EventArgs e)
		{
			MainClass.disable_reset(leftPanel);

		}

		public override void addBtn_Click(object sender, EventArgs e)
		{
			MainClass.enable_reset(leftPanel);
			edit = 0;
		}

		public override void editBtn_Click(object sender, EventArgs e)
		{
			edit = 1;
			MainClass.enable(leftPanel);
		}

		public override void saveBtn_Click(object sender, EventArgs e)
		{
			if(nameTxt.Text == ""){nameErrorLabel.Visible = true;}
			else {nameErrorLabel.Visible = false;}

			if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; }
			else { usernameErrorLabel.Visible = false; }

			if (passTxt.Text == "") { passErrorLabel.Visible = true; }
			else { passErrorLabel.Visible = false; }

			if (emailTxt.Text == "") { emailErrorLabel.Visible = true; }
			else { emailErrorLabel.Visible = false; }

			if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; }
			else { phoneErrorLabel.Visible = false; }

			if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; }
			else { statusErrorLabel.Visible = false; }

			if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passErrorLabel.Visible || emailErrorLabel.Visible || phoneErrorLabel.Visible || statusErrorLabel.Visible)
			{
				MainClass.ShowMSG("Fields with * are mandatory", "Stop","Error");//Error is the type of message.
			}
			else
			{
				if (statusDD.SelectedIndex == 0)
				{
					stat = 1;
				}
				else if (statusDD.SelectedIndex == 1)
				{
					stat = 0;
				}
				if (edit == 0)//code for SAVE operation.
				{
					insertion i = new insertion();
					i.insertUser(nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
					r.showUsers(dataGridView1, userIDGV, NameGV, USerNameGV, PassGV, EmailGV, PhoneGV, statusGV);
					MainClass.disable_reset(leftPanel);
				}
				else if(edit == 1)//code for UPDATE operation.
				{
					DialogResult dr = MessageBox.Show("Are you sure , you want to update record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (dr == DialogResult.Yes)
					{
						updation u = new updation();
						if (statusDD.SelectedIndex == 0)
						{
							stat = 1;
						}
						else if (statusDD.SelectedIndex == 1)
						{
							stat = 0;
						}
						u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
						r.showUsers(dataGridView1, userIDGV, NameGV, USerNameGV, PassGV, EmailGV, PhoneGV, statusGV);
						MainClass.disable_reset(leftPanel);
					}

				}
			}
		}

		public override void deleteBtn_Click(object sender, EventArgs e)
		{
			if(edit == 1)
			{
				DialogResult dr = MessageBox.Show("Are you sure , you want to delete record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					deletion d = new deletion();
					d.delete(userID, "st_deleteUser", "@id");
					r.showUsers(dataGridView1, userIDGV, NameGV, USerNameGV, PassGV, EmailGV, PhoneGV, statusGV);
				}
			}
		}

		public override void searchTxt_TextChanged(object sender, EventArgs e)
		{
			if (searchTxt.Text != "")
			{
				r.showUsers(dataGridView1, userIDGV, NameGV, USerNameGV, PassGV, EmailGV, PhoneGV, statusGV,searchTxt.Text);
			}
			else
			{
				r.showUsers(dataGridView1, userIDGV, NameGV, USerNameGV, PassGV, EmailGV, PhoneGV, statusGV);
			}
		}

		public override void viewBtn_Click(object sender, EventArgs e)
		{
			r.showUsers(dataGridView1, userIDGV, NameGV, USerNameGV, PassGV, EmailGV, PhoneGV, statusGV);
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				edit = 1;
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
				nameTxt.Text = row.Cells["NameGV"].Value.ToString();
				usernameTxt.Text = row.Cells["USerNameGV"].Value.ToString();
				passTxt.Text = row.Cells["PassGV"].Value.ToString();
				phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
				emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
				statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
				MainClass.disable(leftPanel);
			}
		}
	}
}
