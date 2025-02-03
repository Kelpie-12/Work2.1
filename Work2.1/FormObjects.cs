using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domen2;
using static System.Net.Mime.MediaTypeNames;

namespace Work2._1
{
	public partial class FormObjects : Form
	{
		ObjectsModel obj = new ObjectsModel();
		bool selectObj, selectMan;
		public FormObjects()
		{
			InitializeComponent();
			LoadObject();
			tcObjects.TabPages.Remove(tabPageObjectSelect);
			tcObjects.TabPages.Remove(tabPageSelectManager);
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(tbSearch.Text);
			if (emptyValue)
				LoadObject();
			else
				dataGridViewObject.DataSource = obj.GetObjectByValue(tbSearch.Text);
		}
		void LoadObject()
		{
			dataGridViewObject.DataSource = obj.GetAllObject();
			cbTipObj.DataSource = obj.GetTypeObjects();
			cbTipObj.DisplayMember = "name";
			cbTipObj.ValueMember = "id";
		}

		private void pBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSelectClient_Click(object sender, EventArgs e)
		{

			if (selectMan == true)
			{
				tcObjects.TabPages.Remove(tabPageSelectManager);
				tcObjects.TabPages.Add(tabPageObjectSelect);
				lbMan.Text = dGVMS.SelectedRows[0].Cells[2].Value.ToString();
				btnEditClient.Enabled = false;
				selectMan = false;
				btnSaveClient.Enabled = true;
			}
			else
			{
				lbIDObj.Text = dataGridViewObject.SelectedRows[0].Cells[0].Value.ToString();
				lbMan.Text = dataGridViewObject.SelectedRows[0].Cells[1].Value.ToString();
				tbText.Text = dataGridViewObject.SelectedRows[0].Cells[2].Value.ToString();
				tbCiti.Text = dataGridViewObject.SelectedRows[0].Cells[3].Value.ToString();
				tbStreet.Text = dataGridViewObject.SelectedRows[0].Cells[4].Value.ToString();
				tbHome.Text = dataGridViewObject.SelectedRows[0].Cells[5].Value.ToString();
				tbFlat.Text = dataGridViewObject.SelectedRows[0].Cells[6].Value.ToString();
				tbText.ReadOnly = tbCiti.ReadOnly = tbStreet.ReadOnly = tbHome.ReadOnly = tbFlat.ReadOnly = true;
				btnSaveClient.Enabled = false;
				tcObjects.TabPages.Remove(tabPageObjSearch);
				tcObjects.TabPages.Add(tabPageObjectSelect);
				selectObj = true;
				GetIndexTypeObjects(dataGridViewObject.SelectedRows[0].Cells[7].Value.ToString());
				
				if (UserLoginCache.Position == Positions.Manager)
					btnSelectManger.Visible = false;
				else
					btnSelectManger.Visible = true;
			}
			btnSelect.Enabled = btnAddNewClient.Enabled = false;
			btnSearch.Enabled = btnDeleteClient.Enabled = true;
		}

		private void btnSaveClient_Click(object sender, EventArgs e)
		{
			if (lbMan.Text == string.Empty)
				MessageBox.Show("Выбирите менеджера");
			else
			{
				if (selectObj == true)
				{
					if (tbFlat.Text == string.Empty)
						obj.EditObject(null, Convert.ToInt32(lbIDObj.Text), lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(cbTipObj.SelectedValue));
					else
						obj.EditObject(null, Convert.ToInt32(lbIDObj.Text), lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(cbTipObj.SelectedValue), Convert.ToInt32(tbFlat.Text));
				}
				else
				{
					if (tbFlat.Text == string.Empty)
						obj.AddNewObjects(null, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(cbTipObj.SelectedValue));
					else
						obj.AddNewObjects(null, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(cbTipObj.SelectedValue), Convert.ToInt32(tbFlat.Text));
				}
				selectObj = false;
				LoadObject();
				btnSearch_Click(sender, e);
			}
		}

		private void btnSelectPhpto_Click(object sender, EventArgs e)
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image files (*.jpg,*.jpeg,*.png) | *.jpg; *.jpeg; *.png ";
				openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//pictureBoxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
				}

			}
		}

		private void btnEditClient_Click(object sender, EventArgs e)
		{
			btnSelectManger.Enabled = true;
			if (selectObj == false)
			{
				btnSelectClient_Click(sender, e);
			}
			tbText.ReadOnly = tbCiti.ReadOnly = tbStreet.ReadOnly = tbHome.ReadOnly = tbFlat.ReadOnly = false;
			btnEditClient.Enabled = false; btnSaveClient.Enabled = true;
		}

		private void btnSelectManger_Click(object sender, EventArgs e)
		{
			tcObjects.TabPages.Remove(tabPageObjectSelect);
			tcObjects.TabPages.Add(tabPageSelectManager);
			btnSearch.Enabled = btnAddNewClient.Enabled = btnDeleteClient.Enabled = btnSaveClient.Enabled = btnEditClient.Enabled = false;
			btnSelect.Enabled = true;
			bool emptyValue = string.IsNullOrWhiteSpace(tbMangerSearch.Text);
			if (emptyValue)
				dGVMS.DataSource = obj.GetAllManager();
			else
				dGVMS.DataSource = obj.GetManagerByValue(tbMangerSearch.Text);
			selectMan = true;
		}



		private void btnSearch_Click(object sender, EventArgs e)
		{
			btnSelectManger.Enabled = false;
			btnSelectManger.Enabled = btnSearch.Enabled = btnSaveClient.Enabled = false;
			btnAddNewClient.Enabled = btnDeleteClient.Enabled = btnEditClient.Enabled = btnSelect.Enabled = true;
			tbCiti.Clear(); tbFlat.Clear(); tbHome.Clear(); tbStreet.Clear(); tbText.Clear();
			tcObjects.TabPages.Remove(tabPageObjectSelect);
			tcObjects.TabPages.Add(tabPageObjSearch);

		}

		private void btnAddNewClient_Click(object sender, EventArgs e)
		{
			if (UserLoginCache.Position == Positions.Manager)
			{
				btnSelectManger.Visible = false;
				lbMan.Text = UserLoginCache.LastName;
			}
			tbText.ReadOnly = tbCiti.ReadOnly = tbStreet.ReadOnly = tbHome.ReadOnly = tbFlat.ReadOnly = false;
			btnSelectManger.Enabled = btnSearch.Enabled = btnSaveClient.Enabled = true;
			btnAddNewClient.Enabled = btnDeleteClient.Enabled = btnEditClient.Enabled = btnSelect.Enabled = false;
			tbCiti.Clear(); tbFlat.Clear(); tbHome.Clear(); tbStreet.Clear(); tbText.Clear();
			tcObjects.TabPages.Remove(tabPageObjSearch);
			tcObjects.TabPages.Add(tabPageObjectSelect);

		}

		private void tbFlat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9')
				if (tbFlat.Text.Length >= 0 && tbFlat.Text.Length <= 4)
					return;
			if (Char.IsControl(e.KeyChar))
				if (e.KeyChar == (char)Keys.Back)
					return;
			e.Handled = true;
		}

		private void btnDeleteClient_Click(object sender, EventArgs e)
		{
			if (selectObj == true)
			{
				obj.DeleteObjects(Convert.ToInt32(lbIDObj.Text));
				btnSearch_Click(sender, e);
			}
			else
			{
				obj.DeleteObjects(Convert.ToInt32(dataGridViewObject.SelectedRows[0].Cells[0].Value));
				LoadObject();
			}
		}

		private int GetIndexTypeObjects(string t)
		{
			
			for (int i = 0; i < cbTipObj.Items.Count; i++)
			{
				cbTipObj.SelectedIndex = i;
				if (cbTipObj.GetItemText(cbTipObj.SelectedItem) == t)
				{
					cbTipObj.SelectedIndex = i;
					return i;
				}
			}
			return -1;

		}
	}
}
