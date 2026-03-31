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
            btnHrat = new Button();
            btnKonec = new Button();
            SuspendLayout();
            // 
            // btnHrat
            // 
            btnHrat.BackColor = Color.White;
            btnHrat.Font = new Font("Source Code Pro", 18F, FontStyle.Bold);
            btnHrat.ForeColor = Color.Black;
            btnHrat.Location = new Point(90, 166);
            btnHrat.Name = "btnHrat";
            btnHrat.Size = new Size(469, 40);
            btnHrat.TabIndex = 1;
            btnHrat.Text = "HRÁT";
            btnHrat.UseVisualStyleBackColor = false;
            btnHrat.Click += btnHrat_Click;
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
            btnKonec.Click += btnKonec_Click;
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
            Controls.Add(btnHrat);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button btnHrat;
        private Button btnKonec;
    }
}
