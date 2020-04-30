namespace Components
{
    partial class MakeLogarithmSpiral
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
            this.txtNumSpirals = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picSpiral = new System.Windows.Forms.PictureBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpiral)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumSpirals
            // 
            this.txtNumSpirals.Location = new System.Drawing.Point(69, 66);
            this.txtNumSpirals.Name = "txtNumSpirals";
            this.txtNumSpirals.Size = new System.Drawing.Size(67, 20);
            this.txtNumSpirals.TabIndex = 2;
            this.txtNumSpirals.Text = "1";
            this.txtNumSpirals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "# Spirals:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(197, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(69, 14);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(67, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "5";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "A:";
            // 
            // picSpiral
            // 
            this.picSpiral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picSpiral.BackColor = System.Drawing.Color.White;
            this.picSpiral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSpiral.Location = new System.Drawing.Point(12, 92);
            this.picSpiral.Name = "picSpiral";
            this.picSpiral.Size = new System.Drawing.Size(260, 227);
            this.picSpiral.TabIndex = 12;
            this.picSpiral.TabStop = false;
            this.picSpiral.Resize += new System.EventHandler(this.picSpiral_Resize);
            this.picSpiral.Paint += new System.Windows.Forms.PaintEventHandler(this.picSpiral_Paint);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(69, 40);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(67, 20);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0.2";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumSpirals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSpiral);
            this.Name = "Form1";
            this.Text = "howto_logarithmic_spiral";
            ((System.ComponentModel.ISupportInitialize)(this.picSpiral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumSpirals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSpiral;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
    }
}

