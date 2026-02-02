using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensao
{
    public class Estoque
    {
        private string nome;
        private string descricao;
        private double preco;
        private int quantd;

        public Estoque()
        {
            this.nome = "Desconhecido";
            this.descricao = "Desconhecido";
            this.preco = 0.0;
            this.quantd = 0;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getDescricao()
        {
            return this.descricao;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public double getPreco()
        {
            return this.preco;
        }
        public void setPreco(double preco)
        {
            if (preco < 0.0)
                throw new ArgumentException("Preço não pode ser negativo.");
            this.preco = preco;
        }
        public int getQuantd()
        {
            return this.quantd;
        }
        public void setQuantd(int estoque)
        {
            if (estoque < 0)
                throw new ArgumentException("Quantidade em estoque não pode ser negativa.");
            this.quantd = estoque;
        }
    }
}
