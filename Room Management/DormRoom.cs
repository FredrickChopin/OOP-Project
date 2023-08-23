using System;
using System.Windows.Forms;
using static Project.Utilities;

namespace Project
{
    [Serializable]
    class DormRoom : Room
    {
        int numberOfBeds;
        int monthlyBills;

        public DormRoom(Room roomToCopy, TextBox textBoxNumberOfBeds, TextBox textBoxMonthlyBills) : 
            base(roomToCopy)
        {
            ValidateAndUpdate(textBoxNumberOfBeds, textBoxMonthlyBills);
        }

        public void ValidateAndUpdate(TextBox textBoxNumberOfBeds, TextBox textBoxMonthlyBills)
        {
            ValidateUserInput(textBoxNumberOfBeds, textBoxMonthlyBills);
            UpdateProperties(textBoxNumberOfBeds, textBoxMonthlyBills);
        }

        public void UpdateProperties(TextBox textBoxNumberOfBeds, TextBox textBoxMonthlyBills)
        {
            NumberOfBeds = int.Parse(textBoxNumberOfBeds.Text);
            MonthlyBills = int.Parse(textBoxMonthlyBills.Text);
        }

        public void ValidateUserInput(TextBox textBoxNumberOfBeds, TextBox textBoxMonthlyBills)
        {
            ValidateProperty(textBoxNumberOfBeds, "Number of beds must be an integer", (box) => IsInt(box.Text));
            ValidateProperty(textBoxMonthlyBills, "Monthly bills must be an integer", (box) => IsInt(box.Text));
        }

        public int NumberOfBeds 
        { 
            get => numberOfBeds;
            set
            {
                ValidateProperty(value, "Number of beds must be positive", (x) => x > 0);
                numberOfBeds = value;
            }
        }

        public int MonthlyBills
        {
            get => monthlyBills;
            set
            {
                ValidateProperty(value, "Monthly bills must be non-negative", (x) => x >= 0);
                monthlyBills = value;
            }
        }

    }
}
