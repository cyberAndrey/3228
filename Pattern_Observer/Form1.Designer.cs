namespace Pattern_Observer
{
    partial class Pattern_Observer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButTop = new System.Windows.Forms.Button();
            this.ButRight = new System.Windows.Forms.Button();
            this.ButBot = new System.Windows.Forms.Button();
            this.ButLeft = new System.Windows.Forms.Button();
            this.LabTop = new System.Windows.Forms.Label();
            this.LabRight = new System.Windows.Forms.Label();
            this.LabBot = new System.Windows.Forms.Label();
            this.LabLeft = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButTop
            // 
            this.ButTop.BackColor = System.Drawing.Color.Orange;
            this.ButTop.Location = new System.Drawing.Point(139, 55);
            this.ButTop.Name = "ButTop";
            this.ButTop.Size = new System.Drawing.Size(99, 47);
            this.ButTop.TabIndex = 1;
            this.ButTop.Text = "Top";
            this.ButTop.UseVisualStyleBackColor = false;
            this.ButTop.Click += new System.EventHandler(this.ButTop_Click);
            // 
            // ButRight
            // 
            this.ButRight.BackColor = System.Drawing.Color.Orange;
            this.ButRight.Location = new System.Drawing.Point(253, 145);
            this.ButRight.Name = "ButRight";
            this.ButRight.Size = new System.Drawing.Size(99, 47);
            this.ButRight.TabIndex = 2;
            this.ButRight.Text = "Right";
            this.ButRight.UseVisualStyleBackColor = false;
            this.ButRight.Click += new System.EventHandler(this.ButRight_Click);
            // 
            // ButBot
            // 
            this.ButBot.BackColor = System.Drawing.Color.Orange;
            this.ButBot.Location = new System.Drawing.Point(139, 231);
            this.ButBot.Name = "ButBot";
            this.ButBot.Size = new System.Drawing.Size(99, 47);
            this.ButBot.TabIndex = 3;
            this.ButBot.Text = "Bot";
            this.ButBot.UseVisualStyleBackColor = false;
            this.ButBot.Click += new System.EventHandler(this.ButBot_Click);
            // 
            // ButLeft
            // 
            this.ButLeft.BackColor = System.Drawing.Color.Orange;
            this.ButLeft.Location = new System.Drawing.Point(22, 145);
            this.ButLeft.Name = "ButLeft";
            this.ButLeft.Size = new System.Drawing.Size(99, 47);
            this.ButLeft.TabIndex = 4;
            this.ButLeft.Text = "Left";
            this.ButLeft.UseVisualStyleBackColor = false;
            this.ButLeft.Click += new System.EventHandler(this.ButLeft_Click);
            // 
            // LabTop
            // 
            this.LabTop.BackColor = System.Drawing.Color.Red;
            this.LabTop.Location = new System.Drawing.Point(91, 17);
            this.LabTop.MaximumSize = new System.Drawing.Size(50, 50);
            this.LabTop.Name = "LabTop";
            this.LabTop.Size = new System.Drawing.Size(50, 50);
            this.LabTop.TabIndex = 5;
            // 
            // LabRight
            // 
            this.LabRight.BackColor = System.Drawing.Color.Blue;
            this.LabRight.Location = new System.Drawing.Point(156, 89);
            this.LabRight.MaximumSize = new System.Drawing.Size(50, 50);
            this.LabRight.Name = "LabRight";
            this.LabRight.Size = new System.Drawing.Size(50, 50);
            this.LabRight.TabIndex = 6;
            // 
            // LabBot
            // 
            this.LabBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabBot.Location = new System.Drawing.Point(91, 152);
            this.LabBot.MaximumSize = new System.Drawing.Size(50, 50);
            this.LabBot.Name = "LabBot";
            this.LabBot.Size = new System.Drawing.Size(50, 50);
            this.LabBot.TabIndex = 7;
            // 
            // LabLeft
            // 
            this.LabLeft.BackColor = System.Drawing.Color.Yellow;
            this.LabLeft.Location = new System.Drawing.Point(23, 89);
            this.LabLeft.MaximumSize = new System.Drawing.Size(50, 50);
            this.LabLeft.Name = "LabLeft";
            this.LabLeft.Size = new System.Drawing.Size(50, 50);
            this.LabLeft.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.LabBot);
            this.panel1.Controls.Add(this.LabTop);
            this.panel1.Controls.Add(this.LabLeft);
            this.panel1.Controls.Add(this.LabRight);
            this.panel1.Location = new System.Drawing.Point(547, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 225);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Object";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBOutput
            // 
            this.TBOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBOutput.Location = new System.Drawing.Point(22, 397);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(755, 30);
            this.TBOutput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Observer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Top";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Right";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Left";
            // 
            // Pattern_Observer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButLeft);
            this.Controls.Add(this.ButBot);
            this.Controls.Add(this.ButRight);
            this.Controls.Add(this.ButTop);
            this.Name = "Pattern_Observer";
            this.Text = "Pattern_Observer";
            this.Load += new System.EventHandler(this.Pattern_Observer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButTop;
        private System.Windows.Forms.Button ButRight;
        private System.Windows.Forms.Button ButBot;
        private System.Windows.Forms.Button ButLeft;
        private System.Windows.Forms.Label LabTop;
        private System.Windows.Forms.Label LabRight;
        private System.Windows.Forms.Label LabBot;
        private System.Windows.Forms.Label LabLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

