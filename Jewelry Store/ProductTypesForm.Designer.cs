﻿namespace Jewelry_Store
{
    partial class PtoductTypesForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AlertBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(549, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Головне меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlertBtn
            // 
            this.AlertBtn.Location = new System.Drawing.Point(385, 170);
            this.AlertBtn.Name = "AlertBtn";
            this.AlertBtn.Size = new System.Drawing.Size(131, 35);
            this.AlertBtn.TabIndex = 27;
            this.AlertBtn.Text = "Редагувати дані";
            this.AlertBtn.UseVisualStyleBackColor = true;
            this.AlertBtn.Click += new System.EventHandler(this.AlertBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(385, 87);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(87, 35);
            this.AddBtn.TabIndex = 26;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(387, 258);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 35);
            this.DeleteBtn.TabIndex = 25;
            this.DeleteBtn.Text = "Видалити";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeIdDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 307);
            this.dataGridView1.TabIndex = 24;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Назва типу";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(Jewelry_Store.Type);
            // 
            // PtoductTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlertBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PtoductTypesForm";
            this.Text = "Типи продуктів";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlertBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource typeBindingSource;
    }
}