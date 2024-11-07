namespace LibraryProject
{
    partial class frmBorrow
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.cboTotalBook = new System.Windows.Forms.ComboBox();
            this.txtBorrowStatus = new System.Windows.Forms.TextBox();
            this.txtBorrowID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBorrowStatus = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblBorrowID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(739, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 47);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrow.Location = new System.Drawing.Point(463, 243);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(369, 28);
            this.dtpBorrow.TabIndex = 35;
            // 
            // dtpDue
            // 
            this.dtpDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDue.Location = new System.Drawing.Point(463, 290);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(369, 28);
            this.dtpDue.TabIndex = 34;
            // 
            // cboTotalBook
            // 
            this.cboTotalBook.Font = new System.Drawing.Font("Cambria", 11F);
            this.cboTotalBook.FormattingEnabled = true;
            this.cboTotalBook.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboTotalBook.Location = new System.Drawing.Point(754, 48);
            this.cboTotalBook.Name = "cboTotalBook";
            this.cboTotalBook.Size = new System.Drawing.Size(205, 29);
            this.cboTotalBook.TabIndex = 33;
            // 
            // txtBorrowStatus
            // 
            this.txtBorrowStatus.Font = new System.Drawing.Font("Cambria", 11F);
            this.txtBorrowStatus.Location = new System.Drawing.Point(754, 112);
            this.txtBorrowStatus.Multiline = true;
            this.txtBorrowStatus.Name = "txtBorrowStatus";
            this.txtBorrowStatus.Size = new System.Drawing.Size(205, 110);
            this.txtBorrowStatus.TabIndex = 32;
            // 
            // txtBorrowID
            // 
            this.txtBorrowID.Font = new System.Drawing.Font("Cambria", 11F);
            this.txtBorrowID.Location = new System.Drawing.Point(376, 48);
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.Size = new System.Drawing.Size(180, 29);
            this.txtBorrowID.TabIndex = 31;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Cambria", 11F);
            this.txtMemberID.Location = new System.Drawing.Point(376, 116);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(180, 29);
            this.txtMemberID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Borrow";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(35, 427);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowTemplate.Height = 28;
            this.dgvBorrow.Size = new System.Drawing.Size(1098, 254);
            this.dgvBorrow.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(298, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 47);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(522, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 47);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblBorrowStatus
            // 
            this.lblBorrowStatus.AutoSize = true;
            this.lblBorrowStatus.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBorrowStatus.Location = new System.Drawing.Point(593, 117);
            this.lblBorrowStatus.Name = "lblBorrowStatus";
            this.lblBorrowStatus.Size = new System.Drawing.Size(133, 23);
            this.lblBorrowStatus.TabIndex = 25;
            this.lblBorrowStatus.Text = "Borrow Status";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblTotalBook.Location = new System.Drawing.Point(593, 51);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(95, 22);
            this.lblTotalBook.TabIndex = 24;
            this.lblTotalBook.Text = "Total Book";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblMemberID.Location = new System.Drawing.Point(210, 117);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(105, 23);
            this.lblMemberID.TabIndex = 23;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblDueDate.Location = new System.Drawing.Point(275, 293);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(88, 23);
            this.lblDueDate.TabIndex = 22;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBorrowDate.Location = new System.Drawing.Point(275, 246);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(119, 23);
            this.lblBorrowDate.TabIndex = 21;
            this.lblBorrowDate.Text = "Borrow Date";
            // 
            // lblBorrowID
            // 
            this.lblBorrowID.AutoSize = true;
            this.lblBorrowID.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblBorrowID.Location = new System.Drawing.Point(210, 49);
            this.lblBorrowID.Name = "lblBorrowID";
            this.lblBorrowID.Size = new System.Drawing.Size(98, 23);
            this.lblBorrowID.TabIndex = 20;
            this.lblBorrowID.Text = "Borrow ID";
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 693);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpBorrow);
            this.Controls.Add(this.dtpDue);
            this.Controls.Add(this.cboTotalBook);
            this.Controls.Add(this.txtBorrowStatus);
            this.Controls.Add(this.txtBorrowID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblBorrowStatus);
            this.Controls.Add(this.lblTotalBook);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.lblBorrowID);
            this.Name = "frmBorrow";
            this.Text = "frmBorrow";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.ComboBox cboTotalBook;
        private System.Windows.Forms.TextBox txtBorrowStatus;
        private System.Windows.Forms.TextBox txtBorrowID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblBorrowStatus;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblBorrowID;
    }
}