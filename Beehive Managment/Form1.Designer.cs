namespace Beehive_Managment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignJobButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.reportTextbox = new System.Windows.Forms.TextBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJobButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assigments";
            // 
            // assignJobButton
            // 
            this.assignJobButton.Location = new System.Drawing.Point(6, 65);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(240, 23);
            this.assignJobButton.TabIndex = 4;
            this.assignJobButton.Text = "Assign this job to a bee";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(172, 37);
            this.shifts.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(74, 20);
            this.shifts.TabIndex = 1;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Location = new System.Drawing.Point(6, 37);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(160, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // reportTextbox
            // 
            this.reportTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportTextbox.Location = new System.Drawing.Point(12, 142);
            this.reportTextbox.Multiline = true;
            this.reportTextbox.Name = "reportTextbox";
            this.reportTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportTextbox.Size = new System.Drawing.Size(385, 199);
            this.reportTextbox.TabIndex = 1;
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextShift.Location = new System.Drawing.Point(286, 21);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(111, 94);
            this.nextShift.TabIndex = 5;
            this.nextShift.Text = "Work  the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 353);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.reportTextbox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beehive Managment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignJobButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.TextBox reportTextbox;
        private System.Windows.Forms.Button nextShift;
    }
}

