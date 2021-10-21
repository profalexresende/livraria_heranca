using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Livro livro = new Livro();
        CD cd = new CD();
        DVD dvd = new DVD();
        //Criar as instâncias para CD e DVD aqui

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            switch (cmbProduto.SelectedIndex)
            {
                case 0://Livro
                    livro.descricao = Interaction.InputBox("Digite o título do livro");
                    livro.genero = Interaction.InputBox("Digite o gênero do livro");
                    livro.autor = Interaction.InputBox("Digite o autor do livro");
                    livro.editora = Interaction.InputBox("Digite a editora do livro");
                    livro.edicao = Interaction.InputBox("Digite a edição do livro");
                    livro.precoCusto = Convert.ToDouble(Interaction.InputBox("Digite o preço do livro"));
                    MessageBox.Show("Livro cadastrado com sucesso!");
                    break;
                case 1:
                    cd.descricao = Interaction.InputBox("Digite o título");
                    cd.genero = Interaction.InputBox("Digite o gênero");
                    cd.artista = Interaction.InputBox("Digite o artista");
                    cd.gravadora = Interaction.InputBox("Digite a gravadora");
                    cd.paisOrigem = Interaction.InputBox("Digite o país de origem");
                    cd.precoCusto = Convert.ToDouble(Interaction.InputBox("Digite o preço"));
                    MessageBox.Show("CD cadastrado com sucesso!");
                    break;
                case 2:
                    dvd.descricao = Interaction.InputBox("Digite o título");
                    dvd.genero = Interaction.InputBox("Digite o gênero");
                    dvd.diretor = Interaction.InputBox("Digite o artista");
                    dvd.duracao = Interaction.InputBox("Digite a gravadora");
                    dvd.censura = Interaction.InputBox("Digite o país de origem");
                    dvd.precoCusto = Convert.ToDouble(Interaction.InputBox("Digite o preço"));
                    MessageBox.Show("DVD cadastrado com sucesso!");
                    break;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(Interaction.InputBox("Digite a qtde"));
            switch (cmbProduto.SelectedIndex)
            {
                case 0://Livro
                    livro.comprar(qtde);
                    break;
                case 1:
                    cd.comprar(qtde);
                    break;
                case 2:
                    dvd.comprar(qtde);
                    break;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(Interaction.InputBox("Digite a qtde"));
            switch (cmbProduto.SelectedIndex)
            {
                case 0:
                    livro.vender(qtde);
                    break;
                case 1:
                    cd.vender(qtde);
                    break;
                case 2:
                    dvd.vender(qtde);
                    break;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbProduto.SelectedIndex)
            {
                case 0:
                    livro.listarProduto();
                    break;
                case 1:
                    cd.listarProduto();
                    break;
                case 2:
                    dvd.listarProduto();
                    break;
            }
        }
    }
}
