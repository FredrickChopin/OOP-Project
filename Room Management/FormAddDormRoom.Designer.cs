
namespace Project
{
    partial class FormAddDormRoom
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
            this.lblNumberOfBeds = new System.Windows.Forms.Label();
            this.textBoxNumberOfBeds = new System.Windows.Forms.TextBox();
            this.lblMonthlyBills = new System.Windows.Forms.Label();
            this.textBoxMonthlyBills = new System.Windows.Forms.TextBox();
            this.buttonSaveRoom = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 105);
            this.panel1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(397, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 34);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dorm Room Specific Properties";
            // 
            // lblNumberOfBeds
            // 
            this.lblNumberOfBeds.AutoSize = true;
            this.lblNumberOfBeds.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfBeds.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBeds.ForeColor = System.Drawing.Color.Turquoise;
            this.lblNumberOfBeds.Location = new System.Drawing.Point(10, 135);
            this.lblNumberOfBeds.Name = "lblNumberOfBeds";
            this.lblNumberOfBeds.Size = new System.Drawing.Size(237, 34);
            this.lblNumberOfBeds.TabIndex = 4;
            this.lblNumberOfBeds.Text = "Number of Beds:";
            // 
            // textBoxNumberOfBeds
            // 
            this.textBoxNumberOfBeds.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfBeds.Location = new System.Drawing.Point(270, 144);
            this.textBoxNumberOfBeds.Name = "textBoxNumberOfBeds";
            this.textBoxNumberOfBeds.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfBeds.TabIndex = 8;
            // 
            // lblMonthlyBills
            // 
            this.lblMonthlyBills.AutoSize = true;
            this.lblMonthlyBills.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyBills.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyBills.ForeColor = System.Drawing.Color.Turquoise;
            this.lblMonthlyBills.Location = new System.Drawing.Point(10, 195);
            this.lblMonthlyBills.Name = "lblMonthlyBills";
            this.lblMonthlyBills.Size = new System.Drawing.Size(202, 34);
            this.lblMonthlyBills.TabIndex = 9;
            this.lblMonthlyBills.Text = "Monthly Bills:";
            // 
            // textBoxMonthlyBills
            // 
            this.textBoxMonthlyBills.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyBills.Location = new System.Drawing.Point(270, 206);
            this.textBoxMonthlyBills.Name = "textBoxMonthlyBills";
            this.textBoxMonthlyBills.Size = new System.Drawing.Size(100, 26);
            this.textBoxMonthlyBills.TabIndex = 10;
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.BackColor = System.Drawing.Color.Khaki;
            this.buttonSaveRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonSaveRoom.Location = new System.Drawing.Point(178, 308);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(246, 88);
            this.buttonSaveRoom.TabIndex = 13;
            this.buttonSaveRoom.Text = "Save Room";
            this.buttonSaveRoom.UseVisualStyleBackColor = false;
            this.buttonSaveRoom.Click += new System.EventHandler(this.buttonSaveRoom_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAddDormRoom
            // 
            this.AcceptButton = this.buttonSaveRoom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 436);
            this.Controls.Add(this.buttonSaveRoom);
            this.Controls.Add(this.textBoxMonthlyBills);
            this.Controls.Add(this.lblMonthlyBills);
            this.Controls.Add(this.textBoxNumberOfBeds);
            this.Controls.Add(this.lblNumberOfBeds);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddDormRoom";
            this.Text = "AddDormRoom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumberOfBeds;
        private System.Windows.Forms.TextBox textBoxNumberOfBeds;
        private System.Windows.Forms.Label lblMonthlyBills;
        private System.Windows.Forms.TextBox textBoxMonthlyBills;
        private System.Windows.Forms.Button buttonSaveRoom;
        private System.Windows.Forms.Timer timer1;
    }
}