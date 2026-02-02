using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensao
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string servicoEscolhido;
        private string funcioEscolhido;
        private DateTime horarioMarcado;
        private DateTime dataMarcada;
        private List<Compra> compras;


        public Cliente()
        {
            this.nome = "";
            this.cpf = "00000000000";
            this.telefone = "000000000";
            this.servicoEscolhido = "";
            this.funcioEscolhido = "";
            this.horarioMarcado = DateTime.Now;
            this.dataMarcada = DateTime.Now;
            this.compras = new List<Compra>();
        }
        public List<Compra> GetCompras() { return this.compras; }
        public void AdicionarCompra(Compra compra) { this.compras.Add(compra); }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            if (cpf.Length != 11)
            {
                throw new ArgumentException("CPF deve conter exatamente 11 dígitos.");
            }
            if (!cpf.All(char.IsDigit))
            {
                throw new ArgumentException("CPF deve conter apenas números.");
            }
                this.cpf = cpf;
        }

        public string getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string telefone)
        {
            if(telefone.Length != 11)
            {
                throw new ArgumentException("Telefone deve contar exatamente 11 dígitos (DDD + número).");
            }
            if (!telefone.All(char.IsDigit))
            {
                throw new ArgumentException("Telefone deve conter apenas números.");
            }

            this.telefone = telefone;
        }
        public string getServicoEscolhido()
        {
            return this.servicoEscolhido;
        }
        public void setServicoEscolhido(string servicoEscolhido)
        {
            this.servicoEscolhido = servicoEscolhido;
        }

        public string getFuncioEscolhido()
        {
            return this.funcioEscolhido;
        }
        public void setFuncioEscolhido(string funcioEscolhido)
        {
            this.funcioEscolhido = funcioEscolhido;
        }

        public DateTime getHorarioMarcado()
        {
            return this.horarioMarcado;
        }
        public void setHorarioMarcado(DateTime horario)
        {
            
            this.horarioMarcado = horario;
        }

        public DateTime getDataMarcada()
        {
            return this.dataMarcada;
        }
        public void setDataMarcada(DateTime dataMarcada)
        {
            this.dataMarcada = dataMarcada;

        }
        public List<Compra> getCompras()
        {
            return this.compras;
        }

        public void adicionarCompra(Compra compra)
        {
            if (compra != null)
            {
                this.compras.Add(compra);
            }
        }

        public void limparCompras()
        {
            this.compras.Clear();
        }
    }
}
