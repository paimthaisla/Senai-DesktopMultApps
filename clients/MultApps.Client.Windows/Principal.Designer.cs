namespace MultApps.Client.Windows
{
    partial class Principal
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
            this.btnAbrirMatriculaAluno = new System.Windows.Forms.Button();
            this.btnAbrirFormPesoIdeal = new System.Windows.Forms.Button();
            this.btnAbrirFormReajusteSalarial = new System.Windows.Forms.Button();
            this.btnAbrirFormMatriculaAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirMatriculaAluno
            // 
            this.btnAbrirMatriculaAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirMatriculaAluno.BackgroundImage = global::MultApps.Client.Windows.Properties.Resources._52393;
            this.btnAbrirMatriculaAluno.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirMatriculaAluno.Location = new System.Drawing.Point(145, 197);
            this.btnAbrirMatriculaAluno.Name = "btnAbrirMatriculaAluno";
            this.btnAbrirMatriculaAluno.Size = new System.Drawing.Size(111, 63);
            this.btnAbrirMatriculaAluno.TabIndex = 0;
            this.btnAbrirMatriculaAluno.Text = "Matrícula";
            this.btnAbrirMatriculaAluno.UseVisualStyleBackColor = false;
            // 
            // btnAbrirFormPesoIdeal
            // 
            this.btnAbrirFormPesoIdeal.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirFormPesoIdeal.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormPesoIdeal.Location = new System.Drawing.Point(318, 198);
            this.btnAbrirFormPesoIdeal.Name = "btnAbrirFormPesoIdeal";
            this.btnAbrirFormPesoIdeal.Size = new System.Drawing.Size(143, 61);
            this.btnAbrirFormPesoIdeal.TabIndex = 1;
            this.btnAbrirFormPesoIdeal.Text = "Qual seu Peso Ideal? ";
            this.btnAbrirFormPesoIdeal.UseVisualStyleBackColor = false;
            // 
            // btnAbrirFormReajusteSalarial
            // 
            this.btnAbrirFormReajusteSalarial.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirFormReajusteSalarial.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormReajusteSalarial.Location = new System.Drawing.Point(529, 198);
            this.btnAbrirFormReajusteSalarial.Name = "btnAbrirFormReajusteSalarial";
            this.btnAbrirFormReajusteSalarial.Size = new System.Drawing.Size(111, 63);
            this.btnAbrirFormReajusteSalarial.TabIndex = 2;
            this.btnAbrirFormReajusteSalarial.Text = "Reajuste Salarial";
            this.btnAbrirFormReajusteSalarial.UseVisualStyleBackColor = false;
            // 
            // btnAbrirFormMatriculaAluno
            // 
            this.btnAbrirFormMatriculaAluno.AutoSize = true;
            this.btnAbrirFormMatriculaAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirFormMatriculaAluno.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormMatriculaAluno.Location = new System.Drawing.Point(248, 57);
            this.btnAbrirFormMatriculaAluno.Name = "btnAbrirFormMatriculaAluno";
            this.btnAbrirFormMatriculaAluno.Size = new System.Drawing.Size(276, 25);
            this.btnAbrirFormMatriculaAluno.TabIndex = 3;
            this.btnAbrirFormMatriculaAluno.Text = "Selecione a opção desejada:";
            this.btnAbrirFormMatriculaAluno.Click += new System.EventHandler(this.label1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultApps.Client.Windows.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirFormMatriculaAluno);
            this.Controls.Add(this.btnAbrirFormReajusteSalarial);
            this.Controls.Add(this.btnAbrirFormPesoIdeal);
            this.Controls.Add(this.btnAbrirMatriculaAluno);
            this.Name = "Principal";
            this.Text = "Programs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrirMatriculaAluno;
        private Button btnAbrirFormPesoIdeal;
        private Button btnAbrirFormReajusteSalarial;
        private Label btnAbrirFormMatriculaAluno;
    }
}