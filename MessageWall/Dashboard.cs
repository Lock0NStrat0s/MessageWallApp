using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            _lstbMessages.DataSource = messages;
            //_lstbMessages.DisplayMember = nameof(Dashboard.Text);
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtbMessage.Text))
            {
                MessageBox.Show("Please enter a message.", "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(_txtbMessage.Text);
                _txtbMessage.Text = "";
            }

            _txtbMessage.Focus();
        }
    }
}
