namespace Lab4
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
            pictureBox1 = new PictureBox();
            btnLoad = new Button();
            rb90 = new RadioButton();
            rb180 = new RadioButton();
            rb270 = new RadioButton();
            button1 = new Button();
            btnInvert = new Button();
            btnUpsideDown = new Button();
            btnOnlyGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(398, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 348);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(75, 373);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 40);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // rb90
            // 
            rb90.AutoSize = true;
            rb90.Location = new Point(65, 45);
            rb90.Name = "rb90";
            rb90.Size = new Size(60, 34);
            rb90.TabIndex = 2;
            rb90.TabStop = true;
            rb90.Text = "90";
            rb90.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            rb180.AutoSize = true;
            rb180.Location = new Point(65, 85);
            rb180.Name = "rb180";
            rb180.Size = new Size(71, 34);
            rb180.TabIndex = 3;
            rb180.TabStop = true;
            rb180.Text = "180";
            rb180.UseVisualStyleBackColor = true;
            // 
            // rb270
            // 
            rb270.AutoSize = true;
            rb270.Location = new Point(65, 125);
            rb270.Name = "rb270";
            rb270.Size = new Size(71, 34);
            rb270.TabIndex = 4;
            rb270.TabStop = true;
            rb270.Text = "270";
            rb270.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(54, 165);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 5;
            button1.Text = "Rotate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnInvert
            // 
            btnInvert.Location = new Point(54, 211);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(140, 40);
            btnInvert.TabIndex = 6;
            btnInvert.Text = "Invert Colors";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnUpsideDown
            // 
            btnUpsideDown.Location = new Point(58, 257);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(148, 40);
            btnUpsideDown.TabIndex = 7;
            btnUpsideDown.Text = "Upside Down";
            btnUpsideDown.UseVisualStyleBackColor = true;
            btnUpsideDown.Click += btnUpsideDown_Click;
            // 
            // btnOnlyGreen
            // 
            btnOnlyGreen.Location = new Point(64, 313);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(131, 40);
            btnOnlyGreen.TabIndex = 8;
            btnOnlyGreen.Text = "Only Green";
            btnOnlyGreen.UseVisualStyleBackColor = true;
            btnOnlyGreen.Click += btnOnlyGreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOnlyGreen);
            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvert);
            Controls.Add(button1);
            Controls.Add(rb270);
            Controls.Add(rb180);
            Controls.Add(rb90);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLoad;
        private RadioButton rb90;
        private RadioButton rb180;
        private RadioButton rb270;
        private Button button1;
        private Button btnInvert;
        private Button btnUpsideDown;
        private Button btnOnlyGreen;
    }
}
