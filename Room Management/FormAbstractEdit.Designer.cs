
namespace Project
{
    partial class FormAbstractEdit
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
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxFloorNumber = new System.Windows.Forms.TextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 129);
            this.panel1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(919, 86);
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
            this.lblTitle.Location = new System.Drawing.Point(421, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "AbstractEditForm";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSize.Location = new System.Drawing.Point(387, 390);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(132, 30);
            this.textBoxSize.TabIndex = 18;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(387, 315);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(132, 30);
            this.textBoxLocation.TabIndex = 17;
            // 
            // textBoxFloorNumber
            // 
            this.textBoxFloorNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFloorNumber.Location = new System.Drawing.Point(387, 233);
            this.textBoxFloorNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFloorNumber.Name = "textBoxFloorNumber";
            this.textBoxFloorNumber.Size = new System.Drawing.Size(132, 30);
            this.textBoxFloorNumber.TabIndex = 16;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(387, 154);
            this.textBoxRoomNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(132, 30);
            this.textBoxRoomNumber.TabIndex = 15;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Turquoise;
            this.lblSize.Location = new System.Drawing.Point(31, 382);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(98, 43);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Size:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Turquoise;
            this.lblLocation.Location = new System.Drawing.Point(31, 304);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(179, 43);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Location:";
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblFloorNumber.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorNumber.ForeColor = System.Drawing.Color.Turquoise;
            this.lblFloorNumber.Location = new System.Drawing.Point(31, 223);
            this.lblFloorNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(268, 43);
            this.lblFloorNumber.TabIndex = 12;
            this.lblFloorNumber.Text = "Floor Number:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumber.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Turquoise;
            this.lblRoomNumber.Location = new System.Drawing.Point(31, 144);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(277, 43);
            this.lblRoomNumber.TabIndex = 11;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.Khaki;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonSaveChanges.Location = new System.Drawing.Point(165, 464);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(328, 108);
            this.buttonSaveChanges.TabIndex = 19;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.BackColor = System.Drawing.Color.Khaki;
            this.buttonDeleteRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(621, 464);
            this.buttonDeleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(328, 108);
            this.buttonDeleteRoom.TabIndex = 20;
            this.buttonDeleteRoom.Text = "Delete Room";
            this.buttonDeleteRoom.UseVisualStyleBackColor = false;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAbstractEdit
            // 
            this.AcceptButton = this.buttonSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 606);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxFloorNumber);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblFloorNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAbstractEdit";
            this.Text = "Abstract";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lblDate;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.TextBox textBoxSize;
        protected System.Windows.Forms.TextBox textBoxLocation;
        protected System.Windows.Forms.TextBox textBoxFloorNumber;
        protected System.Windows.Forms.TextBox textBoxRoomNumber;
        protected System.Windows.Forms.Label lblSize;
        protected System.Windows.Forms.Label lblLocation;
        protected System.Windows.Forms.Label lblFloorNumber;
        protected System.Windows.Forms.Label lblRoomNumber;
        protected System.Windows.Forms.Button buttonSaveChanges;
        protected System.Windows.Forms.Button buttonDeleteRoom;
        protected System.Windows.Forms.Timer timer1;
    }
}