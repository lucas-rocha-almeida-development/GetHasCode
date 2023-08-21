using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHasCode.Entitites
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //customizar para verificar se existe email e nomes iguais (id,nome,cpf)

        public override bool Equals(object NovoCliente)
        {//iremos comparar O cliente com outro cliente que sera puxado pelo objeto (parametro)
            if(!(NovoCliente is Client))
            {//caso o novo cliente não seja do tipo (classe Client) ira retornar falso
                return false;
            }
            Client other = NovoCliente as Client;
            //criterio de igualdade sera o email = na hora de instanciar
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {

              return Email.GetHashCode();  

        }


    }



}
