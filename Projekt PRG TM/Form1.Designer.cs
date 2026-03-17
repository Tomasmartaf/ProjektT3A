namespace Projekt_PRG_TM
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
            button1 = new Button();
            btnKonec = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Source Code Pro", 18F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(90, 166);
            button1.Name = "button1";
            button1.Size = new Size(469, 40);
            button1.TabIndex = 1;
            button1.Text = "Hrát";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnKonec
            // 
            btnKonec.BackColor = Color.White;
            btnKonec.Font = new Font("Source Code Pro", 18F, FontStyle.Bold);
            btnKonec.Location = new Point(90, 255);
            btnKonec.Name = "btnKonec";
            btnKonec.Size = new Size(469, 40);
            btnKonec.TabIndex = 2;
            btnKonec.Text = "KONEC";
            btnKonec.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.šibenice;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(629, 594);
            Controls.Add(btnKonec);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnKonec;
    }
}
