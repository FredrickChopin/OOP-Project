using System;
using System.Windows.Forms;
using static Project.GlobalVars;

namespace Project
{
    partial class FormAddDormRoom : Form
    {

        private readonly Room underlyingRoom;

        public FormAddDormRoom(Room underlyingRoom)
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            this.underlyingRoom = underlyingRoom;
        }

        private void buttonSaveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                DormRoom dormRoom = new DormRoom(underlyingRoom, textBoxNumberOfBeds, textBoxMonthlyBills);
                rooms.Add(dormRoom);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
