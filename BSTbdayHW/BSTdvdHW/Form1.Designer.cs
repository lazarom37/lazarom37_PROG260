namespace Birthday
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
            this.textBoxBday = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdeas = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLookUpDate = new System.Windows.Forms.TextBox();
            this.buttonLookUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBday
            // 
            this.textBoxBday.Location = new System.Drawing.Point(171, 190);
            this.textBoxBday.Name = "textBoxBday";
            this.textBoxBday.Size = new System.Drawing.Size(100, 20);
            this.textBoxBday.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 72);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birthday MMDDYY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idea for present";
            // 
            // textBoxIdeas
            // 
            this.textBoxIdeas.Location = new System.Drawing.Point(137, 117);
            this.textBoxIdeas.Name = "textBoxIdeas";
            this.textBoxIdeas.Size = new System.Drawing.Size(624, 20);
            this.textBoxIdeas.TabIndex = 5;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(28, 233);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(243, 23);
            this.buttonAddNew.TabIndex = 6;
            this.buttonAddNew.Text = "Add New Birthday Data";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birthday MMDDYY";
            // 
            // textBoxLookUpDate
            // 
            this.textBoxLookUpDate.Location = new System.Drawing.Point(567, 183);
            this.textBoxLookUpDate.Name = "textBoxLookUpDate";
            this.textBoxLookUpDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLookUpDate.TabIndex = 7;
            // 
            // buttonLookUp
            // 
            this.buttonLookUp.Location = new System.Drawing.Point(448, 233);
            this.buttonLookUp.Name = "buttonLookUp";
            this.buttonLookUp.Size = new System.Drawing.Size(243, 23);
            this.buttonLookUp.TabIndex = 9;
            this.buttonLookUp.Text = "Enter date above and click to lookup data";
            this.buttonLookUp.UseVisualStyleBackColor = true;
            this.buttonLookUp.Click += new System.EventHandler(this.buttonLookUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.buttonLookUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLookUpDate);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.textBoxIdeas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxBday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBday;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdeas;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLookUpDate;
        private System.Windows.Forms.Button buttonLookUp;
    }
}

