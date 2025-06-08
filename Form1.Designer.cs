namespace JSONpractice;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.pnlInputs = new System.Windows.Forms.Panel();
        this.lblId = new System.Windows.Forms.Label();
        this.lblName = new System.Windows.Forms.Label();
        this.lblSalary = new System.Windows.Forms.Label();
        this.lblDesignation = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.txtName = new System.Windows.Forms.TextBox();
        this.txtSalary = new System.Windows.Forms.TextBox();
        this.txtDesignation = new System.Windows.Forms.TextBox();
        this.pnlButtons = new System.Windows.Forms.Panel();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.pnlGrid = new System.Windows.Forms.Panel();
        this.lblGridTitle = new System.Windows.Forms.Label();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.pnlHeader.SuspendLayout();
        this.pnlInputs.SuspendLayout();
        this.pnlButtons.SuspendLayout();
        this.pnlGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(1200, 80);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(30, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(450, 45);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Employee Management System";
        // 
        // pnlInputs
        // 
        this.pnlInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
        this.pnlInputs.Controls.Add(this.lblId);
        this.pnlInputs.Controls.Add(this.lblName);
        this.pnlInputs.Controls.Add(this.lblSalary);
        this.pnlInputs.Controls.Add(this.lblDesignation);
        this.pnlInputs.Controls.Add(this.txtId);
        this.pnlInputs.Controls.Add(this.txtName);
        this.pnlInputs.Controls.Add(this.txtSalary);
        this.pnlInputs.Controls.Add(this.txtDesignation);
        this.pnlInputs.Location = new System.Drawing.Point(30, 100);
        this.pnlInputs.Name = "pnlInputs";
        this.pnlInputs.Size = new System.Drawing.Size(1140, 120);
        this.pnlInputs.TabIndex = 1;
        // 
        // lblId
        // 
        this.lblId.AutoSize = true;
        this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.lblId.Location = new System.Drawing.Point(30, 30);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(100, 21);
        this.lblId.TabIndex = 0;
        this.lblId.Text = "Employee ID";
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.lblName.Location = new System.Drawing.Point(320, 30);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(53, 21);
        this.lblName.TabIndex = 1;
        this.lblName.Text = "Name";
        // 
        // lblSalary
        // 
        this.lblSalary.AutoSize = true;
        this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.lblSalary.Location = new System.Drawing.Point(610, 30);
        this.lblSalary.Name = "lblSalary";
        this.lblSalary.Size = new System.Drawing.Size(56, 21);
        this.lblSalary.TabIndex = 2;
        this.lblSalary.Text = "Salary";
        // 
        // lblDesignation
        // 
        this.lblDesignation.AutoSize = true;
        this.lblDesignation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.lblDesignation.Location = new System.Drawing.Point(900, 30);
        this.lblDesignation.Name = "lblDesignation";
        this.lblDesignation.Size = new System.Drawing.Size(98, 21);
        this.lblDesignation.TabIndex = 3;
        this.lblDesignation.Text = "Designation";
        // 
        // txtId
        // 
        this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtId.Location = new System.Drawing.Point(30, 60);
        this.txtId.Multiline = true;
        this.txtId.Name = "txtId";
        this.txtId.Size = new System.Drawing.Size(250, 35);
        this.txtId.TabIndex = 4;
        this.txtId.BackColor = System.Drawing.Color.White;
        this.txtId.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        // 
        // txtName
        // 
        this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtName.Location = new System.Drawing.Point(320, 60);
        this.txtName.Multiline = true;
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(250, 35);
        this.txtName.TabIndex = 5;
        this.txtName.BackColor = System.Drawing.Color.White;
        this.txtName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        // 
        // txtSalary
        // 
        this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtSalary.Location = new System.Drawing.Point(610, 60);
        this.txtSalary.Multiline = true;
        this.txtSalary.Name = "txtSalary";
        this.txtSalary.Size = new System.Drawing.Size(250, 35);
        this.txtSalary.TabIndex = 6;
        this.txtSalary.BackColor = System.Drawing.Color.White;
        this.txtSalary.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        // 
        // txtDesignation
        // 
        this.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtDesignation.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtDesignation.Location = new System.Drawing.Point(900, 60);
        this.txtDesignation.Multiline = true;
        this.txtDesignation.Name = "txtDesignation";
        this.txtDesignation.Size = new System.Drawing.Size(200, 35);
        this.txtDesignation.TabIndex = 7;
        this.txtDesignation.BackColor = System.Drawing.Color.White;
        this.txtDesignation.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        // 
        // pnlButtons
        // 
        this.pnlButtons.BackColor = System.Drawing.Color.White;
        this.pnlButtons.Controls.Add(this.btnAdd);
        this.pnlButtons.Controls.Add(this.btnUpdate);
        this.pnlButtons.Controls.Add(this.btnDelete);
        this.pnlButtons.Controls.Add(this.btnClear);
        this.pnlButtons.Location = new System.Drawing.Point(30, 240);
        this.pnlButtons.Name = "pnlButtons";
        this.pnlButtons.Size = new System.Drawing.Size(1140, 80);
        this.pnlButtons.TabIndex = 2;
        // 
        // btnAdd
        // 
        this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Location = new System.Drawing.Point(200, 20);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(150, 45);
        this.btnAdd.TabIndex = 8;
        this.btnAdd.Text = "➕ Add Employee";
        this.btnAdd.UseVisualStyleBackColor = false;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        // 
        // btnUpdate
        // 
        this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(370, 20);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(150, 45);
        this.btnUpdate.TabIndex = 9;
        this.btnUpdate.Text = "✏️ Update";
        this.btnUpdate.UseVisualStyleBackColor = false;
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
        // 
        // btnDelete
        // 
        this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.Location = new System.Drawing.Point(540, 20);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(150, 45);
        this.btnDelete.TabIndex = 10;
        this.btnDelete.Text = "🗑️ Delete";
        this.btnDelete.UseVisualStyleBackColor = false;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
        // 
        // btn
        // btnClear
        // 
        this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
        this.btnClear.FlatAppearance.BorderSize = 0;
        this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnClear.ForeColor = System.Drawing.Color.White;
        this.btnClear.Location = new System.Drawing.Point(710, 20);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(150, 45);
        this.btnClear.TabIndex = 11;
        this.btnClear.Text = "🧹 Clear Form";
        this.btnClear.UseVisualStyleBackColor = false;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
        // 
        // pnlGrid
        // 
        this.pnlGrid.BackColor = System.Drawing.Color.White;
        this.pnlGrid.Controls.Add(this.lblGridTitle);
        this.pnlGrid.Controls.Add(this.dataGridView1);
        this.pnlGrid.Location = new System.Drawing.Point(30, 340);
        this.pnlGrid.Name = "pnlGrid";
        this.pnlGrid.Size = new System.Drawing.Size(1140, 400);
        this.pnlGrid.TabIndex = 3;
        // 
        // lblGridTitle
        // 
        this.lblGridTitle.AutoSize = true;
        this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
        this.lblGridTitle.Name = "lblGridTitle";
        this.lblGridTitle.Size = new System.Drawing.Size(180, 30);
        this.lblGridTitle.TabIndex = 1;
        this.lblGridTitle.Text = "📋 Employee List";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AllowUserToDeleteRows = false;
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        this.dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersHeight = 40;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        this.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
        this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
        this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.dataGridView1.EnableHeadersVisualStyles = false;
        this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
        this.dataGridView1.Location = new System.Drawing.Point(20, 60);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.RowTemplate.Height = 35;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new System.Drawing.Size(1100, 320);
        this.dataGridView1.TabIndex = 12;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
        this.ClientSize = new System.Drawing.Size(1200, 760);
        this.Controls.Add(this.pnlGrid);
        this.Controls.Add(this.pnlButtons);
        this.Controls.Add(this.pnlInputs);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = true;
        this.MinimizeBox = true;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Employee Management System - JSON Practice";
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.pnlInputs.ResumeLayout(false);
        this.pnlInputs.PerformLayout();
        this.pnlButtons.ResumeLayout(false);
        this.pnlGrid.ResumeLayout(false);
        this.pnlGrid.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlInputs;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblSalary;
    private System.Windows.Forms.Label lblDesignation;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtSalary;
    private System.Windows.Forms.TextBox txtDesignation;
    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Panel pnlGrid;
    private System.Windows.Forms.Label lblGridTitle;
    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}
