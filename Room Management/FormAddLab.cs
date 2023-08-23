using System;
using static Project.GlobalVars;
using System.Windows.Forms;

namespace Project
{
    partial class FormAddLab : Form
    {

        private readonly Room underlyingRoom;

        public FormAddLab(Room underlyingRoom)
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            this.underlyingRoom = underlyingRoom;
        }

        private void buttonSaveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                Lab dormRoom = new Lab(underlyingRoom, 
                    textBoxStudentCapacity, 
                    textBoxComputerAmount,
                    textBoxLabName,
                    textBoxMonthlyFunding,
                    textBoxLabEquipment);
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
