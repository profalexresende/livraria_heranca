using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria
{
    class Livro : Produto
    {
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }

        public Livro()
        {
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
            this.autor = "";
            this.editora = "";
            this.edicao = "";
        }

        public void listarProduto()
        {
            MessageBox.Show("Dados do Livro:" +
                "\n\nDescrição: " + this.descricao +
                "\nGênero: " + this.genero +
                "\nAutor: " + this.autor +
                "\nEditora: " + this.editora +
                "\nEdição:" + this.edicao +
                "\nPreço de Custo: " + this.precoCusto.ToString() +
                "\nEstoque Disponível: " + this.estoqueDisponivel.ToString());
        }
    }
}
