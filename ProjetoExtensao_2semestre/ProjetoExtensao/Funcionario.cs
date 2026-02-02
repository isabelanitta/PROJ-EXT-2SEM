using System;
using System.Linq;

namespace ProjetoExtensao
{
    public class Funcionario
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string email;
        private string cargo;

        public Funcionario()
        {
            this.nome = "";
            this.cpf = "00000000000";
            this.telefone = "000000000";
            this.email = "";
            this.cargo = "";
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getCargo()
        {
            return this.cargo;
        }
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
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
            if (telefone.Length != 11)
            {
                throw new ArgumentException("Telefone deve contar exatamente 11 dígitos (DDD + número).");
            }
            if (!telefone.All(char.IsDigit))
            {
                throw new ArgumentException("Telefone deve conter apenas números.");
            }
            this.telefone = telefone;
        }

    }
}
