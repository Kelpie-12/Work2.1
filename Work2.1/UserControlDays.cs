using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2._1
{
	public partial class UserControlDays : UserControl
	{
		public UserControlDays()
		{
			InitializeComponent();
		}
		public void Days(int day)
		{
			lbDays.Text=day.ToString();
		}
	}
}
