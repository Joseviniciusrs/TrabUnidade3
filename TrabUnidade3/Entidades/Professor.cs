using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Entidades
{
    using System;

    [Serializable]
    public class Professor
    {
        private int Id;
        private string NomeP;
        private string Cnpj;
        private string DDD;
        private string Numero;
        private string Email;

        public Professor()
        {

        }

        public Professor(int id_Prof, string nome, string cnpj, string dDD, string numero, string email)
        {
            Id = id_Prof;
            NomeP = nome;
            Cnpj = cnpj;
            DDD = dDD;
            Numero = numero;
            Email = email;
        }

        public int Id_Prof
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Nome_Prof
        {
            get { return NomeP; }
            set { NomeP = value; }
        }

        public string Cnpj_Prof
        {
            get { return Cnpj; }
            set { Cnpj = value; }
        }

        public string DDD_Prof
        {
            get { return DDD; }
            set { DDD = value; }
        }

        public string Numero_Prof
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public string Email_Prof
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
            Professor other = (Professor)obj;
            return Id == other.Id;
        }

        public override string ToString()
        {
            if (Cnpj != null)
            {
                return $"Contato [ Código = {Id} , Nome = {NomeP} , Cnpj = {Cnpj} , DDD = {DDD} , Numero = {Numero} , Email = {Email} ]";
            }
            else
            {
                return $"{NomeP} , Código = {Id}";
            }
        }
    }

}
