namespace MultiSDIText
{
    partial class GridViewForm
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
            this.dgvDocument = new System.Windows.Forms.DataGridView();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.gridViewErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocument
            // 
            this.dgvDocument.AllowUserToAddRows = false;
            this.dgvDocument.AllowUserToDeleteRows = false;
            this.dgvDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocument.AutoGenerateColumns = false;
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentDataGridViewTextBoxColumn,
            this.zOrderDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.backgroundColorDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.fontDataGridViewTextBoxColumn,
            this.rotationDataGridViewTextBoxColumn});
            this.dgvDocument.DataSource = this.documentBindingSource;
            this.dgvDocument.Location = new System.Drawing.Point(16, 15);
            this.dgvDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.RowTemplate.Height = 28;
            this.dgvDocument.Size = new System.Drawing.Size(755, 499);
            this.dgvDocument.TabIndex = 0;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zOrderDataGridViewTextBoxColumn
            // 
            this.zOrderDataGridViewTextBoxColumn.DataPropertyName = "ZOrder";
            this.zOrderDataGridViewTextBoxColumn.HeaderText = "ZOrder";
            this.zOrderDataGridViewTextBoxColumn.Name = "zOrderDataGridViewTextBoxColumn";
            this.zOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backgroundColorDataGridViewTextBoxColumn
            // 
            this.backgroundColorDataGridViewTextBoxColumn.DataPropertyName = "BackgroundColor";
            this.backgroundColorDataGridViewTextBoxColumn.HeaderText = "BackgroundColor";
            this.backgroundColorDataGridViewTextBoxColumn.Name = "backgroundColorDataGridViewTextBoxColumn";
            this.backgroundColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fontDataGridViewTextBoxColumn
            // 
            this.fontDataGridViewTextBoxColumn.DataPropertyName = "Font";
            this.fontDataGridViewTextBoxColumn.HeaderText = "Font";
            this.fontDataGridViewTextBoxColumn.Name = "fontDataGridViewTextBoxColumn";
            this.fontDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            this.rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            this.rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            this.rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            this.rotationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(MultiSDIText.Storage.Text);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 589);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(113, 589);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 29);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 590);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 590);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font:";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(431, 589);
            this.btnBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(100, 29);
            this.btnBackgroundColor.TabIndex = 5;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(668, 586);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(100, 29);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Change";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(627, 702);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(505, 702);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(20, 702);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 536);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Content:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(113, 532);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(653, 31);
            this.txtContent.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 642);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Z-Order";
            // 
            // txtZOrder
            // 
            this.txtZOrder.Location = new System.Drawing.Point(113, 639);
            this.txtZOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZOrder.Name = "txtZOrder";
            this.txtZOrder.Size = new System.Drawing.Size(99, 31);
            this.txtZOrder.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 642);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(431, 642);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(99, 31);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 646);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rotation:";
            // 
            // txtRotation
            // 
            this.txtRotation.Location = new System.Drawing.Point(668, 639);
            this.txtRotation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(99, 31);
            this.txtRotation.TabIndex = 17;
            // 
            // gridViewErrorProvider
            // 
            this.gridViewErrorProvider.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 18;
            // 
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 765);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRotation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDocument);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(807, 817);
            this.Name = "GridViewForm";
            this.Text = "GridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDocument;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider gridViewErrorProvider;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}