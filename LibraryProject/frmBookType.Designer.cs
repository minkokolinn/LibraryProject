namespace LibraryProject
{
    partial class frmBookType
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBookTypeID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvBooktype = new System.Windows.Forms.DataGridView();
            this.txtBookTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookTypeName = new System.Windows.Forms.Label();
            this.lblBookTypeID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooktype)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(165, 421);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 39);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBookTypeID
            // 
            this.txtBookTypeID.Font = new System.Drawing.Font("Cambria", 11F);
            this.txtBookTypeID.Location = new System.Drawing.Point(252, 81);
            this.txtBookTypeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookTypeID.Name = "txtBookTypeID";
            this.txtBookTypeID.Size = new System.Drawing.Size(208, 29);
            this.txtBookTypeID.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(440, 421);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 39);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(34, 421);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 39);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvBooktype
            // 
            this.dgvBooktype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooktype.Location = new System.Drawing.Point(29, 215);
            this.dgvBooktype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooktype.Name = "dgvBooktype";
            this.dgvBooktype.RowTemplate.Height = 28;
            this.dgvBooktype.Size = new System.Drawing.Size(511, 187);
            this.dgvBooktype.TabIndex = 14;
            this.dgvBooktype.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooktype_CellClick);
            // 
            // txtBookTypeName
            // 
            this.txtBookTypeName.Font = new System.Drawing.Font("Cambria", 11F);
            this.txtBookTypeName.Location = new System.Drawing.Point(252, 150);
            this.txtBookTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookTypeName.Name = "txtBookTypeName";
            this.txtBookTypeName.Size = new System.Drawing.Size(208, 29);
            this.txtBookTypeName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Book Type";
            // 
            // lblBookTypeName
            // 
            this.lblBookTypeName.AutoSize = true;
            this.lblBookTypeName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTypeName.Location = new System.Drawing.Point(52, 150);
            this.lblBookTypeName.Name = "lblBookTypeName";
            this.lblBookTypeName.Size = new System.Drawing.Size(156, 23);
            this.lblBookTypeName.TabIndex = 11;
            this.lblBookTypeName.Text = "Book Type Name";
            // 
            // lblBookTypeID
            // 
            this.lblBookTypeID.AutoSize = true;
            this.lblBookTypeID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTypeID.Location = new System.Drawing.Point(52, 82);
            this.lblBookTypeID.Name = "lblBookTypeID";
            this.lblBookTypeID.Size = new System.Drawing.Size(124, 23);
            this.lblBookTypeID.TabIndex = 10;
            this.lblBookTypeID.Text = "Book Type ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(303, 421);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 535);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBookTypeID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvBooktype);
            this.Controls.Add(this.txtBookTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookTypeName);
            this.Controls.Add(this.lblBookTypeID);
            this.Name = "frmBookType";
            this.Text = "frmBookType";
            this.Load += new System.EventHandler(this.frmBookType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooktype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBookTypeID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvBooktype;
        private System.Windows.Forms.TextBox txtBookTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookTypeName;
        private System.Windows.Forms.Label lblBookTypeID;
        private System.Windows.Forms.Button btnDelete;
    }
}