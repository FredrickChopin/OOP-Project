using System.Windows.Forms;
using System;

namespace Project
{
    [Serializable]
    class LectureRoom : EducationalRoom
    {
        protected bool hasSlidesProjector;
        protected bool hasBuiltMicrophone;

        public LectureRoom(Room roomToCopy, 
            TextBox textBoxStudentCapacity, 
            TextBox textBoxComputerAmount,
            RadioButton radioBtnSlidesYes,
            RadioButton radioBtnYesMic) :
            base(roomToCopy, textBoxStudentCapacity, textBoxComputerAmount)
        {
            UpdateLectureRoomSpecificProperties(radioBtnSlidesYes, radioBtnYesMic);
        }

        public void UpdateLectureRoomSpecificProperties(RadioButton radioBtnSlidesYes, RadioButton radioBtnMicYes)
        {
            HasSlidesProjector = radioBtnSlidesYes.Checked;
            hasBuiltMicrophone = radioBtnMicYes.Checked;
        }

        public bool HasSlidesProjector { get => hasSlidesProjector; set => hasSlidesProjector = value; }

        public bool HasBuiltMicrophone { get => hasBuiltMicrophone; set => hasBuiltMicrophone = value; }
    }
}
