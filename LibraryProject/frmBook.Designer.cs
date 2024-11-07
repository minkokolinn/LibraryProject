namespace LibraryProject
{
    partial class frmBook
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
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.cboAquantity = new System.Windows.Forms.ComboBox();
            this.txtBookStatus = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookStatus = new System.Windows.Forms.Label();
            this.lblAquantity = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookTypeIDk = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBookType
            // 
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.Location = new System.Drawing.Point(303, 110);
            this.cboBookType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(212, 24);
            this.cboBookType.TabIndex = 60;
            this.cboBookType.SelectedIndexChanged += new System.EventHandler(this.cboBookType_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(728, 254);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(601, 254);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(471, 254);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.Location = new System.Drawing.Point(303, 213);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(212, 29);
            this.txtAuthor.TabIndex = 56;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblAuthorName.Location = new System.Drawing.Point(99, 214);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(125, 23);
            this.lblAuthorName.TabIndex = 55;
            this.lblAuthorName.Text = "Author Name";
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(42, 322);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 28;
            this.dgvBook.Size = new System.Drawing.Size(983, 281);
            this.dgvBook.TabIndex = 54;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // cboAquantity
            // 
            this.cboAquantity.Font = new System.Drawing.Font("Cambria", 11F);
            this.cboAquantity.FormatString = "N2";
            this.cboAquantity.FormattingEnabled = true;
            this.cboAquantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboAquantity.Location = new System.Drawing.Point(746, 59);
            this.cboAquantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAquantity.Name = "cboAquantity";
            this.cboAquantity.Size = new System.Drawing.Size(212, 29);
            this.cboAquantity.TabIndex = 53;
            // 
            // txtBookStatus
            // 
            this.txtBookStatus.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookStatus.ForeColor = System.Drawing.Color.Black;
            this.txtBookStatus.Location = new System.Drawing.Point(746, 130);
            this.txtBookStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookStatus.Multiline = true;
            this.txtBookStatus.Name = "txtBookStatus";
            this.txtBookStatus.Size = new System.Drawing.Size(212, 110);
            this.txtBookStatus.TabIndex = 52;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.Location = new System.Drawing.Point(303, 160);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(212, 29);
            this.txtBookName.TabIndex = 51;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Cambria", 11F);
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.Location = new System.Drawing.Point(303, 60);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(212, 29);
            this.txtBookID.TabIndex = 50;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBookStatus.Location = new System.Drawing.Point(542, 130);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(112, 23);
            this.lblBookStatus.TabIndex = 49;
            this.lblBookStatus.Text = "Book Status";
            // 
            // lblAquantity
            // 
            this.lblAquantity.AutoSize = true;
            this.lblAquantity.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblAquantity.Location = new System.Drawing.Point(542, 60);
            this.lblAquantity.Name = "lblAquantity";
            this.lblAquantity.Size = new System.Drawing.Size(167, 23);
            this.lblAquantity.TabIndex = 48;
            this.lblAquantity.Text = "Available Quantity";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBookName.Location = new System.Drawing.Point(99, 161);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(109, 23);
            this.lblBookName.TabIndex = 47;
            this.lblBookName.Text = "Book Name";
            // 
            // lblBookTypeIDk
            // 
            this.lblBookTypeIDk.AutoSize = true;
            this.lblBookTypeIDk.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBookTypeIDk.Location = new System.Drawing.Point(99, 110);
            this.lblBookTypeIDk.Name = "lblBookTypeIDk";
            this.lblBookTypeIDk.Size = new System.Drawing.Size(101, 23);
            this.lblBookTypeIDk.TabIndex = 46;
            this.lblBookTypeIDk.Text = "Book Type";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBookID.Location = new System.Drawing.Point(99, 61);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(77, 23);
            this.lblBookID.TabIndex = 45;
            this.lblBookID.Text = "Book ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "Register Book";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(855, 254);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 39);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(356, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 39);
            this.btnClear.TabIndex = 61;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 614);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cboBookType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.cboAquantity);
            this.Controls.Add(this.txtBookStatus);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookStatus);
            this.Controls.Add(this.lblAquantity);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookTypeIDk);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.label1);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.ComboBox cboAquantity;
        private System.Windows.Forms.TextBox txtBookStatus;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookStatus;
        private System.Windows.Forms.Label lblAquantity;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookTypeIDk;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}