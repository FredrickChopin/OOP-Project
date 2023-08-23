
namespace Project
{
    partial class FormAddLectureRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBoxComputerAmount = new System.Windows.Forms.TextBox();
            this.textBoxStudentCapacity = new System.Windows.Forms.TextBox();
            this.lblComputerAmount = new System.Windows.Forms.Label();
            this.lblStudentCapacity = new System.Windows.Forms.Label();
            this.buttonSaveRoom = new System.Windows.Forms.Button();
            this.lblHasSlidesProjector = new System.Windows.Forms.Label();
            this.lblHasBuiltMic = new System.Windows.Forms.Label();
            this.radioBtnSlidesYes = new System.Windows.Forms.RadioButton();
            this.radioBtnSlidesNo = new System.Windows.Forms.RadioButton();
            this.groupBoxSlidesChoice = new System.Windows.Forms.GroupBox();
            this.groupBoxMicrophoneChoice = new System.Windows.Forms.GroupBox();
            this.radioButtonNoMic = new System.Windows.Forms.RadioButton();
            this.radioButtonYesMic = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxSlidesChoice.SuspendLayout();
            this.groupBoxMicrophoneChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 129);
            this.panel1.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(529, 86);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 43);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(644, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lcture Room Specific Properties";
            // 
            // textBoxComputerAmount
            // 
            this.textBoxComputerAmount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerAmount.Location = new System.Drawing.Point(455, 223);
            this.textBoxComputerAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComputerAmount.Name = "textBoxComputerAmount";
            this.textBoxComputerAmount.Size = new System.Drawing.Size(132, 30);
            this.textBoxComputerAmount.TabIndex = 22;
            // 
            // textBoxStudentCapacity
            // 
            this.textBoxStudentCapacity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentCapacity.Location = new System.Drawing.Point(455, 157);
            this.textBoxStudentCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentCapacity.Name = "textBoxStudentCapacity";
            this.textBoxStudentCapacity.Size = new System.Drawing.Size(132, 30);
            this.textBoxStudentCapacity.TabIndex = 21;
            // 
            // lblComputerAmount
            // 
            this.lblComputerAmount.AutoSize = true;
            this.lblComputerAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerAmount.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerAmount.ForeColor = System.Drawing.Color.Turquoise;
            this.lblComputerAmount.Location = new System.Drawing.Point(13, 210);
            this.lblComputerAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerAmount.Name = "lblComputerAmount";
            this.lblComputerAmount.Size = new System.Drawing.Size(342, 43);
            this.lblComputerAmount.TabIndex = 20;
            this.lblComputerAmount.Text = "Computer Amount:";
            // 
            // lblStudentCapacity
            // 
            this.lblStudentCapacity.AutoSize = true;
            this.lblStudentCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentCapacity.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCapacity.ForeColor = System.Drawing.Color.Turquoise;
            this.lblStudentCapacity.Location = new System.Drawing.Point(13, 146);
            this.lblStudentCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCapacity.Name = "lblStudentCapacity";
            this.lblStudentCapacity.Size = new System.Drawing.Size(319, 43);
            this.lblStudentCapacity.TabIndex = 19;
            this.lblStudentCapacity.Text = "Student Capacity:";
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.BackColor = System.Drawing.Color.Khaki;
            this.buttonSaveRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonSaveRoom.Location = new System.Drawing.Point(293, 449);
            this.buttonSaveRoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(328, 108);
            this.buttonSaveRoom.TabIndex = 23;
            this.buttonSaveRoom.Text = "Save Room";
            this.buttonSaveRoom.UseVisualStyleBackColor = false;
            this.buttonSaveRoom.Click += new System.EventHandler(this.buttonSaveRoom_Click);
            // 
            // lblHasSlidesProjector
            // 
            this.lblHasSlidesProjector.AutoSize = true;
            this.lblHasSlidesProjector.BackColor = System.Drawing.Color.Transparent;
            this.lblHasSlidesProjector.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasSlidesProjector.ForeColor = System.Drawing.Color.Turquoise;
            this.lblHasSlidesProjector.Location = new System.Drawing.Point(13, 281);
            this.lblHasSlidesProjector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasSlidesProjector.Name = "lblHasSlidesProjector";
            this.lblHasSlidesProjector.Size = new System.Drawing.Size(370, 43);
            this.lblHasSlidesProjector.TabIndex = 24;
            this.lblHasSlidesProjector.Text = "Has Slides Projector:";
            // 
            // lblHasBuiltMic
            // 
            this.lblHasBuiltMic.AutoSize = true;
            this.lblHasBuiltMic.BackColor = System.Drawing.Color.Transparent;
            this.lblHasBuiltMic.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasBuiltMic.ForeColor = System.Drawing.Color.Turquoise;
            this.lblHasBuiltMic.Location = new System.Drawing.Point(13, 348);
            this.lblHasBuiltMic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasBuiltMic.Name = "lblHasBuiltMic";
            this.lblHasBuiltMic.Size = new System.Drawing.Size(398, 43);
            this.lblHasBuiltMic.TabIndex = 25;
            this.lblHasBuiltMic.Text = "Has Built Microphone:";
            // 
            // radioBtnSlidesYes
            // 
            this.radioBtnSlidesYes.AutoSize = true;
            this.radioBtnSlidesYes.Checked = true;
            this.radioBtnSlidesYes.Location = new System.Drawing.Point(13, 18);
            this.radioBtnSlidesYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnSlidesYes.Name = "radioBtnSlidesYes";
            this.radioBtnSlidesYes.Size = new System.Drawing.Size(53, 21);
            this.radioBtnSlidesYes.TabIndex = 26;
            this.radioBtnSlidesYes.TabStop = true;
            this.radioBtnSlidesYes.Text = "Yes";
            this.radioBtnSlidesYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnSlidesNo
            // 
            this.radioBtnSlidesNo.AutoSize = true;
            this.radioBtnSlidesNo.Location = new System.Drawing.Point(99, 18);
            this.radioBtnSlidesNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnSlidesNo.Name = "radioBtnSlidesNo";
            this.radioBtnSlidesNo.Size = new System.Drawing.Size(47, 21);
            this.radioBtnSlidesNo.TabIndex = 27;
            this.radioBtnSlidesNo.Text = "No";
            this.radioBtnSlidesNo.UseVisualStyleBackColor = true;
            // 
            // groupBoxSlidesChoice
            // 
            this.groupBoxSlidesChoice.Controls.Add(this.radioBtnSlidesNo);
            this.groupBoxSlidesChoice.Controls.Add(this.radioBtnSlidesYes);
            this.groupBoxSlidesChoice.Location = new System.Drawing.Point(442, 282);
            this.groupBoxSlidesChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSlidesChoice.Name = "groupBoxSlidesChoice";
            this.groupBoxSlidesChoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSlidesChoice.Size = new System.Drawing.Size(156, 65);
            this.groupBoxSlidesChoice.TabIndex = 28;
            this.groupBoxSlidesChoice.TabStop = false;
            // 
            // groupBoxMicrophoneChoice
            // 
            this.groupBoxMicrophoneChoice.Controls.Add(this.radioButtonNoMic);
            this.groupBoxMicrophoneChoice.Controls.Add(this.radioButtonYesMic);
            this.groupBoxMicrophoneChoice.Location = new System.Drawing.Point(442, 349);
            this.groupBoxMicrophoneChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMicrophoneChoice.Name = "groupBoxMicrophoneChoice";
            this.groupBoxMicrophoneChoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMicrophoneChoice.Size = new System.Drawing.Size(156, 47);
            this.groupBoxMicrophoneChoice.TabIndex = 29;
            this.groupBoxMicrophoneChoice.TabStop = false;
            // 
            // radioButtonNoMic
            // 
            this.radioButtonNoMic.AutoSize = true;
            this.radioButtonNoMic.Checked = true;
            this.radioButtonNoMic.Location = new System.Drawing.Point(99, 18);
            this.radioButtonNoMic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNoMic.Name = "radioButtonNoMic";
            this.radioButtonNoMic.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNoMic.TabIndex = 27;
            this.radioButtonNoMic.TabStop = true;
            this.radioButtonNoMic.Text = "No";
            this.radioButtonNoMic.UseVisualStyleBackColor = true;
            // 
            // radioButtonYesMic
            // 
            this.radioButtonYesMic.AutoSize = true;
            this.radioButtonYesMic.Location = new System.Drawing.Point(13, 18);
            this.radioButtonYesMic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonYesMic.Name = "radioButtonYesMic";
            this.radioButtonYesMic.Size = new System.Drawing.Size(53, 21);
            this.radioButtonYesMic.TabIndex = 26;
            this.radioButtonYesMic.Text = "Yes";
            this.radioButtonYesMic.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAddLectureRoom
            // 
            this.AcceptButton = this.buttonSaveRoom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 586);
            this.Controls.Add(this.groupBoxMicrophoneChoice);
            this.Controls.Add(this.groupBoxSlidesChoice);
            this.Controls.Add(this.lblHasBuiltMic);
            this.Controls.Add(this.lblHasSlidesProjector);
            this.Controls.Add(this.buttonSaveRoom);
            this.Controls.Add(this.textBoxComputerAmount);
            this.Controls.Add(this.textBoxStudentCapacity);
            this.Controls.Add(this.lblComputerAmount);
            this.Controls.Add(this.lblStudentCapacity);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddLectureRoom";
            this.Text = "FormAddLectureRoom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSlidesChoice.ResumeLayout(false);
            this.groupBoxSlidesChoice.PerformLayout();
            this.groupBoxMicrophoneChoice.ResumeLayout(false);
            this.groupBoxMicrophoneChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxComputerAmount;
        private System.Windows.Forms.TextBox textBoxStudentCapacity;
        private System.Windows.Forms.Label lblComputerAmount;
        private System.Windows.Forms.Label lblStudentCapacity;
        private System.Windows.Forms.Button buttonSaveRoom;
        private System.Windows.Forms.Label lblHasSlidesProjector;
        private System.Windows.Forms.Label lblHasBuiltMic;
        private System.Windows.Forms.RadioButton radioBtnSlidesYes;
        private System.Windows.Forms.RadioButton radioBtnSlidesNo;
        private System.Windows.Forms.GroupBox groupBoxSlidesChoice;
        private System.Windows.Forms.GroupBox groupBoxMicrophoneChoice;
        private System.Windows.Forms.RadioButton radioButtonNoMic;
        private System.Windows.Forms.RadioButton radioButtonYesMic;
        private System.Windows.Forms.Timer timer1;
    }
}