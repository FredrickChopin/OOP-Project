using System;
using System.Drawing;
using System.Windows.Forms;
using static Project.GlobalVars;

namespace Project
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            int ctDormRoom = 0;
            int ctLab = 0;
            int ctLectureRoom = 0;
            foreach (Room room in rooms)
            {
                if (room.GetType().Name == "DormRoom")
                {
                    ctDormRoom += 1;
                }
                else if(room.GetType().Name == "Lab")
                {
                    ctLab += 1;
                }
                else { ctLectureRoom += 1; };
            }


            chartColumn.Series["Room Type"].Points.AddXY("Dorm Rooms", ctDormRoom);
            chartColumn.Series["Room Type"].Points.AddXY("Lecture Rooms", ctLectureRoom);
            chartColumn.Series["Room Type"].Points[1].Color = Color.Orange;
            chartColumn.Series["Room Type"].Points.AddXY("Labs", ctLab);
            chartColumn.Series["Room Type"].Points[2].Color = Color.Red;

            chartPie.Series["Room Type"].Points.AddXY("Dorm Rooms", ctDormRoom);
            chartPie.Series["Room Type"].Points.AddXY("Lecture Rooms", ctLectureRoom);
            chartPie.Series["Room Type"].Points.AddXY("Labs", ctLab);
            
            if (ctDormRoom == 0) chartPie.Series["Room Type"].Points[0].IsVisibleInLegend = false;
            if (ctLectureRoom == 0) chartPie.Series["Room Type"].Points[1].IsVisibleInLegend = false;
            if (ctLab == 0) chartPie.Series["Room Type"].Points[2].IsVisibleInLegend = false;
            
        }

    }
}
