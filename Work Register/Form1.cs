using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Register
{
    public partial class MC : Form
    {
       

        string[] Nome = new string[30];
        string[] Categoria = new string[30];
        string[] Numero = new string[30];

        string Modo = "";

        bool Erro = false;

        public MC()
        {
            InitializeComponent();
        }

        private void MC_Load(object sender, EventArgs e)
        {
            label1.Text = "Bem-Vindo";
            Desabilitando_Campo();
            System.IO.StreamReader Vcontactos = new System.IO.StreamReader("c:/Users/JUCIANO SILVA/Documents/Work Register/Registos.txt");
            int i = 0;

            while (!Vcontactos.EndOfStream)
            {
                string contact = Vcontactos.ReadLine();
                i++;

                Categoria[i] = contact.Substring(0, 20);
                Nome[i] = contact.Substring(20, 20);
                Numero[i] = contact.Substring(40, 9);

                Dados_dgv.Rows.Add(Categoria[i], Nome[i], Numero[i]);

               


            }
            Notificação.ShowBalloonTip(6);

            Desabilitando_botoes();

            Vcontactos.Close();
             
        }













        //Metodos

        private void Habilitando_botoes()
        {
            Novo_btn.Visible = false;
            Editar_btn.Visible = false;
            Eliminar_btn.Visible = false;

            Salvar_btn.Visible = true;
            Cancelar_btn.Visible = true;
        }

        private void Desabilitando_botoes()
        {
            Novo_btn.Visible = true;
            Editar_btn.Visible = true;
            Eliminar_btn.Visible = true;

            Salvar_btn.Visible = false;
            Cancelar_btn.Visible = false;
        }

        private void Limpando_Campos()
        {
            Nome_txt.Text = "";
            Numero_txt.Text = "";
            Categoria_cbx.Text = "";

        }

        private void Habilitando_Campos()
        {
            Categoria_cbx.Enabled = true;
            Nome_txt.Enabled = true;
            Numero_txt.Enabled = true;
        }

        private void Desabilitando_Campo()
        {
            Categoria_cbx.Enabled = false;
            Nome_txt.Enabled = false;
            Numero_txt.Enabled = false;
        }

        private void Criticando_Campos()
        {
            //Verificar as categorias



            //Verificar as categorias


            //verifiar o nome

            if( Nome_txt.Text == "")
            {
                Erro = true;
                MessageBox.Show("Insira um nome", "Nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifiar o nome



            //verficar o número

            if ( Numero_txt.TextLength != 9)
            {
                Erro = true;
                MessageBox.Show("Insira apenas 9 digitos para o Nº contacto", "Nº de Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            return;
           //verificar o número
        }

        private void Atualindo_dados()
        {
            Dados_dgv.Rows.Clear();

            for (int d=1; d <= Nome.Length -1; d++)
            {
                if( Nome[d] != null)
                {
                    Dados_dgv.Rows.Add(Categoria[d], Nome[d], Numero[d]);
                }
            }
        }

        private void Carregando_Campos()
        {
            int LinhaAtual = Dados_dgv.CurrentRow.Index + 1;

            Categoria_cbx.Text = Categoria[LinhaAtual];
            Nome_txt.Text = Nome[LinhaAtual];
            Numero_txt.Text = Numero[LinhaAtual];


        }

        private void Gravando_Em_Arquivo()
        {
            System.IO.StreamWriter Gravação = new System.IO.StreamWriter("C:/Users/JUCIANO SILVA/Documents/Work Register/Registos.txt");


            for( int c = 1; c<=Nome.Length -1; c++ )
            {
                if( Nome[c] != null)
                {
                    string LinhaContacto = "";

                    LinhaContacto += String.Format("                    {0}", Categoria[c]).Substring( 20, Categoria[c].Length);
                    LinhaContacto += String.Format("                    {0}", Nome[c]).Substring(20, Nome[c].Length);
                    LinhaContacto += String.Format("         {0}", Numero[c]).Substring( 9, Numero[c].Length);

                    Gravação.WriteLine(LinhaContacto);
                }

            }
            Gravação.Close();
        }
        
        //Metodos








        private void Novo_btn_Click(object sender, EventArgs e)
        {
            Habilitando_botoes();
            Habilitando_Campos();

            Modo = "I";
            label1.Text = "Modo Atribuição Activado";

            Limpando_Campos();
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            Habilitando_botoes();
            Habilitando_Campos();
            Modo = "A";
            label1.Text = "Modo de Edição Activado";
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            Habilitando_botoes();
            Modo = "E";
            label1.Text = "Modo de Exclusão";

            MessageBox.Show(String.Format("Para confirmar a Exclusão do contacto de '{0}' pressione salvar", Nome_txt.Text.Trim()), "Exclusão de Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Salvar_btn_Click(object sender, EventArgs e)
        {
            Erro = false;
            Criticando_Campos();
           
            

            if (Erro)
            {
                return; 
            }


            //Modo de Inclusão

            if (Modo == "I")
            {

                int LinhaDados = Dados_dgv.Rows.Count + 1;

                Categoria[LinhaDados] = String.Format("{0}                    ", Categoria_cbx.SelectedItem).Substring(0, 20);
                Nome[LinhaDados] = String.Format("{0}                    ", Nome_txt.Text).Substring(0, 20);
                Numero[LinhaDados] = String.Format("{0}         ", Numero_txt.Text).Substring(0, 9);

                Modo = "";
                label1.Text = "Contacto Adicionado com Sucesso";
                Atualindo_dados();

            }

            //Modo de Inclusão


            //-------------------------------------------------------------------------


            //Modo de Alteração

            if (Modo == "A")
            {

                int LinhaDados = Dados_dgv.CurrentRow.Index + 1;

                Categoria[LinhaDados] = String.Format("{0}                    ", Categoria_cbx.SelectedItem).Substring(0, 20);
                Nome[LinhaDados] = String.Format("{0}                    ", Nome_txt.Text).Substring(0, 20);
                Numero[LinhaDados] = String.Format("{0}         ", Numero_txt.Text).Substring(0, 9);

                Modo = "";
                label1.Text = "Contacto Alterado com Sucesso";



                Atualindo_dados();

            }

            //Modo de Alteração

            //-------------------------------------------------------------------------

            //Modo de exclusão

            if( Modo == "E")
            {
                int LinhaAtual = Dados_dgv.CurrentRow.Index + 1;
                for(int d= 1; d <= Categoria.Length - 2; d++)
                {

                    if(LinhaAtual <= d) { 
                    Categoria[d] = Categoria[d + 1];
                    Nome[d] = Nome[d + 1];
                    Numero[d] = Numero[d + 1];
                    }
                }
                label1.Text = "Contacto Excluido Com Sucesso";
            }
            Atualindo_dados();

            Modo = "";
          

            //Modo de exclusão

            Desabilitando_botoes();
            Desabilitando_Campo();

            Gravando_Em_Arquivo();
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            Desabilitando_botoes();
            Desabilitando_Campo();

            Modo = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dados_dgv_SelectionChanged(object sender, EventArgs e)
        {
            Carregando_Campos();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Notificação.Visible = true;
        }

        private void Notificação_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Notificação.Visible = false;
        }
    }
}
