using Common.Cache;
using Domen2;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2._1
{
    public partial class FormObjects : Form
    {
        ObjectsModel obj = new ObjectsModel();
        bool selectObj, selectMan, selectClient, filter, filt;
        string filtersql;
        int typeSearch = -1, id_man = -1, id_client = -1;
        public FormObjects()
        {
            InitializeComponent();
            //LoadObjectType(cbTipObj);
            LoadFilter();
            dataGridViewObject.DataSource = obj.GetAllObject();
            tcObjects.TabPages.Remove(tabPageObjectSelect);
            tcObjects.TabPages.Remove(tabPageSelectManager);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string[] values = (sender as TextBox).Text.Split(' ');
            if (values.Length > 1)
                values = values.Where(v => v != "").ToArray();
            switch (values.Length)
            {
                case 1:
                    {
                        if (typeSearch == -1)
                        {
                            (dataGridViewObject.DataSource as DataTable).DefaultView.RowFilter =
                                string.Format("(Менеджер like '{0}%' or [Тип объекта] like '{0}%')", values[0]);
                        }
                        else //if (typeSearch == 0)
                        {
                            (dataGridViewObject.DataSource as DataTable).DefaultView.RowFilter =
                                string.Format("(Город like '{0}%' or [Улица] like '{0}%')", values[0]);

                        }
                        break;
                    }
                case 2:
                    {
                        if (typeSearch == -1)
                        {
                            (dataGridViewObject.DataSource as DataTable).DefaultView.RowFilter =
                                string.Format("(Менеджер like '{0}%' or [Тип объекта] like '{0}%') and (Менеджер like '{1}%' or [Тип объекта] like '{1}%')", values[0], values[1]);
                        }
                        else
                        {
                            (dataGridViewObject.DataSource as DataTable).DefaultView.RowFilter =
                                string.Format("(Город like '{0}%' or [Улица] like '{0}%') and (Город like '{1}%' or [Улица] like '{1}%')", values[0], values[1]);

                        }
                        break;
                    }
            }
        }
        void LoadObjectType(ComboBox cb)
        {
            //dataGridViewObject.DataSource = obj.GetAllObject();
            cb.DataSource = obj.GetTypeObjects();
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
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
                id_man = Convert.ToInt32(dGVMS.SelectedRows[0].Cells[0].Value);
                btnEditClient.Enabled = false;
                selectMan = false;
                btnSaveClient.Enabled = true;
            }
            else if (selectClient == true)
            {
                tcObjects.TabPages.Remove(tabPageSelectManager);
                tcObjects.TabPages.Add(tabPageObjectSelect);
                LabClient.Text = dGVMS.SelectedRows[0].Cells[2].Value.ToString();
                id_client = Convert.ToInt32(dGVMS.SelectedRows[0].Cells[0].Value);
                btnEditClient.Enabled = false;
                selectClient = false;
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
            {
                MessageBox.Show("Выбирите менеджера");
                return;
            }
            if (lbClient.Text == string.Empty)
            {
                MessageBox.Show("Выбирите клиента");
                return;
            }
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
                    if (cbTipObj.SelectedIndex == 0)//квартира
                    {
                        obj.AddNewApartments(obj.AddNewObjects(id_man, Convert.ToInt32(cbTipObj.GetItemText(cbTipObj.SelectedIndex)), Convert.ToInt32(cbOfferType.GetItemText(cbOfferType.SelectedIndex)) + 1, id_client),
                            tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbFlat.Text), Convert.ToInt32(tbFloor.Text), Convert.ToInt32(tbAreaHouse.Text), Convert.ToInt32(tbRooms.Text), Convert.ToInt32(tbPrice.Text), tbText.Text);
                    }
                    else if (cbTipObj.SelectedIndex == 1)//дом
                    {
                        obj.AddNewHouse(obj.AddNewObjects(id_man, Convert.ToInt32(cbTipObj.GetItemText(cbTipObj.SelectedIndex)), Convert.ToInt32(cbOfferType.GetItemText(cbOfferType.SelectedIndex)) + 1, id_client),
                            tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(tbHouseAreaH.Text), Convert.ToInt32(tbAreaPlotH.Text), Convert.ToInt32(tbFloorH.Text), Convert.ToInt32(tbRoomsH.Text), Convert.ToInt32(tbPrice.Text), tbText.Text);
                    }
                    else if (cbTipObj.SelectedIndex == 3)//земельный участок
                    {

                    }
                    else if (cbTipObj.SelectedIndex == 4)//Коммерческая недвижимость
                    {

                    }
                    else if (cbTipObj.SelectedIndex == 5)//гараж
                    {

                    }
                    else if (cbTipObj.SelectedIndex == 6)//дача
                    {

                    }
                    //if (tbFlat.Text == string.Empty)
                    //	obj.AddNewObjects(null, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(cbTipObj.SelectedValue));
                    //else
                    //	obj.AddNewObjects(null, lbMan.Text, tbText.Text, tbCiti.Text, tbStreet.Text, Convert.ToInt32(tbHome.Text), Convert.ToInt32(cbTipObj.SelectedValue), Convert.ToInt32(tbFlat.Text));
                }
                selectObj = cbTipObj.Enabled = false;
                dataGridViewObject.DataSource = obj.GetAllObject();
                LoadObjectType(cbTipObj);
                btnSearch_Click(sender, e);
            }
        }


        private void btnSelectPhpto_Click(object sender, EventArgs e)
        {
            FormViewPhoro form = new FormViewPhoro();
            form.TopMost = true;
            form.Show();
            //using (var openFileDialog = new OpenFileDialog())
            //{
            //	openFileDialog.Filter = "Image files (*.jpg,*.jpeg,*.png) | *.jpg; *.jpeg; *.png ";
            //	openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //	if (openFileDialog.ShowDialog() == DialogResult.OK)
            //	{
            //		//pictureBoxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            //	}
            //
            //}
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            btnSelectManger.Enabled = cbTipObj.Enabled = true;

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
            dGVMS.DataSource = obj.GetAllManager();
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
            cbTipObj.Enabled = true;

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
                LoadObjectType(cbTipObj);
                dataGridViewObject.DataSource = obj.GetAllObject();
            }
        }

        private void FormObjects_Load(object sender, EventArgs e)
        {

        }

        private void cbTipObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            tLPDacha.Visible = cbComercialObject.Visible = tLPComercial.Visible = tLPLand.Visible = tLPAppartments.Visible = tLPHouse.Visible = false;
            if (cbTipObj.SelectedIndex == 0)//квартира
            {
                tLPAppartments.Visible = true;
            }
            else if (cbTipObj.SelectedIndex == 1)//дом
            {
                tLPHouse.Visible = true;
            }
            else if (cbTipObj.SelectedIndex == 2)//земля
            {
                tLPLand.Visible = true;
            }
            else if (cbTipObj.SelectedIndex == 3)//комерция
            {
                tLPComercial.Visible = true;
                cbComercialObject.Visible = true;
                cbComercialObject.DataSource = obj.GetCommercialObjectType();
                cbComercialObject.DisplayMember = "name";
                cbComercialObject.ValueMember = "id";
            }
            else if (cbTipObj.SelectedIndex == 4)//гараж
            {

            }
            else if (cbTipObj.SelectedIndex == 5)//дача
            {
                tLPDacha.Visible = true;
            }
        }

        private void btnSelectClient_Click_1(object sender, EventArgs e)
        {
            tcObjects.TabPages.Remove(tabPageObjectSelect);
            tcObjects.TabPages.Add(tabPageSelectManager);
            btnSearch.Enabled = btnAddNewClient.Enabled = btnDeleteClient.Enabled = btnSaveClient.Enabled = btnEditClient.Enabled = false;
            btnSelect.Enabled = true;
            selectClient = true;
            dGVMS.DataSource = null;
            dGVMS.DataSource = obj.GetAllClient();
        }

        private void tbMangerSearch_TextChanged(object sender, EventArgs e)
        {
            string[] values = (sender as TextBox).Text.Split(' ');
            if (values.Length > 1)
                values = values.Where(v => v != "").ToArray();
            switch (values.Length)
            {
                case 1:
                    {
                        (dGVMS.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(Фамилия like '{0}%') or (Имя like '{0}%')", values[0]); //searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;
                        break;
                    }
                case 2:
                    {
                        (dGVMS.DataSource as DataTable).DefaultView.RowFilter =
                            string.Format("(Фамилия like '{0}%' or Имя like '{0}%') and (Фамилия like '{1}%' or Имя like '{1}%')", values[0], values[1]); //searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;

                        break;
                    }//searchPattern = $"((last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%')) AND (first_name LIKE  ('{values[1]}%') OR middle_name LIKE ('{values[1]}%')))"; break;
                     //case 3: searchPattern = $"(last_name LIKE ('{values[0]}%') AND first_name LIKE ('{values[1]}%') OR middle_name LIKE ('{values[2]}%'))"; break;
            }
        }

        private void btnRefreshFilter_Click(object sender, EventArgs e)
        {
            dataGridViewObject.DataSource = obj.GetAllObject();
            typeSearch = -1;
        }

        //private void cLBFilterSarch_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //	int index = 0;
        //	for (int i = 0; i < cLBFilterSarch.Items.Count; i++)
        //	{
        //		if (cLBFilterSarch.GetItemChecked(i))
        //		{
        //			index++;
        //			//if (filt == true && i != cLBFilterSarch.Items.Count-1)
        //			//{
        //			//	filtersql += " or ";
        //			//}
        //			//if (filt == false)
        //			//	filtersql += " and ";
        //			//filt = true;
        //			//filtersql += $" (TypeObjects.id = {i})";
        //		}
        //	}
        //	dataGridViewObject.DataSource = obj.GetAllObject();
        //	(dataGridViewObject.DataSource as DataTable).DefaultView.RowFilter =
        //		string.Format("(Тип like '{0}%') ", "Квартира");//and (Тип like '{0}%')
        //	filtersql = string.Empty;
        //}
        private void LoadFilter()
        {
            //BindingSource type = new BindingSource();
            //var d=(dataGridViewObject.DataSource as DataTable).Columns[7].Table;
            //type.DataSource = d;
            //cbFilterType.DataSource = d;
            LoadObjectType(cbFilterType);
            LoadObjectType(cbTipObj);
            cbOfferType.DataSource = cbFilter.DataSource = obj.GetOfferType();
            cbOfferType.DisplayMember = cbFilter.DisplayMember = "name";
            cbOfferType.ValueMember = cbFilter.ValueMember = "id";

        }
        private async void bntFilter_Click(object sender, EventArgs e)
        {
            if (panelFilter.Location.Y < 15)
            {
                while (panelFilter.Location.Y < 15)
                {
                    await Task.Delay(1);
                    panelFilter.Location = new Point(panelFilter.Location.X, panelFilter.Location.Y + 10);
                    filter = true;
                }
            }
            else
            {
                while (panelFilter.Location.Y > -150)
                {
                    await Task.Delay(1);
                    panelFilter.Location = new Point(panelFilter.Location.X, panelFilter.Location.Y - 10);
                    filter = false;
                }
                dataGridViewObject.DataSource = obj.GetObjectsByType(Convert.ToInt32(cbFilterType.GetItemText(cbFilterType.SelectedIndex)), Convert.ToInt32(cbFilter.GetItemText(cbFilter.SelectedIndex)) + 1);

                //typeSearch = Convert.ToInt32(cbFilterType.GetItemText(cbFilterType.SelectedIndex));

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
