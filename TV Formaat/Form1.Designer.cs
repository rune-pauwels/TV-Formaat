namespace TV_Formaat
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
            HoogteTextBox = new TextBox();
            BreedteTextBox = new TextBox();
            DiagonaalTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BerekenButton = new Button();
            BreedteInchLabel = new Label();
            BreedteCmLabel = new Label();
            DiagonaalCmLabel = new Label();
            label6 = new Label();
            HoogteInchLabel = new Label();
            HoogteCmLabel = new Label();
            SuspendLayout();
            // 
            // HoogteTextBox
            // 
            HoogteTextBox.Location = new Point(210, 291);
            HoogteTextBox.Margin = new Padding(2);
            HoogteTextBox.Name = "HoogteTextBox";
            HoogteTextBox.Size = new Size(25, 23);
            HoogteTextBox.TabIndex = 0;
            // 
            // BreedteTextBox
            // 
            BreedteTextBox.Location = new Point(129, 291);
            BreedteTextBox.Margin = new Padding(2);
            BreedteTextBox.Name = "BreedteTextBox";
            BreedteTextBox.Size = new Size(25, 23);
            BreedteTextBox.TabIndex = 1;
            // 
            // DiagonaalTextBox
            // 
            DiagonaalTextBox.Location = new Point(145, 89);
            DiagonaalTextBox.Margin = new Padding(2);
            DiagonaalTextBox.Name = "DiagonaalTextBox";
            DiagonaalTextBox.Size = new Size(77, 23);
            DiagonaalTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 294);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 3;
            label1.Text = "Aspect ratio breedte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 294);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "hoogte";
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(379, 256);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(75, 50);
            BerekenButton.TabIndex = 5;
            BerekenButton.Text = "bereken";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += button1_Click;
            // 
            // BreedteInchLabel
            // 
            BreedteInchLabel.AutoSize = true;
            BreedteInchLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreedteInchLabel.Location = new Point(145, 237);
            BreedteInchLabel.Name = "BreedteInchLabel";
            BreedteInchLabel.Size = new Size(21, 25);
            BreedteInchLabel.TabIndex = 6;
            BreedteInchLabel.Text = "?";
            // 
            // BreedteCmLabel
            // 
            BreedteCmLabel.AutoSize = true;
            BreedteCmLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            BreedteCmLabel.Location = new Point(145, 259);
            BreedteCmLabel.Name = "BreedteCmLabel";
            BreedteCmLabel.Size = new Size(23, 30);
            BreedteCmLabel.TabIndex = 7;
            BreedteCmLabel.Text = "?";
            // 
            // DiagonaalCmLabel
            // 
            DiagonaalCmLabel.AutoSize = true;
            DiagonaalCmLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            DiagonaalCmLabel.Location = new Point(145, 112);
            DiagonaalCmLabel.Name = "DiagonaalCmLabel";
            DiagonaalCmLabel.Size = new Size(23, 30);
            DiagonaalCmLabel.TabIndex = 8;
            DiagonaalCmLabel.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 88);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 9;
            label6.Text = "Diagonaal (in inch)";
            // 
            // HoogteInchLabel
            // 
            HoogteInchLabel.AutoSize = true;
            HoogteInchLabel.Font = new Font("Microsoft Sans Serif", 14F);
            HoogteInchLabel.Location = new Point(365, 89);
            HoogteInchLabel.Name = "HoogteInchLabel";
            HoogteInchLabel.Size = new Size(20, 24);
            HoogteInchLabel.TabIndex = 10;
            HoogteInchLabel.Text = "?";
            // 
            // HoogteCmLabel
            // 
            HoogteCmLabel.AutoSize = true;
            HoogteCmLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            HoogteCmLabel.Location = new Point(365, 112);
            HoogteCmLabel.Name = "HoogteCmLabel";
            HoogteCmLabel.Size = new Size(23, 30);
            HoogteCmLabel.TabIndex = 11;
            HoogteCmLabel.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tv_achtergrond;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(466, 318);
            Controls.Add(HoogteCmLabel);
            Controls.Add(HoogteInchLabel);
            Controls.Add(label6);
            Controls.Add(DiagonaalCmLabel);
            Controls.Add(BreedteCmLabel);
            Controls.Add(BreedteInchLabel);
            Controls.Add(BerekenButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DiagonaalTextBox);
            Controls.Add(BreedteTextBox);
            Controls.Add(HoogteTextBox);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox HoogteTextBox;
        private TextBox BreedteTextBox;
        private TextBox DiagonaalTextBox;
        private Label label1;
        private Label label2;
        private Button BerekenButton;
        private Label BreedteInchLabel;
        private Label BreedteCmLabel;
        private Label DiagonaalCmLabel;
        private Label label6;
        private Label HoogteInchLabel;
        private Label HoogteCmLabel;
    }
}
