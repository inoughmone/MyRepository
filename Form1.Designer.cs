namespace MathPractice
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlus1 = new System.Windows.Forms.Label();
            this.lblCalType = new System.Windows.Forms.Label();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTicks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlus1
            // 
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Font = new System.Drawing.Font("宋体", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlus1.Location = new System.Drawing.Point(42, 72);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlus1.Size = new System.Drawing.Size(193, 134);
            this.lblPlus1.TabIndex = 0;
            this.lblPlus1.Text = "88";
            this.lblPlus1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalType
            // 
            this.lblCalType.AutoSize = true;
            this.lblCalType.Font = new System.Drawing.Font("宋体", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCalType.Location = new System.Drawing.Point(196, 72);
            this.lblCalType.Name = "lblCalType";
            this.lblCalType.Size = new System.Drawing.Size(125, 134);
            this.lblCalType.TabIndex = 1;
            this.lblCalType.Text = "+";
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Font = new System.Drawing.Font("宋体", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlus2.Location = new System.Drawing.Point(287, 72);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(193, 134);
            this.lblPlus2.TabIndex = 2;
            this.lblPlus2.Text = "99";
            this.lblPlus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(443, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 134);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // tbxResult
            // 
            this.tbxResult.Font = new System.Drawing.Font("宋体", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxResult.Location = new System.Drawing.Point(543, 72);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(212, 160);
            this.tbxResult.TabIndex = 4;
            this.tbxResult.Text = "33";
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxResult.TextChanged += new System.EventHandler(this.tbxResult_TextChanged);
            this.tbxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxResult_KeyPress);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("宋体", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMark.ForeColor = System.Drawing.Color.Green;
            this.lblMark.Location = new System.Drawing.Point(746, 75);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(192, 134);
            this.lblMark.TabIndex = 5;
            this.lblMark.Text = "√";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNote.ForeColor = System.Drawing.Color.Green;
            this.lblNote.Location = new System.Drawing.Point(42, 271);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(222, 40);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "正确答案：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(670, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(857, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 67);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "10";
            // 
            // lblTicks
            // 
            this.lblTicks.AutoSize = true;
            this.lblTicks.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTicks.Location = new System.Drawing.Point(49, 337);
            this.lblTicks.Name = "lblTicks";
            this.lblTicks.Size = new System.Drawing.Size(69, 20);
            this.lblTicks.TabIndex = 9;
            this.lblTicks.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 623);
            this.Controls.Add(this.lblTicks);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlus2);
            this.Controls.Add(this.lblCalType);
            this.Controls.Add(this.lblPlus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlus1;
        private System.Windows.Forms.Label lblCalType;
        private System.Windows.Forms.Label lblPlus2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTicks;
    }
}

