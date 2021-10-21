using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria
{
    class DVD : Produto
    {
        public string diretor { get; set; }
        public string duracao { get; set; }
        public string censura { get; set; }

        public DVD()
        {

            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
            this.diretor = "";
            this.duracao = "";
            this.censura = "";
        }

        public void listarProduto()
        {
            MessageBox.Show("Dados do Livro:" +
                "\n\nDescrição: " + this.descricao +
                "\nGênero: " + this.genero +
                "\nArtista: " + this.diretor +
                "\nGravadora: " + this.duracao +
                "\nPaís Origem:" + this.censura +
                "\nPreço de Custo: " + this.precoCusto.ToString() +
                "\nEstoque Disponível: " + this.estoqueDisponivel.ToString());
        }
    }
}
