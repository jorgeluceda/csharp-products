namespace MultiSDIText
{
    partial class SearchDialog
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
            this.Results = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.extensionsLabel = new System.Windows.Forms.Label();
            this.SearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SearchStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).BeginInit();
            this.SearchStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 16;
            this.Results.Location = new System.Drawing.Point(33, 28);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(403, 388);
            this.Results.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(20, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(113, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Validating += new System.ComponentModel.CancelEventHandler(this.startButton_Validating);
            // 
            // stopButton
            // 
            this.stopButton.CausesValidation = false;
            this.stopButton.Location = new System.Drawing.Point(20, 74);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(113, 36);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.CausesValidation = false;
            this.pauseButton.Location = new System.Drawing.Point(20, 116);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(113, 36);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Location = new System.Drawing.Point(460, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Actions";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            "*.txt",
            "*.html",
            "*.htm"});
            this.extensionComboBox.Location = new System.Drawing.Point(460, 268);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(121, 24);
            this.extensionComboBox.TabIndex = 5;
            // 
            // extensionsLabel
            // 
            this.extensionsLabel.AutoSize = true;
            this.extensionsLabel.Location = new System.Drawing.Point(457, 235);
            this.extensionsLabel.Name = "extensionsLabel";
            this.extensionsLabel.Size = new System.Drawing.Size(99, 17);
            this.extensionsLabel.TabIndex = 6;
            this.extensionsLabel.Text = "File Extension:";
            // 
            // SearchBackgroundWorker
            // 
            this.SearchBackgroundWorker.WorkerReportsProgress = true;
            this.SearchBackgroundWorker.WorkerSupportsCancellation = true;
            this.SearchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchBackgroundWorker_DoWork);
            this.SearchBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SearchBackgroundWorker_ProgressChanged);
            this.SearchBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchBackgroundWorker_RunWorkerCompleted);
            // 
            // SearchErrorProvider
            // 
            this.SearchErrorProvider.ContainerControl = this;
            // 
            // SearchStatusStrip
            // 
            this.SearchStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SearchStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripIndicator});
            this.SearchStatusStrip.Location = new System.Drawing.Point(0, 480);
            this.SearchStatusStrip.Name = "SearchStatusStrip";
            this.SearchStatusStrip.Size = new System.Drawing.Size(654, 25);
            this.SearchStatusStrip.TabIndex = 7;
            this.SearchStatusStrip.Text = "statusStrip1";
            // 
            // StatusStripIndicator
            // 
            this.StatusStripIndicator.Name = "StatusStripIndicator";
            this.StatusStripIndicator.Size = new System.Drawing.Size(50, 20);
            this.StatusStripIndicator.Text = "Ready";
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(654, 505);
            this.Controls.Add(this.SearchStatusStrip);
            this.Controls.Add(this.extensionsLabel);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchDialog";
            this.Text = "SearchDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDialog_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).EndInit();
            this.SearchStatusStrip.ResumeLayout(false);
            this.SearchStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label extensionsLabel;
        private System.ComponentModel.BackgroundWorker SearchBackgroundWorker;
        private System.Windows.Forms.ErrorProvider SearchErrorProvider;
        private System.Windows.Forms.StatusStrip SearchStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripIndicator;
    }
}