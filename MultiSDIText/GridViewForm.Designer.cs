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
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackgroundColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Font = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocument
            // 
            this.dgvDocument.AutoGenerateColumns = false;
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content,
            this.ZOrder,
            this.Color,
            this.BackgroundColor,
            this.Location,
            this.Font,
            this.Rotation});
            this.dgvDocument.DataSource = this.documentBindingSource;
            this.dgvDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocument.Location = new System.Drawing.Point(0, 0);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.RowTemplate.Height = 28;
            this.dgvDocument.Size = new System.Drawing.Size(1007, 689);
            this.dgvDocument.TabIndex = 0;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(MultiSDIText.Storage.Document);
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            // 
            // ZOrder
            // 
            this.ZOrder.HeaderText = "Z-Order";
            this.ZOrder.Name = "ZOrder";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.HeaderText = "Background Color";
            this.BackgroundColor.Name = "BackgroundColor";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Font
            // 
            this.Font.HeaderText = "Font";
            this.Font.Name = "Font";
            // 
            // Rotation
            // 
            this.Rotation.HeaderText = "Rotation";
            this.Rotation.Name = "Rotation";
            // 
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 689);
            this.Controls.Add(this.dgvDocument);
            this.Name = "GridViewForm";
            this.Text = "GridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocument;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackgroundColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Font;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rotation;
    }
}