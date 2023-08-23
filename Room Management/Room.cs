using static Project.Utilities;
using static Project.GlobalVars;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Project
{
    [Serializable]
    class Room
    {
        protected double size;
        protected int roomNumber;
        protected int floorNumber;
        protected string location;

        public Room(TextBox textBoxRoomNumber,
                    TextBox textBoxFloorNumber,
                    TextBox textBoxSize,
                    TextBox textBoxLocation)
        {
            ValidateAndUpdate(textBoxRoomNumber, textBoxFloorNumber, textBoxSize, textBoxLocation);
        }

        public void ValidateAndUpdate(TextBox textBoxRoomNumber,
                    TextBox textBoxFloorNumber,
                    TextBox textBoxSize,
                    TextBox textBoxLocation)
        {
            ValidateUserInput(textBoxRoomNumber, textBoxFloorNumber, textBoxSize);
            UpdateProperties(textBoxRoomNumber, textBoxFloorNumber, textBoxSize, textBoxLocation);
        }

        public void UpdateProperties(TextBox textBoxRoomNumber,
                    TextBox textBoxFloorNumber,
                    TextBox textBoxSize,
                    TextBox textBoxLocation)
        {
            Location = textBoxLocation.Text;
            Size = double.Parse(textBoxSize.Text);
            RoomNumber = int.Parse(textBoxRoomNumber.Text);
            FloorNumber = int.Parse(textBoxFloorNumber.Text);
        }

        public void ValidateUserInput(TextBox textBoxRoomNumber,
                    TextBox textBoxFloorNumber,
                    TextBox textBoxSize)
        {
            ValidateProperty(textBoxRoomNumber, "Room number must be an integer", (box) => IsInt(box.Text));
            ValidateProperty(textBoxFloorNumber, "Floor number must be an integer", (box) => IsInt(box.Text));
            ValidateProperty(textBoxSize, "Room size must be a number", (box) => IsDouble(box.Text));
        }

        public Room(Room roomToCopy)
        {
            CopyData(roomToCopy);
        }

        public void CopyData(Room roomToCopy)
        {
            //Copies the data of roomToCopy into this
            size = roomToCopy.size;
            roomNumber = roomToCopy.roomNumber;
            floorNumber = roomToCopy.floorNumber;
            location = roomToCopy.location;
        }

        public double Size
        {
            get => size;
            set
            {
                ValidateProperty(value, "Room size must be positive", (x) => x > 0);
                size = value;
            }
        }

        public int RoomNumber 
        { 
            get => roomNumber;
            set
            {
                if (roomNumber == value) return;
                if (rooms.Any(roomInList => roomInList.RoomNumber == value))
                {
                    throw new ArgumentException("There already exists a room with this room number");
                }
                roomNumber = value;
            }
        }

        public int FloorNumber { get => floorNumber; set => floorNumber = value; }

        public string Location { get => location; set => location = value; }

    }
}
