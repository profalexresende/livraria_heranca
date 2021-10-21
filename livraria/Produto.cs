using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria
{
    class Produto
    {
        public string descricao { get; set; }
        public string genero { get; set; }
        public int estoqueDisponivel { get; set; }
        public double precoCusto { get; set; }

        public Produto()
        {
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
        }

        public void comprar(int qtde)
        {
            estoqueDisponivel += qtde;
            MessageBox.Show("Quatidade adicionada ao estoque");
        }

        public void vender(int qtde)
        {
            if (qtde <= this.estoqueDisponivel)
            {
                estoqueDisponivel -= qtde;
                MessageBox.Show("Quantidade retirada do estoque");
            }
            else
            {
                MessageBox.Show("Estoque indisponível");
            }
        }
    }
}
