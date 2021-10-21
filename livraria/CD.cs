using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria
{
    class CD : Produto
    {
        public string artista { get; set; }
        public string gravadora { get; set; }
        public string paisOrigem { get; set; }

        public CD()
        {
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
            this.artista = "";
            this.gravadora = "";
            this.paisOrigem = "";
        }

        public void listarProduto()
        {
            MessageBox.Show("Dados do Livro:" +
                "\n\nDescrição: " + this.descricao +
                "\nGênero: " + this.genero +
                "\nArtista: " + this.artista +
                "\nGravadora: " + this.gravadora +
                "\nPaís Origem:" + this.paisOrigem +
                "\nPreço de Custo: " + this.precoCusto.ToString() +
                "\nEstoque Disponível: " + this.estoqueDisponivel.ToString());
        }
    }
}
