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
            btnPravidla = new Button();
            SuspendLayout();
            // 
            // btnHrat
            // 
            btnHrat.BackColor = Color.Black;
            btnHrat.FlatAppearance.BorderSize = 0;
            btnHrat.FlatStyle = FlatStyle.Flat;
            btnHrat.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btnHrat.ForeColor = Color.White;
            btnHrat.Location = new Point(90, 166);
            btnHrat.Name = "btnHrat";
            btnHrat.Size = new Size(469, 40);
            btnHrat.TabIndex = 1;
            btnHrat.Text = "HRÁT";
            btnHrat.UseVisualStyleBackColor = false;
            btnHrat.Click += btnHrat_Click;
            btnHrat.Enter += btnHrat_Enter;
            // 
            // btnKonec
            // 
            btnKonec.BackColor = Color.Black;
            btnKonec.FlatAppearance.BorderSize = 0;
            btnKonec.FlatStyle = FlatStyle.Flat;
            btnKonec.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btnKonec.ForeColor = Color.White;
            btnKonec.Location = new Point(90, 292);
            btnKonec.Name = "btnKonec";
            btnKonec.Size = new Size(469, 40);
            btnKonec.TabIndex = 2;
            btnKonec.Text = "KONEC";
            btnKonec.UseVisualStyleBackColor = false;
            btnKonec.Click += btnKonec_Click;
            btnKonec.Enter += btnHrat_Enter;
            // 
            // btnPravidla
            // 
            btnPravidla.BackColor = Color.Black;
            btnPravidla.FlatAppearance.BorderSize = 0;
            btnPravidla.FlatStyle = FlatStyle.Flat;
            btnPravidla.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btnPravidla.ForeColor = Color.White;
            btnPravidla.Location = new Point(90, 230);
            btnPravidla.Name = "btnPravidla";
            btnPravidla.Size = new Size(469, 40);
            btnPravidla.TabIndex = 3;
            btnPravidla.Text = "PRAVIDLA";
            btnPravidla.UseVisualStyleBackColor = false;
            btnPravidla.Click += btnPravidla_Click;
            btnPravidla.Enter += btnHrat_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.šibenice;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(629, 594);
            Controls.Add(btnPravidla);
            Controls.Add(btnKonec);
            Controls.Add(btnHrat);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button btnHrat;
        private Button btnKonec;
        private Button btnPravidla;
    }
}
