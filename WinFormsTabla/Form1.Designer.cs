namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            labelName = new Label();
            richTextBoxResultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.DarkCyan;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(labelName);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonver);
            panelPrincipal.Controls.Add(textBoxnum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(1, 1);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1123, 631);
            panelPrincipal.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelName.Location = new Point(413, 88);
            labelName.Name = "labelName";
            labelName.Size = new Size(351, 40);
            labelName.TabIndex = 5;
            labelName.Text = "Daniel Limon Cervantes";
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Cursor = Cursors.No;
            richTextBoxResultados.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(438, 295);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(307, 307);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = SystemColors.ButtonShadow;
            buttonver.Cursor = Cursors.Hand;
            buttonver.FlatStyle = FlatStyle.System;
            buttonver.Location = new Point(535, 252);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(104, 35);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver Tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.BackColor = Color.LightCyan;
            textBoxnum.BorderStyle = BorderStyle.FixedSingle;
            textBoxnum.Cursor = Cursors.IBeam;
            textBoxnum.Location = new Point(478, 208);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(201, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Times New Roman", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(413, 162);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(332, 43);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(392, 25);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(414, 53);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 631);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitulo;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label labelNumero;
        private RichTextBox richTextBoxResultados;
        private Label labelName;
    }
}
