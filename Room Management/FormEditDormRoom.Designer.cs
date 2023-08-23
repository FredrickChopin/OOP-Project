
namespace Project
{
    partial class FormEditDormRoom
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
            this.textBoxMonthlyBills = new System.Windows.Forms.TextBox();
            this.lblMonthlyBills = new System.Windows.Forms.Label();
            this.textBoxNumberOfBeds = new System.Windows.Forms.TextBox();
            this.lblNumberOfBeds = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Size = new System.Drawing.Size(266, 34);
            this.lblTitle.Text = "Edit Dorm Room";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBoxFloorNumber
            // 
            this.textBoxFloorNumber.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(290, 126);
            this.textBoxRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // textBoxMonthlyBills
            // 
            this.textBoxMonthlyBills.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyBills.Location = new System.Drawing.Point(721, 197);
            this.textBoxMonthlyBills.Name = "textBoxMonthlyBills";
            this.textBoxMonthlyBills.Size = new System.Drawing.Size(100, 26);
            this.textBoxMonthlyBills.TabIndex = 24;
            // 
            // lblMonthlyBills
            // 
            this.lblMonthlyBills.AutoSize = true;
            this.lblMonthlyBills.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyBills.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyBills.ForeColor = System.Drawing.Color.Turquoise;
            this.lblMonthlyBills.Location = new System.Drawing.Point(460, 186);
            this.lblMonthlyBills.Name = "lblMonthlyBills";
            this.lblMonthlyBills.Size = new System.Drawing.Size(202, 34);
            this.lblMonthlyBills.TabIndex = 23;
            this.lblMonthlyBills.Text = "Monthly Bills:";
            // 
            // textBoxNumberOfBeds
            // 
            this.textBoxNumberOfBeds.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfBeds.Location = new System.Drawing.Point(721, 135);
            this.textBoxNumberOfBeds.Name = "textBoxNumberOfBeds";
            this.textBoxNumberOfBeds.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfBeds.TabIndex = 22;
            // 
            // lblNumberOfBeds
            // 
            this.lblNumberOfBeds.AutoSize = true;
            this.lblNumberOfBeds.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfBeds.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBeds.ForeColor = System.Drawing.Color.Turquoise;
            this.lblNumberOfBeds.Location = new System.Drawing.Point(460, 126);
            this.lblNumberOfBeds.Name = "lblNumberOfBeds";
            this.lblNumberOfBeds.Size = new System.Drawing.Size(237, 34);
            this.lblNumberOfBeds.TabIndex = 21;
            this.lblNumberOfBeds.Text = "Number of Beds:";
            // 
            // FormEditDormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(875, 492);
            this.Controls.Add(this.textBoxMonthlyBills);
            this.Controls.Add(this.lblMonthlyBills);
            this.Controls.Add(this.textBoxNumberOfBeds);
            this.Controls.Add(this.lblNumberOfBeds);
            this.Name = "FormEditDormRoom";
            this.Load += new System.EventHandler(this.FormEdit_Load);
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
            this.Controls.SetChildIndex(this.lblNumberOfBeds, 0);
            this.Controls.SetChildIndex(this.textBoxNumberOfBeds, 0);
            this.Controls.SetChildIndex(this.lblMonthlyBills, 0);
            this.Controls.SetChildIndex(this.textBoxMonthlyBills, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMonthlyBills;
        private System.Windows.Forms.Label lblMonthlyBills;
        private System.Windows.Forms.TextBox textBoxNumberOfBeds;
        private System.Windows.Forms.Label lblNumberOfBeds;
    }
}
