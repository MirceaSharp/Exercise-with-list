
namespace Exercise_with_List
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
            this.btnReadStudent = new System.Windows.Forms.Button();
            this.btnReadPoints = new System.Windows.Forms.Button();
            this.btPass = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadStudent
            // 
            this.btnReadStudent.Location = new System.Drawing.Point(478, 60);
            this.btnReadStudent.Name = "btnReadStudent";
            this.btnReadStudent.Size = new System.Drawing.Size(200, 45);
            this.btnReadStudent.TabIndex = 1;
            this.btnReadStudent.Text = "Read Student.txt + Overview";
            this.btnReadStudent.UseVisualStyleBackColor = true;
            this.btnReadStudent.Click += new System.EventHandler(this.btnReadStudent_Click);
            // 
            // btnReadPoints
            // 
            this.btnReadPoints.Location = new System.Drawing.Point(477, 141);
            this.btnReadPoints.Name = "btnReadPoints";
            this.btnReadPoints.Size = new System.Drawing.Size(200, 49);
            this.btnReadPoints.TabIndex = 2;
            this.btnReadPoints.Text = "Identifier \'Read Points.txt + Overview\' ";
            this.btnReadPoints.UseVisualStyleBackColor = true;
            // 
            // btPass
            // 
            this.btPass.Location = new System.Drawing.Point(478, 221);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(199, 47);
            this.btPass.TabIndex = 3;
            this.btPass.Text = "Passed / Didn`t pass";
            this.btPass.UseVisualStyleBackColor = true;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(479, 300);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(198, 54);
            this.btnEmpty.TabIndex = 4;
            this.btnEmpty.Text = "Empty View";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(37, 27);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(412, 326);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btPass);
            this.Controls.Add(this.btnReadPoints);
            this.Controls.Add(this.btnReadStudent);
            this.Name = "Form1";
            this.Text = "Exercise with list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReadStudent;
        private System.Windows.Forms.Button btnReadPoints;
        private System.Windows.Forms.Button btPass;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.TextBox txtResult;
    }
}

