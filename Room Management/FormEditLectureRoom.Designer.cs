
namespace Project
{
    partial class FormEditLectureRoom
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
            this.groupBoxMicrophoneChoice = new System.Windows.Forms.GroupBox();
            this.radioButtonNoMic = new System.Windows.Forms.RadioButton();
            this.radioButtonYesMic = new System.Windows.Forms.RadioButton();
            this.groupBoxSlidesChoice = new System.Windows.Forms.GroupBox();
            this.radioBtnSlidesNo = new System.Windows.Forms.RadioButton();
            this.radioBtnSlidesYes = new System.Windows.Forms.RadioButton();
            this.lblHasBuiltMic = new System.Windows.Forms.Label();
            this.lblHasSlidesProjector = new System.Windows.Forms.Label();
            this.textBoxComputerAmount = new System.Windows.Forms.TextBox();
            this.textBoxStudentCapacity = new System.Windows.Forms.TextBox();
            this.lblComputerAmount = new System.Windows.Forms.Label();
            this.lblStudentCapacity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxMicrophoneChoice.SuspendLayout();
            this.groupBoxSlidesChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1204, 129);
            // 
            // lblDate
            // 
            this.lblDate.Size = new System.Drawing.Size(177, 43);
            this.lblDate.Text = "19:29:31";
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(380, 43);
            this.lblTitle.Text = "Edit Lecture Room";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // groupBoxMicrophoneChoice
            // 
            this.groupBoxMicrophoneChoice.Controls.Add(this.radioButtonNoMic);
            this.groupBoxMicrophoneChoice.Controls.Add(this.radioButtonYesMic);
            this.groupBoxMicrophoneChoice.Location = new System.Drawing.Point(1006, 380);
            this.groupBoxMicrophoneChoice.Name = "groupBoxMicrophoneChoice";
            this.groupBoxMicrophoneChoice.Size = new System.Drawing.Size(156, 47);
            this.groupBoxMicrophoneChoice.TabIndex = 37;
            this.groupBoxMicrophoneChoice.TabStop = false;
            // 
            // radioButtonNoMic
            // 
            this.radioButtonNoMic.AutoSize = true;
            this.radioButtonNoMic.Checked = true;
            this.radioButtonNoMic.Location = new System.Drawing.Point(99, 18);
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
            this.radioButtonYesMic.Location = new System.Drawing.Point(14, 18);
            this.radioButtonYesMic.Name = "radioButtonYesMic";
            this.radioButtonYesMic.Size = new System.Drawing.Size(53, 21);
            this.radioButtonYesMic.TabIndex = 26;
            this.radioButtonYesMic.Text = "Yes";
            this.radioButtonYesMic.UseVisualStyleBackColor = true;
            // 
            // groupBoxSlidesChoice
            // 
            this.groupBoxSlidesChoice.Controls.Add(this.radioBtnSlidesNo);
            this.groupBoxSlidesChoice.Controls.Add(this.radioBtnSlidesYes);
            this.groupBoxSlidesChoice.Location = new System.Drawing.Point(1006, 305);
            this.groupBoxSlidesChoice.Name = "groupBoxSlidesChoice";
            this.groupBoxSlidesChoice.Size = new System.Drawing.Size(156, 65);
            this.groupBoxSlidesChoice.TabIndex = 36;
            this.groupBoxSlidesChoice.TabStop = false;
            // 
            // radioBtnSlidesNo
            // 
            this.radioBtnSlidesNo.AutoSize = true;
            this.radioBtnSlidesNo.Location = new System.Drawing.Point(99, 18);
            this.radioBtnSlidesNo.Name = "radioBtnSlidesNo";
            this.radioBtnSlidesNo.Size = new System.Drawing.Size(47, 21);
            this.radioBtnSlidesNo.TabIndex = 27;
            this.radioBtnSlidesNo.Text = "No";
            this.radioBtnSlidesNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnSlidesYes
            // 
            this.radioBtnSlidesYes.AutoSize = true;
            this.radioBtnSlidesYes.Checked = true;
            this.radioBtnSlidesYes.Location = new System.Drawing.Point(14, 18);
            this.radioBtnSlidesYes.Name = "radioBtnSlidesYes";
            this.radioBtnSlidesYes.Size = new System.Drawing.Size(53, 21);
            this.radioBtnSlidesYes.TabIndex = 26;
            this.radioBtnSlidesYes.TabStop = true;
            this.radioBtnSlidesYes.Text = "Yes";
            this.radioBtnSlidesYes.UseVisualStyleBackColor = true;
            // 
            // lblHasBuiltMic
            // 
            this.lblHasBuiltMic.AutoSize = true;
            this.lblHasBuiltMic.BackColor = System.Drawing.Color.Transparent;
            this.lblHasBuiltMic.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasBuiltMic.ForeColor = System.Drawing.Color.Turquoise;
            this.lblHasBuiltMic.Location = new System.Drawing.Point(582, 379);
            this.lblHasBuiltMic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasBuiltMic.Name = "lblHasBuiltMic";
            this.lblHasBuiltMic.Size = new System.Drawing.Size(398, 43);
            this.lblHasBuiltMic.TabIndex = 35;
            this.lblHasBuiltMic.Text = "Has Built Microphone:";
            // 
            // lblHasSlidesProjector
            // 
            this.lblHasSlidesProjector.AutoSize = true;
            this.lblHasSlidesProjector.BackColor = System.Drawing.Color.Transparent;
            this.lblHasSlidesProjector.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasSlidesProjector.ForeColor = System.Drawing.Color.Turquoise;
            this.lblHasSlidesProjector.Location = new System.Drawing.Point(582, 304);
            this.lblHasSlidesProjector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasSlidesProjector.Name = "lblHasSlidesProjector";
            this.lblHasSlidesProjector.Size = new System.Drawing.Size(370, 43);
            this.lblHasSlidesProjector.TabIndex = 34;
            this.lblHasSlidesProjector.Text = "Has Slides Projector:";
            // 
            // textBoxComputerAmount
            // 
            this.textBoxComputerAmount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerAmount.Location = new System.Drawing.Point(1020, 234);
            this.textBoxComputerAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComputerAmount.Name = "textBoxComputerAmount";
            this.textBoxComputerAmount.Size = new System.Drawing.Size(132, 30);
            this.textBoxComputerAmount.TabIndex = 33;
            // 
            // textBoxStudentCapacity
            // 
            this.textBoxStudentCapacity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentCapacity.Location = new System.Drawing.Point(1020, 155);
            this.textBoxStudentCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentCapacity.Name = "textBoxStudentCapacity";
            this.textBoxStudentCapacity.Size = new System.Drawing.Size(132, 30);
            this.textBoxStudentCapacity.TabIndex = 32;
            // 
            // lblComputerAmount
            // 
            this.lblComputerAmount.AutoSize = true;
            this.lblComputerAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerAmount.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerAmount.ForeColor = System.Drawing.Color.Turquoise;
            this.lblComputerAmount.Location = new System.Drawing.Point(582, 223);
            this.lblComputerAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerAmount.Name = "lblComputerAmount";
            this.lblComputerAmount.Size = new System.Drawing.Size(342, 43);
            this.lblComputerAmount.TabIndex = 31;
            this.lblComputerAmount.Text = "Computer Amount:";
            // 
            // lblStudentCapacity
            // 
            this.lblStudentCapacity.AutoSize = true;
            this.lblStudentCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentCapacity.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCapacity.ForeColor = System.Drawing.Color.Turquoise;
            this.lblStudentCapacity.Location = new System.Drawing.Point(582, 144);
            this.lblStudentCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCapacity.Name = "lblStudentCapacity";
            this.lblStudentCapacity.Size = new System.Drawing.Size(319, 43);
            this.lblStudentCapacity.TabIndex = 30;
            this.lblStudentCapacity.Text = "Student Capacity:";
            // 
            // FormEditLectureRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1204, 606);
            this.Controls.Add(this.groupBoxMicrophoneChoice);
            this.Controls.Add(this.groupBoxSlidesChoice);
            this.Controls.Add(this.lblHasBuiltMic);
            this.Controls.Add(this.lblHasSlidesProjector);
            this.Controls.Add(this.textBoxComputerAmount);
            this.Controls.Add(this.textBoxStudentCapacity);
            this.Controls.Add(this.lblComputerAmount);
            this.Controls.Add(this.lblStudentCapacity);
            this.Name = "FormEditLectureRoom";
            this.Load += new System.EventHandler(this.FormEditLectureRoom_Load);
            this.Controls.SetChildIndex(this.lblStudentCapacity, 0);
            this.Controls.SetChildIndex(this.lblComputerAmount, 0);
            this.Controls.SetChildIndex(this.textBoxStudentCapacity, 0);
            this.Controls.SetChildIndex(this.textBoxComputerAmount, 0);
            this.Controls.SetChildIndex(this.lblHasSlidesProjector, 0);
            this.Controls.SetChildIndex(this.lblHasBuiltMic, 0);
            this.Controls.SetChildIndex(this.groupBoxSlidesChoice, 0);
            this.Controls.SetChildIndex(this.groupBoxMicrophoneChoice, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblRoomNumber, 0);
            this.Controls.SetChildIndex(this.lblFloorNumber, 0);
            this.Controls.SetChildIndex(this.lblLocation, 0);
            this.Controls.SetChildIndex(this.lblSize, 0);
            this.Controls.SetChildIndex(this.textBoxRoomNumber, 0);
            this.Controls.SetChildIndex(this.textBoxFloorNumber, 0);
            this.Controls.SetChildIndex(this.textBoxLocation, 0);
            this.Controls.SetChildIndex(this.textBoxSize, 0);
            this.Controls.SetChildIndex(this.buttonSaveChanges, 0);
            this.Controls.SetChildIndex(this.buttonDeleteRoom, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxMicrophoneChoice.ResumeLayout(false);
            this.groupBoxMicrophoneChoice.PerformLayout();
            this.groupBoxSlidesChoice.ResumeLayout(false);
            this.groupBoxSlidesChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMicrophoneChoice;
        private System.Windows.Forms.RadioButton radioButtonNoMic;
        private System.Windows.Forms.RadioButton radioButtonYesMic;
        private System.Windows.Forms.GroupBox groupBoxSlidesChoice;
        private System.Windows.Forms.RadioButton radioBtnSlidesNo;
        private System.Windows.Forms.RadioButton radioBtnSlidesYes;
        private System.Windows.Forms.Label lblHasBuiltMic;
        private System.Windows.Forms.Label lblHasSlidesProjector;
        private System.Windows.Forms.TextBox textBoxComputerAmount;
        private System.Windows.Forms.TextBox textBoxStudentCapacity;
        private System.Windows.Forms.Label lblComputerAmount;
        private System.Windows.Forms.Label lblStudentCapacity;
    }
}
