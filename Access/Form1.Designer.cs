namespace Access
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
            this.gbAccess = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.cmbPeople = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbAccess.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccess
            // 
            this.gbAccess.Controls.Add(this.groupBox2);
            this.gbAccess.Controls.Add(this.gbInsert);
            this.gbAccess.Location = new System.Drawing.Point(12, 12);
            this.gbAccess.Name = "gbAccess";
            this.gbAccess.Size = new System.Drawing.Size(254, 293);
            this.gbAccess.TabIndex = 0;
            this.gbAccess.TabStop = false;
            this.gbAccess.Text = "Access";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnLista);
            this.groupBox2.Controls.Add(this.cmbPeople);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtNewLastName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNewFirstName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select / Update / Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(133, 17);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(100, 23);
            this.btnLista.TabIndex = 11;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // cmbPeople
            // 
            this.cmbPeople.FormattingEnabled = true;
            this.cmbPeople.Location = new System.Drawing.Point(6, 19);
            this.cmbPeople.Name = "cmbPeople";
            this.cmbPeople.Size = new System.Drawing.Size(121, 21);
            this.cmbPeople.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(95, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(95, 102);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(100, 20);
            this.txtNewLastName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "New First Name";
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.Location = new System.Drawing.Point(95, 76);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtNewFirstName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.btnInsert);
            this.gbInsert.Controls.Add(this.txtLastName);
            this.gbInsert.Controls.Add(this.txtFirstName);
            this.gbInsert.Controls.Add(this.lblLastName);
            this.gbInsert.Controls.Add(this.lblFirstName);
            this.gbInsert.Location = new System.Drawing.Point(6, 19);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(241, 100);
            this.gbInsert.TabIndex = 0;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "Insert";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(70, 69);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(70, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 313);
            this.Controls.Add(this.gbAccess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAccess.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.ComboBox cmbPeople;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}

