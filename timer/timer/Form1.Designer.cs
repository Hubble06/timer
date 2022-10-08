namespace timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.stoper = new System.Windows.Forms.Button();
            this.si = new System.Windows.Forms.Label();
            this.cho = new System.Windows.Forms.Label();
            this.boon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(76, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.starter);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(506, 307);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(152, 52);
            this.reset.TabIndex = 1;
            this.reset.Text = "초기화";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stoper
            // 
            this.stoper.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stoper.Location = new System.Drawing.Point(290, 307);
            this.stoper.Name = "stoper";
            this.stoper.Size = new System.Drawing.Size(152, 52);
            this.stoper.TabIndex = 2;
            this.stoper.Text = "정지";
            this.stoper.UseVisualStyleBackColor = true;
            this.stoper.Click += new System.EventHandler(this.stoper_Click);
            // 
            // si
            // 
            this.si.AutoSize = true;
            this.si.Font = new System.Drawing.Font("바탕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.si.Location = new System.Drawing.Point(178, 135);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(105, 64);
            this.si.TabIndex = 3;
            this.si.Text = "00";
            // 
            // cho
            // 
            this.cho.AutoSize = true;
            this.cho.Font = new System.Drawing.Font("바탕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cho.Location = new System.Drawing.Point(431, 135);
            this.cho.Name = "cho";
            this.cho.Size = new System.Drawing.Size(105, 64);
            this.cho.TabIndex = 4;
            this.cho.Text = "00";
            // 
            // boon
            // 
            this.boon.AutoSize = true;
            this.boon.Font = new System.Drawing.Font("바탕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boon.Location = new System.Drawing.Point(303, 135);
            this.boon.Name = "boon";
            this.boon.Size = new System.Drawing.Size(105, 64);
            this.boon.TabIndex = 5;
            this.boon.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("바탕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(267, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 64);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("바탕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(394, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 64);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boon);
            this.Controls.Add(this.cho);
            this.Controls.Add(this.si);
            this.Controls.Add(this.stoper);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button reset;
        private Button stoper;
        private Label si;
        private Label cho;
        private Label boon;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}