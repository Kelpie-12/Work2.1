using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domen2;

namespace Work2._1
{
	public partial class FormProfil : Form
	{
		ClientModel clientModel = new ClientModel();
		public FormProfil()
		{
			InitializeComponent();
			LoadClient();
		}

		private void pBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void LoadClient()
		{
			dataGridViewClient.DataSource = clientModel.GetAllClient();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(tbSearch.Text);
			if (emptyValue)
				dataGridViewClient.DataSource = clientModel.GetAllClient();
			else
				dataGridViewClient.DataSource = clientModel.GetClient(tbSearch.Text);
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{			
			bool emptyValue = string.IsNullOrWhiteSpace(tbSearch.Text);
			if (emptyValue)
				dataGridViewClient.DataSource = clientModel.GetAllClient();
			else 
				dataGridViewClient.DataSource = clientModel.GetClient(tbSearch.Text);

			//dataGridViewClient.DataSource = clientModel.GetAllClient();
		}
	}
}
