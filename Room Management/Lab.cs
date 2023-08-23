using System;
using System.Windows.Forms;
using static Project.Utilities;

namespace Project
{
    [Serializable]
    class Lab : EducationalRoom
    {
        protected string labName;
        protected int monthlyFunding;
        protected string labEquipment;

        public Lab(Room roomToCopy,
                   TextBox textBoxStudentCapacity,
                   TextBox textBoxComputerAmount,
                   TextBox textBoxLabName,
                   TextBox textBoxMonthlyFunding,
                   TextBox textBoxLabEquipment) : base(roomToCopy, textBoxStudentCapacity, textBoxComputerAmount)
        {
            ValidateUserInput(textBoxMonthlyFunding);
            ValidateLabSpecificProperties(textBoxLabName, textBoxMonthlyFunding, textBoxLabEquipment);
        }

        public void ValidateAndUpdate(TextBox textBoxStudentCapacity,
                   TextBox textBoxComputerAmount,
                   TextBox textBoxLabName,
                   TextBox textBoxMonthlyFunding,
                   TextBox textBoxLabEquipment)
        {
            ValidateUserInput(textBoxStudentCapacity, textBoxComputerAmount);
            UpdateProperties(textBoxStudentCapacity,
                             textBoxComputerAmount,
                             textBoxLabName,
                             textBoxMonthlyFunding,
                             textBoxLabEquipment);
        }

        public void UpdateProperties(TextBox textBoxStudentCapacity,
                   TextBox textBoxComputerAmount,
                   TextBox textBoxLabName,
                   TextBox textBoxMonthlyFunding,
                   TextBox textBoxLabEquipment)
        {
            base.UpdateProperties(textBoxStudentCapacity, textBoxComputerAmount);
            ValidateLabSpecificProperties(textBoxLabName, textBoxMonthlyFunding, textBoxLabEquipment);
        }

        public void ValidateLabSpecificProperties(TextBox textBoxLabName,
                   TextBox textBoxMonthlyFunding,
                   TextBox textBoxLabEquipment)
        {
            LabEquipment = textBoxLabEquipment.Text;
            LabName = textBoxLabName.Text;
            MonthlyFunding = int.Parse(textBoxMonthlyFunding.Text);
        }

        public void ValidateUserInput(TextBox textBoxMonthlyFunding)
        {
            ValidateProperty(textBoxMonthlyFunding, "Monthly funding must be an integer", (box) => IsInt(box.Text));
        }

        public string LabName { get => labName; set => labName = value; }

        public int MonthlyFunding { get => monthlyFunding; set => monthlyFunding = value; }

        public string LabEquipment { get => labEquipment; set => labEquipment = value; }

    }
}
