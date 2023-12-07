namespace contriesinfo_withRest
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
            pictureBox_flags = new PictureBox();
            rtb_ausgabe = new RichTextBox();
            tb_eingabe = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btn_suche = new Button();
            pictureBox_arms = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_flags).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_arms).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_flags
            // 
            pictureBox_flags.Location = new Point(852, 70);
            pictureBox_flags.Margin = new Padding(3, 2, 3, 2);
            pictureBox_flags.Name = "pictureBox_flags";
            pictureBox_flags.Size = new Size(428, 232);
            pictureBox_flags.TabIndex = 0;
            pictureBox_flags.TabStop = false;
            // 
            // rtb_ausgabe
            // 
            rtb_ausgabe.Location = new Point(299, 70);
            rtb_ausgabe.Margin = new Padding(3, 2, 3, 2);
            rtb_ausgabe.Name = "rtb_ausgabe";
            rtb_ausgabe.Size = new Size(422, 156);
            rtb_ausgabe.TabIndex = 1;
            rtb_ausgabe.Text = "";
            // 
            // tb_eingabe
            // 
            tb_eingabe.Location = new Point(462, 362);
            tb_eingabe.Margin = new Padding(3, 2, 3, 2);
            tb_eingabe.Name = "tb_eingabe";
            tb_eingabe.Size = new Size(210, 23);
            tb_eingabe.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 358);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 3;
            label1.Text = "Bitte geben sie die name des land";
            // 
            // button1
            // 
            button1.Location = new Point(664, 421);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(7, 6);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_suche
            // 
            btn_suche.Location = new Point(481, 431);
            btn_suche.Margin = new Padding(3, 2, 3, 2);
            btn_suche.Name = "btn_suche";
            btn_suche.Size = new Size(205, 34);
            btn_suche.TabIndex = 5;
            btn_suche.Text = "Suchen";
            btn_suche.UseVisualStyleBackColor = true;
            btn_suche.Click += btn_suche_Click;
            // 
            // pictureBox_arms
            // 
            pictureBox_arms.Location = new Point(833, 339);
            pictureBox_arms.Margin = new Padding(3, 2, 3, 2);
            pictureBox_arms.Name = "pictureBox_arms";
            pictureBox_arms.Size = new Size(428, 246);
            pictureBox_arms.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_arms.TabIndex = 6;
            pictureBox_arms.TabStop = false;
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 699);
            Controls.Add(pictureBox_arms);
            Controls.Add(btn_suche);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tb_eingabe);
            Controls.Add(rtb_ausgabe);
            Controls.Add(pictureBox_flags);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_flags).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_arms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_flags;
        private RichTextBox rtb_ausgabe;
        private TextBox tb_eingabe;
        private Label label1;
        private Button button1;
        private Button btn_suche;
        private PictureBox pictureBox_arms;
    }
}