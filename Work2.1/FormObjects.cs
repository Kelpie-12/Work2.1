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
				//	btnSaveClient.Enabled = btnSelect.Enabled = false;
				//	btnSearch.Enabled = btnEditClient.Enabled = btnDeleteClient.Enabled = btnAddNewClient.Enabled = true;
				tcObjects.TabPages.Remove(tabPageObjSearch);
				tcObjects.TabPages.Add(tabPageObjectSelect);
				selectObj = true;
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
			if (selectObj == true)
			{
				if (pictureBoxPhoto.Image == null)
					if (tbFlat.Text == string.Empty)
						obj.EditObject(null, Convert.ToInt32(lbIDObj.Text), lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text));
					else
						obj.EditObject(null, Convert.ToInt32(lbIDObj.Text), lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text));
				else
				{
					Bitmap image = new Bitmap(pictureBoxPhoto.Image);
					obj.EditObject(image, Convert.ToInt32(lbIDObj.Text), lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text));
				}
			}
			else
			{
				if (pictureBoxPhoto.Image == null)
					obj.AddNewObjects(null, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text));
				else
				{
					Bitmap image = new Bitmap(pictureBoxPhoto.Image);
					obj.AddNewObjects(image, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text));
				}

			}
			selectObj = false;
			tcObjects.TabPages.Remove(tabPageObjectSelect);
			tcObjects.TabPages.Add(tabPageObjSearch);
			LoadObject();
		}

		private void btnSelectPhpto_Click(object sender, EventArgs e)
		{

			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image files (*.jpg,*.jpeg,*.png) | *.jpg; *.jpeg; *.png ";
				openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
				}

			}
		}

		private void btnEditClient_Click(object sender, EventArgs e)
		{
			btnSelectManger.Enabled = true;
			if (selectObj == false)
			{
				btnSelectClient_Click(sender, e);
				//if (pictureBoxPhoto.Image != null)
				//{
				//	Bitmap image = new Bitmap(pictureBoxPhoto.Image);
				//	obj.EditObject(Convert.ToInt32(lbIDObj.Text), image, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text));
				//}
				//else
				//{
				//	obj.EditObject(Convert.ToInt32(lbIDObj.Text), null, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text));
				//
				//}
				//
				//tcObjects.TabPages.Remove(tabPageObjectSelect);
				//tcObjects.TabPages.Add(tabPageObjSearch);
				//selectObj = false;
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
	}
}
