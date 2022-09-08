namespace Prova
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
            this.button1_cadastro = new System.Windows.Forms.Button();
            this.button2_listarporcurso = new System.Windows.Forms.Button();
            this.button3_listar = new System.Windows.Forms.Button();
            this.button4_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_pronome = new System.Windows.Forms.TextBox();
            this.textBox2_procurso = new System.Windows.Forms.TextBox();
            this.textBox3_listagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_cadastro
            // 
            this.button1_cadastro.Location = new System.Drawing.Point(64, 218);
            this.button1_cadastro.Name = "button1_cadastro";
            this.button1_cadastro.Size = new System.Drawing.Size(103, 23);
            this.button1_cadastro.TabIndex = 0;
            this.button1_cadastro.Text = "Cadastro";
            this.button1_cadastro.UseVisualStyleBackColor = true;
            this.button1_cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_listarporcurso
            // 
            this.button2_listarporcurso.Location = new System.Drawing.Point(64, 247);
            this.button2_listarporcurso.Name = "button2_listarporcurso";
            this.button2_listarporcurso.Size = new System.Drawing.Size(103, 23);
            this.button2_listarporcurso.TabIndex = 1;
            this.button2_listarporcurso.Text = "Listar por Curso";
            this.button2_listarporcurso.UseVisualStyleBackColor = true;
            this.button2_listarporcurso.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_listar
            // 
            this.button3_listar.Location = new System.Drawing.Point(64, 276);
            this.button3_listar.Name = "button3_listar";
            this.button3_listar.Size = new System.Drawing.Size(103, 23);
            this.button3_listar.TabIndex = 2;
            this.button3_listar.Text = "Listar";
            this.button3_listar.UseVisualStyleBackColor = true;
            this.button3_listar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_limpar
            // 
            this.button4_limpar.Location = new System.Drawing.Point(64, 305);
            this.button4_limpar.Name = "button4_limpar";
            this.button4_limpar.Size = new System.Drawing.Size(103, 23);
            this.button4_limpar.TabIndex = 3;
            this.button4_limpar.Text = "Limpar";
            this.button4_limpar.UseVisualStyleBackColor = true;
            this.button4_limpar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curso";
            // 
            // textBox1_pronome
            // 
            this.textBox1_pronome.Location = new System.Drawing.Point(128, 114);
            this.textBox1_pronome.Name = "textBox1_pronome";
            this.textBox1_pronome.Size = new System.Drawing.Size(138, 23);
            this.textBox1_pronome.TabIndex = 6;
            // 
            // textBox2_procurso
            // 
            this.textBox2_procurso.Location = new System.Drawing.Point(128, 148);
            this.textBox2_procurso.Name = "textBox2_procurso";
            this.textBox2_procurso.Size = new System.Drawing.Size(138, 23);
            this.textBox2_procurso.TabIndex = 7;
            // 
            // textBox3_listagem
            // 
            this.textBox3_listagem.Location = new System.Drawing.Point(306, 114);
            this.textBox3_listagem.Multiline = true;
            this.textBox3_listagem.Name = "textBox3_listagem";
            this.textBox3_listagem.Size = new System.Drawing.Size(264, 307);
            this.textBox3_listagem.TabIndex = 8;
            this.textBox3_listagem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3_listagem);
            this.Controls.Add(this.textBox2_procurso);
            this.Controls.Add(this.textBox1_pronome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4_limpar);
            this.Controls.Add(this.button3_listar);
            this.Controls.Add(this.button2_listarporcurso);
            this.Controls.Add(this.button1_cadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_cadastro;
        private Button button2_listarporcurso;
        private Button button3_listar;
        private Button button4_limpar;
        private Label label1;
        private Label label2;
        private TextBox textBox1_pronome;
        private TextBox textBox2_procurso;
        private TextBox textBox3_listagem;
    }
}