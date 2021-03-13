namespace CarsDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listCarMarks = new System.Windows.Forms.ListBox();
            this.listCarModels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car models";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cars in garage";
            // 
            // listCarModels
            // 
            this.listCarMarks.FormattingEnabled = true;
            this.listCarMarks.ItemHeight = 16;
            this.listCarMarks.Location = new System.Drawing.Point(60, 83);
            this.listCarMarks.Name = "listCarModels";
            this.listCarMarks.Size = new System.Drawing.Size(120, 84);
            this.listCarMarks.TabIndex = 2;
            this.listCarMarks.SelectedIndexChanged += new System.EventHandler(this.listCarModels_SelectedIndexChanged);
            // 
            // listInGarage
            // 
            this.listCarModels.FormattingEnabled = true;
            this.listCarModels.ItemHeight = 16;
            this.listCarModels.Location = new System.Drawing.Point(223, 83);
            this.listCarModels.Name = "listInGarage";
            this.listCarModels.Size = new System.Drawing.Size(120, 84);
            this.listCarModels.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCarModels);
            this.Controls.Add(this.listCarMarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCarMarks;
        private System.Windows.Forms.ListBox listCarModels;
    }
}

