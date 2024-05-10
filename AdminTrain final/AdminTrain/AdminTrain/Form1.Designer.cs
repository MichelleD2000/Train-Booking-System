namespace Admin
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpddate = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textend = new System.Windows.Forms.TextBox();
            this.textstart = new System.Windows.Forms.TextBox();
            this.texttime = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.txtTrainBox = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.Label();
            this.txtStarting = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(809, 37);
            this.label2.TabIndex = 35;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvAdmin.Location = new System.Drawing.Point(326, 62);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(455, 326);
            this.dgvAdmin.TabIndex = 34;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick_1);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // btnUpddate
            // 
            this.btnUpddate.Location = new System.Drawing.Point(240, 280);
            this.btnUpddate.Name = "btnUpddate";
            this.btnUpddate.Size = new System.Drawing.Size(75, 23);
            this.btnUpddate.TabIndex = 33;
            this.btnUpddate.Text = "UPDATE";
            this.btnUpddate.UseVisualStyleBackColor = true;
            this.btnUpddate.Click += new System.EventHandler(this.btnUpddate_Click_1);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(159, 280);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 32;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(168, 241);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(136, 20);
            this.textBox.TabIndex = 31;
            // 
            // textend
            // 
            this.textend.Location = new System.Drawing.Point(168, 201);
            this.textend.Name = "textend";
            this.textend.Size = new System.Drawing.Size(136, 20);
            this.textend.TabIndex = 30;
            // 
            // textstart
            // 
            this.textstart.Location = new System.Drawing.Point(168, 162);
            this.textstart.Name = "textstart";
            this.textstart.Size = new System.Drawing.Size(136, 20);
            this.textstart.TabIndex = 29;
            // 
            // texttime
            // 
            this.texttime.Location = new System.Drawing.Point(168, 127);
            this.texttime.Name = "texttime";
            this.texttime.Size = new System.Drawing.Size(136, 20);
            this.texttime.TabIndex = 28;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(168, 62);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(136, 20);
            this.textname.TabIndex = 26;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // txtTrainBox
            // 
            this.txtTrainBox.AutoSize = true;
            this.txtTrainBox.Location = new System.Drawing.Point(70, 241);
            this.txtTrainBox.Name = "txtTrainBox";
            this.txtTrainBox.Size = new System.Drawing.Size(49, 13);
            this.txtTrainBox.TabIndex = 25;
            this.txtTrainBox.Text = "TrainBox";
            // 
            // txtEnd
            // 
            this.txtEnd.AutoSize = true;
            this.txtEnd.Location = new System.Drawing.Point(70, 204);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(84, 13);
            this.txtEnd.TabIndex = 24;
            this.txtEnd.Text = "Fishing Location";
            // 
            // txtStarting
            // 
            this.txtStarting.AutoSize = true;
            this.txtStarting.Location = new System.Drawing.Point(70, 169);
            this.txtStarting.Name = "txtStarting";
            this.txtStarting.Size = new System.Drawing.Size(87, 13);
            this.txtStarting.TabIndex = 23;
            this.txtStarting.Text = "Starting Location";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(70, 134);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(30, 13);
            this.txtTime.TabIndex = 22;
            this.txtTime.Text = "Time";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(70, 101);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(30, 13);
            this.txtDate.TabIndex = 21;
            this.txtDate.Text = "Date";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(70, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 20;
            this.txtName.Text = "Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textdate
            // 
            this.textdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textdate.Location = new System.Drawing.Point(168, 93);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(136, 20);
            this.textdate.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.btnUpddate);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textend);
            this.Controls.Add(this.textstart);
            this.Controls.Add(this.texttime);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.txtTrainBox);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStarting);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnUpddate;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textend;
        private System.Windows.Forms.TextBox textstart;
        private System.Windows.Forms.TextBox texttime;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label txtTrainBox;
        private System.Windows.Forms.Label txtEnd;
        private System.Windows.Forms.Label txtStarting;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DateTimePicker textdate;
    }
}

