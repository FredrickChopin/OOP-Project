using System;
using static Project.GlobalVars;
using System.Windows.Forms;

namespace Project
{
    internal partial class FormEditLectureRoom : Project.FormAbstractEdit
    {

        private readonly LectureRoom lectureRoom;

        public FormEditLectureRoom()
        {
            InitializeComponent();
        }

        public FormEditLectureRoom(int roomIndex) : base(roomIndex)
        {
            InitializeComponent();
            lectureRoom = (LectureRoom)rooms[roomIndex];
        }

        private void FormEditLectureRoom_Load(object sender, EventArgs e)
        {
            LoadBasicRoomProperties();
            textBoxStudentCapacity.Text = lectureRoom.StudentCapacity.ToString();
            textBoxComputerAmount.Text = lectureRoom.ComputerAmount.ToString();
            if (lectureRoom.HasSlidesProjector)
            {
                radioBtnSlidesYes.Checked = true;
            }
            else
            {
                radioBtnSlidesNo.Checked = true;
            }
            if (lectureRoom.HasBuiltMicrophone)
            {
                radioButtonYesMic.Checked = true;
            }
            else
            {
                radioButtonNoMic.Checked = true;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (!SaveBasicProperties()) return;
            try
            {
                lectureRoom.ValidateAndUpdate(textBoxStudentCapacity, textBoxComputerAmount);
                lectureRoom.UpdateLectureRoomSpecificProperties(radioBtnSlidesYes, radioButtonYesMic);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
