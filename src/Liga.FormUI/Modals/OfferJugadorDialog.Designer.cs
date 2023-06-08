namespace Liga.FormUI.Modals
{
    partial class OfferJugadorDialog
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
            customButton1 = new CustomControls.CustomButton();
            label1 = new System.Windows.Forms.Label();
            textBoxOferta = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = System.Drawing.Color.FromArgb(149, 217, 144);
            customButton1.BackgroundColor = System.Drawing.Color.FromArgb(149, 217, 144);
            customButton1.BorderColor = System.Drawing.Color.Green;
            customButton1.BorderRadius = 12;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customButton1.ForeColor = System.Drawing.Color.Black;
            customButton1.Location = new System.Drawing.Point(272, 159);
            customButton1.Name = "customButton1";
            customButton1.Size = new System.Drawing.Size(150, 40);
            customButton1.TabIndex = 0;
            customButton1.Text = "Enviar";
            customButton1.TextColor = System.Drawing.Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "OFERTA";
            // 
            // textBoxOferta
            // 
            textBoxOferta.Location = new System.Drawing.Point(69, 77);
            textBoxOferta.Name = "textBoxOferta";
            textBoxOferta.Size = new System.Drawing.Size(295, 23);
            textBoxOferta.TabIndex = 2;
            textBoxOferta.KeyPress += textBoxOferta_KeyPress;
            // 
            // OfferJugadorDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(206, 235, 252);
            ClientSize = new System.Drawing.Size(434, 211);
            Controls.Add(textBoxOferta);
            Controls.Add(label1);
            Controls.Add(customButton1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "OfferJugadorDialog";
            Text = "Haz una oferta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomButton customButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOferta;
    }
}