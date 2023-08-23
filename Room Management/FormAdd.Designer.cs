
namespace Project
{
    partial class FormAdd
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxFloorNumber = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.lblChooseRoomType = new System.Windows.Forms.Label();
            this.buttonDormRoom = new System.Windows.Forms.Button();
            this.buttonLab = new System.Windows.Forms.Button();
            this.buttonLectureRoom = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(800, 105);
            this.panel1.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(652, 71);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 34);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(240, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Basic Room Properties";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumber.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Turquoise;
            this.lblRoomNumber.Location = new System.Drawing.Point(12, 136);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(219, 34);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblFloorNumber.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorNumber.ForeColor = System.Drawing.Color.Turquoise;
            this.lblFloorNumber.Location = new System.Drawing.Point(12, 200);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(211, 34);
            this.lblFloorNumber.TabIndex = 4;
            this.lblFloorNumber.Text = "Floor Number:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Turquoise;
            this.lblLocation.Location = new System.Drawing.Point(12, 266);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(142, 34);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Turquoise;
            this.lblSize.Location = new System.Drawing.Point(12, 328);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(78, 34);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size:";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(279, 144);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(100, 26);
            this.textBoxRoomNumber.TabIndex = 7;
            // 
            // textBoxFloorNumber
            // 
            this.textBoxFloorNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFloorNumber.Location = new System.Drawing.Point(279, 208);
            this.textBoxFloorNumber.Name = "textBoxFloorNumber";
            this.textBoxFloorNumber.Size = new System.Drawing.Size(100, 26);
            this.textBoxFloorNumber.TabIndex = 8;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(279, 275);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 26);
            this.textBoxLocation.TabIndex = 9;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSize.Location = new System.Drawing.Point(279, 336);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 26);
            this.textBoxSize.TabIndex = 10;
            // 
            // lblChooseRoomType
            // 
            this.lblChooseRoomType.AutoSize = true;
            this.lblChooseRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseRoomType.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseRoomType.ForeColor = System.Drawing.Color.Turquoise;
            this.lblChooseRoomType.Location = new System.Drawing.Point(482, 144);
            this.lblChooseRoomType.Name = "lblChooseRoomType";
            this.lblChooseRoomType.Size = new System.Drawing.Size(268, 34);
            this.lblChooseRoomType.TabIndex = 11;
            this.lblChooseRoomType.Text = "Choose Room Type";
            // 
            // buttonDormRoom
            // 
            this.buttonDormRoom.BackColor = System.Drawing.Color.Transparent;
            this.buttonDormRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDormRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonDormRoom.Location = new System.Drawing.Point(530, 197);
            this.buttonDormRoom.Name = "buttonDormRoom";
            this.buttonDormRoom.Size = new System.Drawing.Size(153, 36);
            this.buttonDormRoom.TabIndex = 12;
            this.buttonDormRoom.Text = "Dorm Room";
            this.buttonDormRoom.UseVisualStyleBackColor = false;
            this.buttonDormRoom.Click += new System.EventHandler(this.buttonDormRoom_Click);
            // 
            // buttonLab
            // 
            this.buttonLab.BackColor = System.Drawing.Color.Transparent;
            this.buttonLab.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLab.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonLab.Location = new System.Drawing.Point(530, 267);
            this.buttonLab.Name = "buttonLab";
            this.buttonLab.Size = new System.Drawing.Size(153, 36);
            this.buttonLab.TabIndex = 13;
            this.buttonLab.Text = "Lab";
            this.buttonLab.UseVisualStyleBackColor = false;
            this.buttonLab.Click += new System.EventHandler(this.buttonLab_Click);
            // 
            // buttonLectureRoom
            // 
            this.buttonLectureRoom.BackColor = System.Drawing.Color.Transparent;
            this.buttonLectureRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLectureRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonLectureRoom.Location = new System.Drawing.Point(530, 336);
            this.buttonLectureRoom.Name = "buttonLectureRoom";
            this.buttonLectureRoom.Size = new System.Drawing.Size(153, 36);
            this.buttonLectureRoom.TabIndex = 14;
            this.buttonLectureRoom.Text = "Lecture Room";
            this.buttonLectureRoom.UseVisualStyleBackColor = false;
            this.buttonLectureRoom.Click += new System.EventHandler(this.buttonLectureRoom_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLectureRoom);
            this.Controls.Add(this.buttonLab);
            this.Controls.Add(this.buttonDormRoom);
            this.Controls.Add(this.lblChooseRoomType);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxFloorNumber);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblFloorNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdd";
            this.Text = "FromAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.TextBox textBoxFloorNumber;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label lblChooseRoomType;
        private System.Windows.Forms.Button buttonDormRoom;
        private System.Windows.Forms.Button buttonLab;
        private System.Windows.Forms.Button buttonLectureRoom;
    }
}