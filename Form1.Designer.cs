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
            this.label1 = new System.Windows.Forms.Label();
            this.dueTime = new System.Windows.Forms.DateTimePicker();
            this.openItemCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oneDown = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.itemTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.openItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "We have";
            // 
            // dueTime
            // 
            this.dueTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dueTime.Location = new System.Drawing.Point(165, 85);
            this.dueTime.Name = "dueTime";
            this.dueTime.Size = new System.Drawing.Size(165, 26);
            this.dueTime.TabIndex = 1;
            // 
            // openItemCount
            // 
            this.openItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openItemCount.Location = new System.Drawing.Point(107, 21);
            this.openItemCount.Name = "openItemCount";
            this.openItemCount.Size = new System.Drawing.Size(120, 26);
            this.openItemCount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "open items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "to address by";
            // 
            // oneDown
            // 
            this.oneDown.Enabled = false;
            this.oneDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDown.Location = new System.Drawing.Point(48, 142);
            this.oneDown.Name = "oneDown";
            this.oneDown.Size = new System.Drawing.Size(116, 40);
            this.oneDown.TabIndex = 6;
            this.oneDown.Text = "&1 Down";
            this.oneDown.UseVisualStyleBackColor = true;
            this.oneDown.Click += new System.EventHandler(this.OneDown_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(187, 142);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(116, 40);
            this.reset.TabIndex = 7;
            this.reset.Text = "&Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "In order to finish in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "We must move on to the next item in:";
            // 
            // totalTime
            // 
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTime.Location = new System.Drawing.Point(26, 235);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(304, 55);
            this.totalTime.TabIndex = 10;
            this.totalTime.Text = "0:00:00";
            this.totalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemTime
            // 
            this.itemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTime.Location = new System.Drawing.Point(26, 310);
            this.itemTime.Name = "itemTime";
            this.itemTime.Size = new System.Drawing.Size(304, 55);
            this.itemTime.TabIndex = 11;
            this.itemTime.Text = "0:00:00";
            this.itemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 379);
            this.Controls.Add(this.itemTime);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.oneDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openItemCount);
            this.Controls.Add(this.dueTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sprint Planning Timer";
            ((System.ComponentModel.ISupportInitialize)(this.openItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dueTime;
        private System.Windows.Forms.NumericUpDown openItemCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button oneDown;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label itemTime;
        private System.Windows.Forms.Timer timer1;
    }
}