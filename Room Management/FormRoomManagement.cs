using System;
using System.Windows.Forms;
using static Project.GlobalVars;
using static Project.Utilities;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Project
{
    partial class FormRoomManagement : Form
    {

        public FormRoomManagement()
        {
            InitializeComponent();
        }

        private void RearrangeDataGridColumns()
        {
            dataGridRooms.Columns["Type"].DisplayIndex = 0;
            dataGridRooms.Columns["RoomNumber"].DisplayIndex = 1;
            dataGridRooms.Columns["FloorNumber"].DisplayIndex = 2;
            dataGridRooms.Columns["Location"].DisplayIndex = 3;
            dataGridRooms.Columns["Size"].DisplayIndex = 4;
            dataGridRooms.Columns["RoomNumber"].HeaderText = "Room Number";
            dataGridRooms.Columns["FloorNumber"].HeaderText = "Floor Number";
        }

        private void FillTypeColumn()
        {
            foreach (DataGridViewRow row in dataGridRooms.Rows)
            {
                string typeName = rooms[row.Index].GetType().Name;
                if (typeName == "LectureRoom") typeName = "Lecture Room";
                else if (typeName == "DormRoom") typeName = "Dorm Room";
                row.Cells["Type"].Value = typeName;
            }
        }

        private void LoadRoomsIntoDataGrid()
        {
            dataGridRooms.DataSource = null; //Setting to null first refreshes it when
                                             //It is not the first time loading
            dataGridRooms.DataSource = rooms;
            RearrangeDataGridColumns();
            FillTypeColumn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            LoadRoomsIntoDataGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            DialogResult result = formAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadRoomsIntoDataGrid();
                SaveRooms();
            }
        }

        private void lblStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.ShowDialog();
        }

        private void LoadRoomByType(Room chosenRoom)
        {
            LoadRoomByType(chosenRoom, rooms.IndexOf(chosenRoom));
        }

        private void LoadRoomByType(int roomIndex)
        {
            if (roomIndex < 0) return;
            LoadRoomByType(rooms[roomIndex], roomIndex);
        }

        private void LoadRoomByType(Room chosenRoom, int roomIndex)
        {
            DialogResult result = DialogResult.Cancel;
            switch (chosenRoom.GetType().Name)
            {
                case "DormRoom":
                    FormEditDormRoom editDormRoom = new FormEditDormRoom(roomIndex);
                    result = editDormRoom.ShowDialog();
                    break;
                case "LectureRoom":
                    FormEditLectureRoom editLectureRoom = new FormEditLectureRoom(roomIndex);
                    result = editLectureRoom.ShowDialog();
                    break;
                case "Lab":
                    FormEditLab editLab = new FormEditLab(roomIndex);
                    result = editLab.ShowDialog();
                    break;
            }
            if (result == DialogResult.OK)
            {
                LoadRoomsIntoDataGrid();
                SaveRooms();
            }
        }

        private void dataGridRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadRoomByType(e.RowIndex);
        }

        private void dataGridRooms_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridRooms.ClearSelection();
        }

        private void buttonSearchRoom_Click(object sender, EventArgs e)
        {
            
            try
            {
                ValidateProperty(textBoxSearchRoom, "Room number must be an integer", (box) => IsInt(box.Text));
                int chosenRoomNumber = int.Parse(textBoxSearchRoom.Text);
                List<Room> filtered = rooms.Where(room => room.RoomNumber == chosenRoomNumber).ToList();
                if (filtered.Count == 0)
                {
                    throw new ObjectNotFoundException("Could not find room");
                }
                Room chosenRoom = filtered[0];
                int roomIndex = rooms.IndexOf(chosenRoom);
                LoadRoomByType(chosenRoom);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

    }
}
