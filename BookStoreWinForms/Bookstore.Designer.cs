namespace BookstoreWinForms
{
    partial class Bookstore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookstoreDataGridView = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenXml = new System.Windows.Forms.Button();
            this.SaveXml = new System.Windows.Forms.Button();
            this.HtmlReport = new System.Windows.Forms.Button();
            this.AddRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BookstoreDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookstoreDataGridView
            // 
            this.BookstoreDataGridView.AllowUserToAddRows = false;
            this.BookstoreDataGridView.AllowUserToDeleteRows = false;
            this.BookstoreDataGridView.AllowUserToResizeColumns = false;
            this.BookstoreDataGridView.AllowUserToResizeRows = false;
            this.BookstoreDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookstoreDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookstoreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookstoreDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.BookstoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookstoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Year,
            this.Language,
            this.Authors,
            this.Category,
            this.Price});
            this.BookstoreDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.BookstoreDataGridView.Location = new System.Drawing.Point(12, 89);
            this.BookstoreDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.BookstoreDataGridView.Name = "BookstoreDataGridView";
            this.BookstoreDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BookstoreDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookstoreDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BookstoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookstoreDataGridView.Size = new System.Drawing.Size(776, 302);
            this.BookstoreDataGridView.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book.DataPropertyName = "Title";
            this.Book.HeaderText = "Книга";
            this.Book.Name = "Book";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            this.Year.Visible = false;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Язык";
            this.Language.Name = "Language";
            this.Language.Visible = false;
            // 
            // Authors
            // 
            this.Authors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Authors.DataPropertyName = "Authors";
            this.Authors.HeaderText = "Автор";
            this.Authors.Name = "Authors";
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // OpenXml
            // 
            this.OpenXml.Location = new System.Drawing.Point(12, 33);
            this.OpenXml.Name = "OpenXml";
            this.OpenXml.Size = new System.Drawing.Size(114, 23);
            this.OpenXml.TabIndex = 1;
            this.OpenXml.Text = "Открыть XML";
            this.OpenXml.UseVisualStyleBackColor = true;
            this.OpenXml.Click += new System.EventHandler(this.OpenXml_Click);
            // 
            // SaveXml
            // 
            this.SaveXml.Location = new System.Drawing.Point(137, 33);
            this.SaveXml.Name = "SaveXml";
            this.SaveXml.Size = new System.Drawing.Size(120, 23);
            this.SaveXml.TabIndex = 2;
            this.SaveXml.Text = "Сохранить XML";
            this.SaveXml.UseVisualStyleBackColor = true;
            this.SaveXml.Click += new System.EventHandler(this.SaveXml_Click);
            // 
            // HtmlReport
            // 
            this.HtmlReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HtmlReport.Location = new System.Drawing.Point(625, 33);
            this.HtmlReport.Name = "HtmlReport";
            this.HtmlReport.Size = new System.Drawing.Size(163, 23);
            this.HtmlReport.TabIndex = 3;
            this.HtmlReport.Text = "Отчет в HTML";
            this.HtmlReport.UseVisualStyleBackColor = true;
            this.HtmlReport.Click += new System.EventHandler(this.HtmlReport_Click);
            // 
            // AddRecord
            // 
            this.AddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRecord.Location = new System.Drawing.Point(137, 3);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(110, 23);
            this.AddRecord.TabIndex = 4;
            this.AddRecord.Text = "Добавить запись";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRecord.Location = new System.Drawing.Point(12, 3);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(103, 23);
            this.DeleteRecord.TabIndex = 5;
            this.DeleteRecord.Text = "Удалить запись";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HtmlReport);
            this.panel1.Controls.Add(this.OpenXml);
            this.panel1.Controls.Add(this.SaveXml);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddRecord);
            this.panel2.Controls.Add(this.DeleteRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 51);
            this.panel2.TabIndex = 7;
            // 
            // Bookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookstoreDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Bookstore";
            this.Text = "Bookstore XML editor";
            ((System.ComponentModel.ISupportInitialize)(this.BookstoreDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookstoreDataGridView;
        private System.Windows.Forms.Button OpenXml;
        private System.Windows.Forms.Button SaveXml;
        private System.Windows.Forms.Button HtmlReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

