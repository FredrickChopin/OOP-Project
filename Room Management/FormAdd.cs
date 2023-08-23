using System;
using System.Windows.Forms;


namespace Project
{
    partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        //The formCreatorFunction is necessary, since currently C# does not support
        //Type constraints where the type has to have a constructor which receives a certain type
        private void HandleSpecificRoomProperties<FormType>(Func<Room, FormType> formCreatorFunction) where FormType : Form
        {
            try
            {
                Room tempRoom = new Room(textBoxRoomNumber, textBoxFloorNumber, textBoxSize, textBoxLocation);
                FormType formAdd = formCreatorFunction(tempRoom);
                DialogResult result = formAdd.ShowDialog();
                if (result == DialogResult.OK) this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonDormRoom_Click(object sender, EventArgs e)
        {
            HandleSpecificRoomProperties((room) => new FormAddDormRoom(room));
        }

        private void buttonLab_Click(object sender, EventArgs e)
        {
            HandleSpecificRoomProperties((room) => new FormAddLab(room));
        }

        private void buttonLectureRoom_Click(object sender, EventArgs e)
        {
            HandleSpecificRoomProperties((room) => new FormAddLectureRoom(room));
        }
    }
}
