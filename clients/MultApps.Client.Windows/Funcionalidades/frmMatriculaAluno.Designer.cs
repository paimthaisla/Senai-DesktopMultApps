namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.UltimoAnoNiver = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 23);
            this.textBox2.TabIndex = 3;
            // 
            // dataNascimento
            // 
            this.dataNascimento.AutoSize = true;
            this.dataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.dataNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataNascimento.Location = new System.Drawing.Point(19, 89);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(113, 19);
            this.dataNascimento.TabIndex = 2;
            this.dataNascimento.Text = "Ano Nascimento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(19, 18);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(49, 19);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // UltimoAnoNiver
            // 
            this.UltimoAnoNiver.AutoSize = true;
            this.UltimoAnoNiver.BackColor = System.Drawing.Color.Transparent;
            this.UltimoAnoNiver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UltimoAnoNiver.Location = new System.Drawing.Point(239, 89);
            this.UltimoAnoNiver.Name = "UltimoAnoNiver";
            this.UltimoAnoNiver.Size = new System.Drawing.Size(154, 19);
            this.UltimoAnoNiver.TabIndex = 4;
            this.UltimoAnoNiver.Text = "Ano Último Aniversário:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 23);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(17, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Idetinficar Categoria";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(202, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(397, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 23);
            this.textBox4.TabIndex = 8;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultApps.Client.Windows.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(521, 190);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.UltimoAnoNiver);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nome);
            this.Enabled = false;
            this.Name = "frmMatriculaAluno";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "frmMatriculaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox2;
        private Label dataNascimento;
        private TextBox textBox1;
        private Label Nome;
        private Label UltimoAnoNiver;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
    }
}