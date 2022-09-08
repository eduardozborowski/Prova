namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PARTE DO CADASTRU
            Aluno aluno = new Aluno(textBox1_pronome.Text, textBox2_procurso.Text);
            textBox3_listagem.Text += aluno.Nome + " - " + aluno.Curso + Environment.NewLine;
            Aluno.listaAlunos.Add(aluno);
            Aluno.OrdenarAlunos();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PARTE DA LISTAGEM
            Aluno.OrdenarAlunos();
            textBox3_listagem.Text = "";
            foreach (Aluno aluno in Aluno.listaAlunos)
            {
                textBox3_listagem.Text += aluno.Nome + " - " + aluno.Curso + Environment.NewLine;
            }



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LISTAGEM POR CURSO
            textBox3_listagem.Text = "";
            foreach (Aluno aluno in Aluno.listaAlunos)
            {
                if (aluno.Curso == textBox2_procurso.Text)
                {
                    textBox3_listagem.Text += aluno.Nome + " - " + aluno.Curso + Environment.NewLine;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DEIXAR TUDO BRANCO
            textBox1_pronome.Text = "";
            textBox2_procurso.Text = "";
            textBox3_listagem.Text = "";
            
            




        }
    }
}