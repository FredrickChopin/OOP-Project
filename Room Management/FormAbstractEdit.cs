using System;
using static Project.GlobalVars;
using System.Windows.Forms;

namespace Project
{
    partial class FormAbstractEdit : Form
    {

        protected int roomIndex;
        private readonly Room room;

        public FormAbstractEdit()
        {
            InitializeComponent();
        }

        public FormAbstractEdit(int roomIndex)
        {
            InitializeComponent();
            this.roomIndex = roomIndex;
            room = rooms[roomIndex];
        }

        protected void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            rooms.RemoveAt(roomIndex);
            this.DialogResult = DialogResult.OK;
        }

        protected bool SaveBasicProperties()
        {
            try
            {
                room.ValidateAndUpdate(textBoxRoomNumber, textBoxFloorNumber, textBoxSize, textBoxLocation);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        protected void LoadBasicRoomProperties()
        {
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            textBoxRoomNumber.Text = room.RoomNumber.ToString();
            textBoxFloorNumber.Text = room.FloorNumber.ToString();
            textBoxSize.Text = room.Size.ToString();
            textBoxLocation.Text = room.Location;
        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
