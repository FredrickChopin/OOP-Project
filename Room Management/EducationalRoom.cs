using static Project.Utilities;
using System.Windows.Forms;
using System;

namespace Project
{
    [Serializable]
    class EducationalRoom : Room
    {
        protected int studentCapacity;
        protected int computerAmount;

        public EducationalRoom(Room roomToCopy, TextBox textBoxStudentCapacity, TextBox textBoxComputerAmount) :
            base(roomToCopy)
        {
            ValidateAndUpdate(textBoxStudentCapacity, textBoxComputerAmount);
        }

        public void ValidateAndUpdate(TextBox textBoxStudentCapacity, TextBox textBoxComputerAmount)
        {
            ValidateUserInput(textBoxStudentCapacity, textBoxComputerAmount);
            UpdateProperties(textBoxStudentCapacity, textBoxComputerAmount);
        }

        public void UpdateProperties(TextBox textBoxStudentCapacity, TextBox textBoxComputerAmount)
        {
            StudentCapacity = int.Parse(textBoxStudentCapacity.Text);
            ComputerAmount = int.Parse(textBoxComputerAmount.Text);
        }

        public void ValidateUserInput(TextBox textBoxStudentCapacity, TextBox textBoxComputerAmount)
        {
            ValidateProperty(textBoxStudentCapacity, "Student capacity must be an integer", (box) => IsInt(box.Text));
            ValidateProperty(textBoxComputerAmount, "Computer amount must be an integer", (box) => IsInt(box.Text));
        }

        public int StudentCapacity
        {
            get { return studentCapacity; }
            set
            {
                ValidateProperty(value, "Student capacity must be positive", (x) => x > 0);
                studentCapacity = value;
            }
        }

        public int ComputerAmount
        {
            get { return computerAmount; }
            set
            {
                ValidateProperty(value, "Computer amount must be non-negative", (x) => x >= 0);
                computerAmount = value;
            }
        }

    }
}
