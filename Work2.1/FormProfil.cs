using Domen2;
using System;
using System.Windows.Forms;
using Common.Cache;
namespace Work2._1
{
	public partial class FormProfil : Form
	{
		ClientModel clientModel = new ClientModel();
		bool addNewClient;
		public FormProfil()
		{
			InitializeComponent();
			LoadClient();
			tabControlProfil.TabPages.Remove(tPageProfil);

		}

		private void pBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void LoadClient()
		{
			dataGridViewClient.DataSource = clientModel.GetAllClient();
		}
		void LoadManager()
		{
			cBoxClientManager.DataSource = clientModel.GetClientManager();
			cBoxClientManager.DisplayMember = "LastName";
			cBoxClientManager.ValueMember = "Id";
			cBoxClientManager.Text = "Выберите менeджера";
			cBoxClientManager.SelectedIndex = -1;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			tabControlProfil.TabPages.Remove(tPageProfil);
			tabControlProfil.TabPages.Add(tPageSearch);
			btnSearch.Enabled = btnEditClient.Enabled = btnDeleteClient.Enabled = false;
			btnAddNewClient.Enabled = btnSelectClient.Enabled = true;
			LoadClient();
			lbClient.Text = "Поиск клента";

			//bool emptyValue = string.IsNullOrWhiteSpace(tbSearch.Text);
			//if (emptyValue)
			//	dataGridViewClient.DataSource = clientModel.GetAllClient();
			//else
			//	dataGridViewClient.DataSource = clientModel.GetClient(tbSearch.Text);
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(tbSearch.Text);
			if (emptyValue)
				LoadClient();
			else
				dataGridViewClient.DataSource = clientModel.GetClient(tbSearch.Text);

		}

		private void btnSelectClient_Click(object sender, EventArgs e)
		{
			LoadManager();
			DataGridViewRow row = new DataGridViewRow();
			row = dataGridViewClient.SelectedRows[0];
			ClientCache.IdClient = Convert.ToInt32(row.Cells[0].Value);
			ClientCache.ClientName = tBoxCiientFName.Text = row.Cells[1].Value.ToString();
			ClientCache.ClientLast = tbClientLast.Text = row.Cells[2].Value.ToString();
			ClientCache.ClientManager = row.Cells[3].Value.ToString();
			ClientCache.ClientTelNumber = tbClientTelNumber.Text = row.Cells[4].Value.ToString();
			//именить фамилию на нужную		
			tabControlProfil.TabPages.Remove(tPageSearch);
			tabControlProfil.TabPages.Add(tPageProfil);
			for (int i = 0; i < cBoxClientManager.Items.Count; i++)
			{
				cBoxClientManager.SelectedIndex = i;
				if (cBoxClientManager.GetItemText(cBoxClientManager.SelectedItem) == ClientCache.ClientManager)
				{
					cBoxClientManager.SelectedIndex = i;
					break;
				}
			}
			btnSearch.Enabled = btnEditClient.Enabled = btnDeleteClient.Enabled = true;
			btnAddNewClient.Enabled = btnSelectClient.Enabled = false;
			//btnSaveClient.Enabled = true;

		}

		private void btnAddNewClient_Click(object sender, EventArgs e)
		{
			tabControlProfil.TabPages.Remove(tPageSearch);
			tabControlProfil.TabPages.Add(tPageProfil);
			LoadManager();
			tBoxCiientFName.ReadOnly = tbClientLast.ReadOnly = tbClientTelNumber.ReadOnly = false;
			tbClientLast.Clear(); tBoxCiientFName.Clear(); tbClientTelNumber.Clear();
			cBoxClientManager.SelectedIndex = -1;
			btnSaveClient.Enabled = btnSearch.Enabled = true;
			btnEditClient.Enabled = btnSelectClient.Enabled = btnDeleteClient.Enabled = btnAddNewClient.Enabled = false;
			lbClient.Text = "Додавить нового клента";
			addNewClient = true;
		}

		private void btnEditClient_Click(object sender, EventArgs e)
		{
			btnSaveClient.Enabled = true;
			btnEditClient.Enabled = btnSearch.Enabled = false;
			tBoxCiientFName.ReadOnly = tbClientLast.ReadOnly = tbClientTelNumber.ReadOnly = false;
			lbClient.Text = "Изменить данные клента";
		}

		private void btnSaveClient_Click(object sender, EventArgs e)
		{
			if (addNewClient == true)
				clientModel.AddNewClient(tBoxCiientFName.Text, tbClientLast.Text, cBoxClientManager.SelectedValue.ToString(), tbClientTelNumber.Text);
			else
				clientModel.EditClient(ClientCache.IdClient, tBoxCiientFName.Text, tbClientLast.Text, cBoxClientManager.SelectedValue.ToString(), tbClientTelNumber.Text);
			addNewClient = false;
			btnSaveClient.Enabled = false;
			btnEditClient.Enabled = btnSearch.Enabled = true;
			tBoxCiientFName.ReadOnly = tbClientLast.ReadOnly = tbClientTelNumber.ReadOnly = true;
		}

		private void btnDeleteClient_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show($"Удалить клиента {ClientCache.ClientName}  {ClientCache.ClientLast}?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				clientModel.DeleteClient(ClientCache.IdClient);
				tabControlProfil.TabPages.Remove(tPageProfil);
				tabControlProfil.TabPages.Add(tPageSearch);
				btnSearch.Enabled = btnEditClient.Enabled = btnDeleteClient.Enabled = false;
				btnAddNewClient.Enabled = btnSelectClient.Enabled = true;
				LoadClient();
				lbClient.Text = "Поиск клента";
			}
		}

		private void tbClientTelNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9' || (e.KeyChar == '+'))
				if (tbClientTelNumber.Text.Length >= 0 && tbClientTelNumber.Text.Length <= 11)
					return;
			if (Char.IsControl(e.KeyChar))
				if (e.KeyChar == (char)Keys.Back)
					return;
			e.Handled = true;
		}

		
	}
}
