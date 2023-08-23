using System;
using System.Windows.Forms;
using static Project.GlobalVars;

namespace Project
{
    partial class FormEditDormRoom : FormAbstractEdit
    {

        private readonly DormRoom dormRoom;

        public FormEditDormRoom(int roomIndex) : base(roomIndex)
        {
            InitializeComponent();
            dormRoom = (DormRoom)rooms[roomIndex];
        }

        protected void FormEdit_Load(object sender, EventArgs e)
        {
            LoadBasicRoomProperties();
            textBoxNumberOfBeds.Text = dormRoom.NumberOfBeds.ToString();
            textBoxMonthlyBills.Text = dormRoom.MonthlyBills.ToString();
        }
        
        protected void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (!SaveBasicProperties()) return;
            try
            {
                dormRoom.ValidateAndUpdate(textBoxNumberOfBeds, textBoxMonthlyBills);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
