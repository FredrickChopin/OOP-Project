using System;
using System.Windows.Forms;
using static Project.GlobalVars;

namespace Project
{
    partial class FormEditLab : FormAbstractEdit
    {

        private readonly Lab lab;

        public FormEditLab()
        {
            InitializeComponent();
        }

        public FormEditLab(int roomIndex) : base(roomIndex)
        {
            InitializeComponent();
            lab = (Lab)rooms[roomIndex];
        }

        private void FormUpdateLab_Load(object sender, EventArgs e)
        {
            LoadBasicRoomProperties();
            textBoxStudentCapacity.Text = lab.StudentCapacity.ToString();
            textBoxComputerAmount.Text = lab.ComputerAmount.ToString();
            textBoxLabName.Text = lab.LabName;
            textBoxMonthlyFunding.Text = lab.MonthlyFunding.ToString();
            textBoxLabEquipment.Text = lab.LabEquipment;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (!SaveBasicProperties()) return;
            try
            {
                lab.ValidateAndUpdate(textBoxStudentCapacity,
                   textBoxComputerAmount,
                   textBoxLabName,
                   textBoxMonthlyFunding,
                   textBoxLabEquipment);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
