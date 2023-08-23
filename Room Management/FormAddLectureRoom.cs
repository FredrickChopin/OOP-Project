using System;
using static Project.GlobalVars;
using System.Windows.Forms;

namespace Project
{
    partial class FormAddLectureRoom : Form
    {

        private readonly Room underlyingRoom;

        public FormAddLectureRoom(Room underlyingRoom)
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            this.underlyingRoom = underlyingRoom;
        }

        private void buttonSaveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                LectureRoom lectureRoom = new LectureRoom(underlyingRoom,
                    textBoxStudentCapacity,
                    textBoxComputerAmount,
                    radioBtnSlidesYes,
                    radioButtonYesMic);
                rooms.Add(lectureRoom);
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
