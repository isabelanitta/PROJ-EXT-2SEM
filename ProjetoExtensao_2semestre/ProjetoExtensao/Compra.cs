using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensao
{
    public class Compra
    {
        private string categoria;
        private string produto;
        private string tamanho;
        private int quantd;

        public Compra()
        {
            this.categoria = "";
            this.produto = "";
            this.tamanho = "";
            this.quantd = 0;
        }

        public Compra(string categoria, string produto, string tamanho, int quantd)
        {
            this.categoria = categoria;
            this.produto = produto;
            this.tamanho = tamanho;
            this.quantd = quantd;
        }

        public string getCategoria()
        {
            return this.categoria;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public string getProduto()
        {
            return this.produto;
        }
        public void setProduto(string produto)
        {
            this.produto = produto;
        }

        public string getTamanho()
        {
            return this.tamanho;
        }
        public void setTamanho(string tamanho)
        {
            if (string.IsNullOrWhiteSpace(tamanho))
                throw new ArgumentException("Tamanho não pode ser vazio.");
            this.tamanho = tamanho;
        }
        
        public int getQuantd()
        {
            return this.quantd;
        }
        public void setQuantd(int quantd)
        {
            if (quantd < 0)
                throw new ArgumentException("Quantidade não pode ser negativa.");
            this.quantd = quantd;
        }
    }
}
