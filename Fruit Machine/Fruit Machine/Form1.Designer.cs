namespace Fruit_Machine
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            Slot1 = new PictureBox();
            Slot3 = new PictureBox();
            Slot2 = new PictureBox();
            Slot1Upper = new PictureBox();
            Slot2Lower = new PictureBox();
            Slot2Upper = new PictureBox();
            Slot3Lower = new PictureBox();
            Slot3Upper = new PictureBox();
            Slot1Lower = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot1Upper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot2Lower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot2Upper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot3Lower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot3Upper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot1Lower).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Open Sans Extrabold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(326, 368);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 0;
            button1.Text = "Spin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 3000;
            timer2.Tick += timer2_Tick;
            // 
            // Slot1
            // 
            Slot1.Location = new Point(164, 147);
            Slot1.Name = "Slot1";
            Slot1.Size = new Size(140, 123);
            Slot1.TabIndex = 1;
            Slot1.TabStop = false;
            // 
            // Slot3
            // 
            Slot3.Location = new Point(490, 147);
            Slot3.Name = "Slot3";
            Slot3.Size = new Size(140, 123);
            Slot3.TabIndex = 2;
            Slot3.TabStop = false;
            // 
            // Slot2
            // 
            Slot2.Location = new Point(326, 147);
            Slot2.Name = "Slot2";
            Slot2.Size = new Size(140, 123);
            Slot2.TabIndex = 3;
            Slot2.TabStop = false;
            // 
            // Slot1Upper
            // 
            Slot1Upper.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Slot1Upper.Location = new Point(13, -50);
            Slot1Upper.Name = "Slot1Upper";
            Slot1Upper.Size = new Size(140, 123);
            Slot1Upper.TabIndex = 4;
            Slot1Upper.TabStop = false;
            // 
            // Slot2Lower
            // 
            Slot2Lower.Location = new Point(326, 276);
            Slot2Lower.Name = "Slot2Lower";
            Slot2Lower.Size = new Size(140, 55);
            Slot2Lower.TabIndex = 5;
            Slot2Lower.TabStop = false;
            // 
            // Slot2Upper
            // 
            Slot2Upper.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Slot2Upper.Location = new Point(6, -58);
            Slot2Upper.Name = "Slot2Upper";
            Slot2Upper.Size = new Size(140, 126);
            Slot2Upper.TabIndex = 6;
            Slot2Upper.TabStop = false;
            // 
            // Slot3Lower
            // 
            Slot3Lower.Location = new Point(490, 276);
            Slot3Lower.Name = "Slot3Lower";
            Slot3Lower.Size = new Size(140, 55);
            Slot3Lower.TabIndex = 8;
            Slot3Lower.TabStop = false;
            // 
            // Slot3Upper
            // 
            Slot3Upper.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Slot3Upper.Location = new Point(0, -53);
            Slot3Upper.Name = "Slot3Upper";
            Slot3Upper.Size = new Size(140, 123);
            Slot3Upper.TabIndex = 9;
            Slot3Upper.TabStop = false;
            // 
            // Slot1Lower
            // 
            Slot1Lower.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Slot1Lower.Location = new Point(164, 276);
            Slot1Lower.Name = "Slot1Lower";
            Slot1Lower.Size = new Size(140, 55);
            Slot1Lower.TabIndex = 7;
            Slot1Lower.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(Slot1Upper);
            panel1.Location = new Point(151, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 73);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(Slot2Upper);
            panel2.Location = new Point(320, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 68);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(Slot3Upper);
            panel3.Location = new Point(490, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 70);
            panel3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Slot1Lower);
            Controls.Add(Slot3Lower);
            Controls.Add(Slot2Lower);
            Controls.Add(Slot2);
            Controls.Add(Slot3);
            Controls.Add(Slot1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot1Upper).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot2Lower).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot2Upper).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot3Lower).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot3Upper).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot1Lower).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox Slot1;
        private PictureBox Slot3;
        private PictureBox Slot2;
        private PictureBox Slot1Upper;
        private PictureBox Slot2Lower;
        private PictureBox Slot2Upper;
        private PictureBox Slot3Lower;
        private PictureBox Slot3Upper;
        private PictureBox Slot1Lower;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}