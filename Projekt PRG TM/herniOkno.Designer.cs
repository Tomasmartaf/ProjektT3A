namespace Projekt_PRG_TM
{
    partial class herniOkno
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
            btnKonecHerniOkno = new Button();
            SuspendLayout();
            // 
            // btnKonecHerniOkno
            // 
            btnKonecHerniOkno.Location = new Point(909, 272);
            btnKonecHerniOkno.Name = "btnKonecHerniOkno";
            btnKonecHerniOkno.Size = new Size(189, 39);
            btnKonecHerniOkno.TabIndex = 0;
            btnKonecHerniOkno.Text = "KONEC";
            btnKonecHerniOkno.UseVisualStyleBackColor = true;
            btnKonecHerniOkno.Click += btnKonecHerniOkno_Click;
            // 
            // herniOkno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 323);
            Controls.Add(btnKonecHerniOkno);
            Name = "herniOkno";
            Text = "herniOkno";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKonecHerniOkno;
    }
}