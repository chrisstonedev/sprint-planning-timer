namespace SprintPlanningTimer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label openItemCountLabelStart;
            System.Windows.Forms.Label openItemCountLabelEnd;
            System.Windows.Forms.Label dueTimeLabel;
            System.Windows.Forms.Label totalTimeLabel;
            System.Windows.Forms.Label itemTimeLabel;
            this.dueTime = new System.Windows.Forms.DateTimePicker();
            this.openItemCount = new System.Windows.Forms.NumericUpDown();
            this.oneDownButton = new System.Windows.Forms.Button();
            this.startOverButton = new System.Windows.Forms.Button();
            this.totalTime = new System.Windows.Forms.Label();
            this.itemTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resetItemButton = new System.Windows.Forms.Button();
            openItemCountLabelStart = new System.Windows.Forms.Label();
            openItemCountLabelEnd = new System.Windows.Forms.Label();
            dueTimeLabel = new System.Windows.Forms.Label();
            totalTimeLabel = new System.Windows.Forms.Label();
            itemTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // openItemCountLabelStart
            // 
            openItemCountLabelStart.AutoSize = true;
            openItemCountLabelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openItemCountLabelStart.Location = new System.Drawing.Point(33, 35);
            openItemCountLabelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            openItemCountLabelStart.Name = "openItemCountLabelStart";
            openItemCountLabelStart.Size = new System.Drawing.Size(113, 29);
            openItemCountLabelStart.TabIndex = 0;
            openItemCountLabelStart.Text = "We have";
            // 
            // openItemCountLabelEnd
            // 
            openItemCountLabelEnd.AutoSize = true;
            openItemCountLabelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openItemCountLabelEnd.Location = new System.Drawing.Point(350, 35);
            openItemCountLabelEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            openItemCountLabelEnd.Name = "openItemCountLabelEnd";
            openItemCountLabelEnd.Size = new System.Drawing.Size(142, 29);
            openItemCountLabelEnd.TabIndex = 4;
            openItemCountLabelEnd.Text = "open items";
            // 
            // dueTimeLabel
            // 
            dueTimeLabel.AutoSize = true;
            dueTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dueTimeLabel.Location = new System.Drawing.Point(33, 131);
            dueTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dueTimeLabel.Name = "dueTimeLabel";
            dueTimeLabel.Size = new System.Drawing.Size(170, 29);
            dueTimeLabel.TabIndex = 5;
            dueTimeLabel.Text = "to address by";
            // 
            // totalTimeLabel
            // 
            totalTimeLabel.AutoSize = true;
            totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalTimeLabel.Location = new System.Drawing.Point(33, 331);
            totalTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalTimeLabel.Name = "totalTimeLabel";
            totalTimeLabel.Size = new System.Drawing.Size(237, 29);
            totalTimeLabel.TabIndex = 8;
            totalTimeLabel.Text = "In order to finish in:";
            // 
            // itemTimeLabel
            // 
            itemTimeLabel.AutoSize = true;
            itemTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemTimeLabel.Location = new System.Drawing.Point(33, 446);
            itemTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            itemTimeLabel.Name = "itemTimeLabel";
            itemTimeLabel.Size = new System.Drawing.Size(438, 29);
            itemTimeLabel.TabIndex = 9;
            itemTimeLabel.Text = "We must move on to the next item in:";
            // 
            // dueTime
            // 
            this.dueTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dueTime.Location = new System.Drawing.Point(248, 131);
            this.dueTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dueTime.Name = "dueTime";
            this.dueTime.Size = new System.Drawing.Size(246, 35);
            this.dueTime.TabIndex = 1;
            // 
            // openItemCount
            // 
            this.openItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openItemCount.Location = new System.Drawing.Point(160, 32);
            this.openItemCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openItemCount.Name = "openItemCount";
            this.openItemCount.Size = new System.Drawing.Size(180, 35);
            this.openItemCount.TabIndex = 0;
            this.openItemCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // oneDownButton
            // 
            this.oneDownButton.Enabled = false;
            this.oneDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDownButton.Location = new System.Drawing.Point(38, 218);
            this.oneDownButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oneDownButton.Name = "oneDownButton";
            this.oneDownButton.Size = new System.Drawing.Size(140, 62);
            this.oneDownButton.TabIndex = 6;
            this.oneDownButton.Text = "&1 Down";
            this.oneDownButton.UseVisualStyleBackColor = true;
            this.oneDownButton.Click += new System.EventHandler(this.OneDownButton_Click);
            // 
            // startOverButton
            // 
            this.startOverButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startOverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOverButton.Location = new System.Drawing.Point(354, 218);
            this.startOverButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startOverButton.Name = "startOverButton";
            this.startOverButton.Size = new System.Drawing.Size(140, 62);
            this.startOverButton.TabIndex = 7;
            this.startOverButton.Text = "&Start";
            this.startOverButton.UseVisualStyleBackColor = true;
            this.startOverButton.Click += new System.EventHandler(this.StartOverButton_Click);
            // 
            // totalTime
            // 
            this.totalTime.Enabled = false;
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTime.Location = new System.Drawing.Point(39, 362);
            this.totalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(456, 85);
            this.totalTime.TabIndex = 10;
            this.totalTime.Text = "0:00:00";
            this.totalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemTime
            // 
            this.itemTime.Enabled = false;
            this.itemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTime.Location = new System.Drawing.Point(39, 477);
            this.itemTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemTime.Name = "itemTime";
            this.itemTime.Size = new System.Drawing.Size(456, 85);
            this.itemTime.TabIndex = 11;
            this.itemTime.Text = "0:00:00";
            this.itemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // resetItemButton
            // 
            this.resetItemButton.Enabled = false;
            this.resetItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetItemButton.Location = new System.Drawing.Point(196, 218);
            this.resetItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetItemButton.Name = "resetItemButton";
            this.resetItemButton.Size = new System.Drawing.Size(140, 62);
            this.resetItemButton.TabIndex = 12;
            this.resetItemButton.Text = "Reset Item";
            this.resetItemButton.UseVisualStyleBackColor = true;
            this.resetItemButton.Click += new System.EventHandler(this.ResetItemButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.startOverButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 583);
            this.Controls.Add(this.resetItemButton);
            this.Controls.Add(this.itemTime);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(itemTimeLabel);
            this.Controls.Add(totalTimeLabel);
            this.Controls.Add(this.startOverButton);
            this.Controls.Add(this.oneDownButton);
            this.Controls.Add(dueTimeLabel);
            this.Controls.Add(openItemCountLabelEnd);
            this.Controls.Add(this.openItemCount);
            this.Controls.Add(this.dueTime);
            this.Controls.Add(openItemCountLabelStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sprint Planning Timer";
            ((System.ComponentModel.ISupportInitialize)(this.openItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dueTime;
        private System.Windows.Forms.NumericUpDown openItemCount;
        private System.Windows.Forms.Button oneDownButton;
        private System.Windows.Forms.Button startOverButton;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label itemTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetItemButton;
    }
}