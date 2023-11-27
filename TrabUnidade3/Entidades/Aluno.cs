using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Entidades
{
    using System;

    [Serializable]
    public class Aluno
    {
        private int Id;
        private string NomeA;
        private string CPF;
        private string DDD;
        private string Numero;
        private string Email;

        public Aluno()
        {

        }

        public Aluno(int id_Aluno, string nome, string cPF, string dDD, string numero, string email)
        {
            Id = id_Aluno;
            NomeA = nome;
            CPF = cPF;
            DDD = dDD;
            Numero = numero;
            Email = email;
        }

        public int Id_Aluno
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Nome
        {
            get { return NomeA; }
            set { NomeA = value; }
        }

        public string CPF_Aluno
        {
            get { return CPF; }
            set { CPF = value; }
        }

        public string DDD_Aluno
        {
            get { return DDD; }
            set { DDD = value; }
        }

        public string Numero_Aluno
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public string Email_Aluno
        {
            get { return Email; }
            set { Email = value; }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || GetType() != obj.GetType())
                return false;
            Aluno other = (Aluno)obj;
            return Id == other.Id;
        }

        public override string ToString()
        {
            if (CPF != null)
            {
                return $"Contato [ Código = {Id} , Nome = {NomeA} , CPF = {CPF} , DDD = {DDD} , Numero = {Numero} , Email = {Email} ]";
            }
            else
            {
                return $"{NomeA} , Código = {Id}";
            }
        }
    }

}
