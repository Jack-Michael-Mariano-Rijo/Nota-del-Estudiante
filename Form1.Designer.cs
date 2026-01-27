namespace Tarea_42
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
            btnCarcular = new Button();
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblNota4 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtCompletivo = new TextBox();
            txtResultado = new TextBox();
            lblPromedio = new Label();
            SuspendLayout();
            // 
            // btnCarcular
            // 
            btnCarcular.Location = new Point(261, 235);
            btnCarcular.Name = "btnCarcular";
            btnCarcular.Size = new Size(94, 29);
            btnCarcular.TabIndex = 0;
            btnCarcular.Text = "Carcular";
            btnCarcular.UseVisualStyleBackColor = true;
            btnCarcular.Click += btnCarcular_Click;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(112, 65);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(50, 20);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "Nota1";
            lblNota1.Click += label1_Click;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(433, 65);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(50, 20);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "Nota2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(112, 154);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(50, 20);
            lblNota3.TabIndex = 3;
            lblNota3.Text = "Nota3";
            // 
            // lblNota4
            // 
            lblNota4.AutoSize = true;
            lblNota4.Location = new Point(433, 154);
            lblNota4.Name = "lblNota4";
            lblNota4.Size = new Size(50, 20);
            lblNota4.TabIndex = 4;
            lblNota4.Text = "Nota4";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(77, 88);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(394, 88);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(77, 195);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(125, 27);
            txtNota3.TabIndex = 7;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(394, 195);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(125, 27);
            txtNota4.TabIndex = 8;
            // 
            // txtCompletivo
            // 
            txtCompletivo.Location = new Point(77, 312);
            txtCompletivo.Name = "txtCompletivo";
            txtCompletivo.Size = new Size(125, 27);
            txtCompletivo.TabIndex = 9;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(394, 312);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 10;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(270, 202);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(74, 20);
            lblPromedio.TabIndex = 11;
            lblPromedio.Text = "Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 362);
            Controls.Add(lblPromedio);
            Controls.Add(txtResultado);
            Controls.Add(txtCompletivo);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblNota4);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(btnCarcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarcular;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblNota4;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtCompletivo;
        private TextBox txtResultado;
        private Label lblPromedio;
    }
}
