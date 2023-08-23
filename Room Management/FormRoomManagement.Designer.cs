
namespace Project
{
    partial class FormRoomManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRoomManagement = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridRooms = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblSearchByRoom = new System.Windows.Forms.Label();
            this.buttonSearchRoom = new System.Windows.Forms.Button();
            this.textBoxSearchRoom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblRoomManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 129);
            this.panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(869, 87);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 43);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblRoomManagement
            // 
            this.lblRoomManagement.AutoSize = true;
            this.lblRoomManagement.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomManagement.Location = new System.Drawing.Point(320, 52);
            this.lblRoomManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomManagement.Name = "lblRoomManagement";
            this.lblRoomManagement.Size = new System.Drawing.Size(399, 43);
            this.lblRoomManagement.TabIndex = 0;
            this.lblRoomManagement.Text = "Room Management";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridRooms
            // 
            this.dataGridRooms.AllowUserToAddRows = false;
            this.dataGridRooms.AllowUserToDeleteRows = false;
            this.dataGridRooms.AllowUserToResizeRows = false;
            this.dataGridRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type});
            this.dataGridRooms.EnableHeadersVisualStyles = false;
            this.dataGridRooms.Location = new System.Drawing.Point(369, 182);
            this.dataGridRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridRooms.Name = "dataGridRooms";
            this.dataGridRooms.ReadOnly = true;
            this.dataGridRooms.RowHeadersVisible = false;
            this.dataGridRooms.RowHeadersWidth = 51;
            this.dataGridRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRooms.Size = new System.Drawing.Size(681, 357);
            this.dataGridRooms.TabIndex = 1;
            this.dataGridRooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRooms_CellDoubleClick);
            this.dataGridRooms.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridRooms_DataBindingComplete);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Turquoise;
            this.lblAdd.Location = new System.Drawing.Point(74, 182);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(194, 43);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Add Room";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistics.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.ForeColor = System.Drawing.Color.Turquoise;
            this.lblStatistics.Location = new System.Drawing.Point(28, 269);
            this.lblStatistics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(272, 43);
            this.lblStatistics.TabIndex = 3;
            this.lblStatistics.Text = "Show Statistics";
            this.lblStatistics.Click += new System.EventHandler(this.lblStatistics_Click);
            // 
            // lblSearchByRoom
            // 
            this.lblSearchByRoom.AutoSize = true;
            this.lblSearchByRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchByRoom.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.lblSearchByRoom.Location = new System.Drawing.Point(28, 354);
            this.lblSearchByRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByRoom.Name = "lblSearchByRoom";
            this.lblSearchByRoom.Size = new System.Drawing.Size(309, 43);
            this.lblSearchByRoom.TabIndex = 4;
            this.lblSearchByRoom.Text = "Search By Room:";
            // 
            // buttonSearchRoom
            // 
            this.buttonSearchRoom.BackColor = System.Drawing.Color.Khaki;
            this.buttonSearchRoom.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchRoom.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonSearchRoom.Location = new System.Drawing.Point(109, 478);
            this.buttonSearchRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchRoom.Name = "buttonSearchRoom";
            this.buttonSearchRoom.Size = new System.Drawing.Size(129, 62);
            this.buttonSearchRoom.TabIndex = 15;
            this.buttonSearchRoom.Text = "Search";
            this.buttonSearchRoom.UseVisualStyleBackColor = false;
            this.buttonSearchRoom.Click += new System.EventHandler(this.buttonSearchRoom_Click);
            // 
            // textBoxSearchRoom
            // 
            this.textBoxSearchRoom.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchRoom.Location = new System.Drawing.Point(36, 426);
            this.textBoxSearchRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchRoom.Name = "textBoxSearchRoom";
            this.textBoxSearchRoom.Size = new System.Drawing.Size(277, 30);
            this.textBoxSearchRoom.TabIndex = 19;
            this.textBoxSearchRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormRoomManagement
            // 
            this.AcceptButton = this.buttonSearchRoom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxSearchRoom);
            this.Controls.Add(this.buttonSearchRoom);
            this.Controls.Add(this.lblSearchByRoom);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.dataGridRooms);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRoomManagement";
            this.Text = "Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRoomManagement;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridRooms;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label lblSearchByRoom;
        private System.Windows.Forms.Button buttonSearchRoom;
        private System.Windows.Forms.TextBox textBoxSearchRoom;
    }
}

