namespace crueybm_Assignment007
{
    partial class frmAssignment07
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
            this.tbBinaryString1 = new System.Windows.Forms.TextBox();
            this.lblBinaryString01 = new System.Windows.Forms.Label();
            this.tbBinaryString2 = new System.Windows.Forms.TextBox();
            this.lblBinaryString2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbWarning = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBinaryString1
            // 
            this.tbBinaryString1.Location = new System.Drawing.Point(130, 12);
            this.tbBinaryString1.Name = "tbBinaryString1";
            this.tbBinaryString1.Size = new System.Drawing.Size(142, 20);
            this.tbBinaryString1.TabIndex = 0;
            this.tbBinaryString1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBinaryString1_KeyPress_1);
            // 
            // lblBinaryString01
            // 
            this.lblBinaryString01.AutoSize = true;
            this.lblBinaryString01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryString01.Location = new System.Drawing.Point(12, 16);
            this.lblBinaryString01.Name = "lblBinaryString01";
            this.lblBinaryString01.Size = new System.Drawing.Size(112, 16);
            this.lblBinaryString01.TabIndex = 1;
            this.lblBinaryString01.Text = "Binary String 1:";
            // 
            // tbBinaryString2
            // 
            this.tbBinaryString2.Location = new System.Drawing.Point(131, 39);
            this.tbBinaryString2.Name = "tbBinaryString2";
            this.tbBinaryString2.Size = new System.Drawing.Size(141, 20);
            this.tbBinaryString2.TabIndex = 2;
            this.tbBinaryString2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBinaryString2_KeyPress);
            // 
            // lblBinaryString2
            // 
            this.lblBinaryString2.AutoSize = true;
            this.lblBinaryString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryString2.Location = new System.Drawing.Point(12, 43);
            this.lblBinaryString2.Name = "lblBinaryString2";
            this.lblBinaryString2.Size = new System.Drawing.Size(112, 16);
            this.lblBinaryString2.TabIndex = 3;
            this.lblBinaryString2.Text = "Binary String 2:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(74, 65);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(198, 20);
            this.tbResult.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 69);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // tbWarning
            // 
            this.tbWarning.Location = new System.Drawing.Point(15, 91);
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.ReadOnly = true;
            this.tbWarning.Size = new System.Drawing.Size(257, 20);
            this.tbWarning.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(102, 117);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAssignment07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbWarning);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblBinaryString2);
            this.Controls.Add(this.tbBinaryString2);
            this.Controls.Add(this.lblBinaryString01);
            this.Controls.Add(this.tbBinaryString1);
            this.Name = "frmAssignment07";
            this.Text = "Assignment 07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBinaryString1;
        private System.Windows.Forms.Label lblBinaryString01;
        private System.Windows.Forms.TextBox tbBinaryString2;
        private System.Windows.Forms.Label lblBinaryString2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbWarning;
        private System.Windows.Forms.Button btnSubmit;
    }
}

