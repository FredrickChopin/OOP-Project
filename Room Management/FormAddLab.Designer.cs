
namespace Project
{
    partial class FormAddLab
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
            this.buttonSaveRoom = new System.Windows.Forms.Button();
            this.lblStudentCapacity = new System.Windows.Forms.Label();
            this.lblComputerAmount = new System.Windows.Forms.Label();
            this.textBoxStudentCapacity = new System.Windows.Forms.TextBox();
            this.textBoxComputerAmount = new System.Windows.Forms.TextBox();
            this.lblMonthlyFunding = new System.Windows.Forms.Label();
            this.textBoxMonthlyFunding = new System.Windows.Forms.TextBox();
            this.lblLabName = new System.Windows.Forms.Label();
            this.textBoxLabName = new System.Windows.Forms.TextBox();
            this.lblLabEquipment = new System.Windows.Forms.Label();
            this.textBoxLabEquipment = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(655, 105);
            this.panel1.TabIndex = 3;
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
            this.lblTitle.Location = new System.Drawing.Point(10, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lab Specific Properties";
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.BackColor = System.Drawing.Color.Khaki;
            this.buttonSaveRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonSaveRoom.Location = new System.Drawing.Point(206, 414);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(246, 88);
            this.buttonSaveRoom.TabIndex = 14;
            this.buttonSaveRoom.Text = "Save Room";
            this.buttonSaveRoom.UseVisualStyleBackColor = false;
            this.buttonSaveRoom.Click += new System.EventHandler(this.buttonSaveRoom_Click);
            // 
            // lblStudentCapacity
            // 
            this.lblStudentCapacity.AutoSize = true;
            this.lblStudentCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentCapacity.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCapacity.ForeColor = System.Drawing.Color.Turquoise;
            this.lblStudentCapacity.Location = new System.Drawing.Point(20, 122);
            this.lblStudentCapacity.Name = "lblStudentCapacity";
            this.lblStudentCapacity.Size = new System.Drawing.Size(253, 34);
            this.lblStudentCapacity.TabIndex = 15;
            this.lblStudentCapacity.Text = "Student Capacity:";
            // 
            // lblComputerAmount
            // 
            this.lblComputerAmount.AutoSize = true;
            this.lblComputerAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerAmount.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerAmount.ForeColor = System.Drawing.Color.Turquoise;
            this.lblComputerAmount.Location = new System.Drawing.Point(20, 176);
            this.lblComputerAmount.Name = "lblComputerAmount";
            this.lblComputerAmount.Size = new System.Drawing.Size(270, 34);
            this.lblComputerAmount.TabIndex = 16;
            this.lblComputerAmount.Text = "Computer Amount:";
            // 
            // textBoxStudentCapacity
            // 
            this.textBoxStudentCapacity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentCapacity.Location = new System.Drawing.Point(296, 132);
            this.textBoxStudentCapacity.Name = "textBoxStudentCapacity";
            this.textBoxStudentCapacity.Size = new System.Drawing.Size(100, 26);
            this.textBoxStudentCapacity.TabIndex = 17;
            // 
            // textBoxComputerAmount
            // 
            this.textBoxComputerAmount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerAmount.Location = new System.Drawing.Point(296, 185);
            this.textBoxComputerAmount.Name = "textBoxComputerAmount";
            this.textBoxComputerAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxComputerAmount.TabIndex = 18;
            // 
            // lblMonthlyFunding
            // 
            this.lblMonthlyFunding.AutoSize = true;
            this.lblMonthlyFunding.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyFunding.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyFunding.ForeColor = System.Drawing.Color.Turquoise;
            this.lblMonthlyFunding.Location = new System.Drawing.Point(16, 285);
            this.lblMonthlyFunding.Name = "lblMonthlyFunding";
            this.lblMonthlyFunding.Size = new System.Drawing.Size(256, 34);
            this.lblMonthlyFunding.TabIndex = 19;
            this.lblMonthlyFunding.Text = "Monthly Funding:";
            // 
            // textBoxMonthlyFunding
            // 
            this.textBoxMonthlyFunding.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyFunding.Location = new System.Drawing.Point(296, 294);
            this.textBoxMonthlyFunding.Name = "textBoxMonthlyFunding";
            this.textBoxMonthlyFunding.Size = new System.Drawing.Size(100, 26);
            this.textBoxMonthlyFunding.TabIndex = 20;
            // 
            // lblLabName
            // 
            this.lblLabName.AutoSize = true;
            this.lblLabName.BackColor = System.Drawing.Color.Transparent;
            this.lblLabName.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabName.ForeColor = System.Drawing.Color.Turquoise;
            this.lblLabName.Location = new System.Drawing.Point(20, 231);
            this.lblLabName.Name = "lblLabName";
            this.lblLabName.Size = new System.Drawing.Size(163, 34);
            this.lblLabName.TabIndex = 21;
            this.lblLabName.Text = "Lab Name:";
            // 
            // textBoxLabName
            // 
            this.textBoxLabName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabName.Location = new System.Drawing.Point(296, 240);
            this.textBoxLabName.Name = "textBoxLabName";
            this.textBoxLabName.Size = new System.Drawing.Size(100, 26);
            this.textBoxLabName.TabIndex = 22;
            // 
            // lblLabEquipment
            // 
            this.lblLabEquipment.AutoSize = true;
            this.lblLabEquipment.BackColor = System.Drawing.Color.Transparent;
            this.lblLabEquipment.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabEquipment.ForeColor = System.Drawing.Color.Turquoise;
            this.lblLabEquipment.Location = new System.Drawing.Point(16, 341);
            this.lblLabEquipment.Name = "lblLabEquipment";
            this.lblLabEquipment.Size = new System.Drawing.Size(229, 34);
            this.lblLabEquipment.TabIndex = 23;
            this.lblLabEquipment.Text = "Lab Equipment:";
            // 
            // textBoxLabEquipment
            // 
            this.textBoxLabEquipment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabEquipment.Location = new System.Drawing.Point(291, 341);
            this.textBoxLabEquipment.Multiline = true;
            this.textBoxLabEquipment.Name = "textBoxLabEquipment";
            this.textBoxLabEquipment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLabEquipment.Size = new System.Drawing.Size(227, 52);
            this.textBoxLabEquipment.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAddLab
            // 
            this.AcceptButton = this.buttonSaveRoom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 512);
            this.Controls.Add(this.textBoxLabEquipment);
            this.Controls.Add(this.lblLabEquipment);
            this.Controls.Add(this.textBoxLabName);
            this.Controls.Add(this.lblLabName);
            this.Controls.Add(this.textBoxMonthlyFunding);
            this.Controls.Add(this.lblMonthlyFunding);
            this.Controls.Add(this.textBoxComputerAmount);
            this.Controls.Add(this.textBoxStudentCapacity);
            this.Controls.Add(this.lblComputerAmount);
            this.Controls.Add(this.lblStudentCapacity);
            this.Controls.Add(this.buttonSaveRoom);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddLab";
            this.Text = "FormAddLab";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button buttonSaveRoom;
        private System.Windows.Forms.Label lblStudentCapacity;
        private System.Windows.Forms.Label lblComputerAmount;
        private System.Windows.Forms.TextBox textBoxStudentCapacity;
        private System.Windows.Forms.TextBox textBoxComputerAmount;
        private System.Windows.Forms.Label lblMonthlyFunding;
        private System.Windows.Forms.TextBox textBoxMonthlyFunding;
        private System.Windows.Forms.Label lblLabName;
        private System.Windows.Forms.TextBox textBoxLabName;
        private System.Windows.Forms.Label lblLabEquipment;
        private System.Windows.Forms.TextBox textBoxLabEquipment;
        private System.Windows.Forms.Timer timer1;
    }
}