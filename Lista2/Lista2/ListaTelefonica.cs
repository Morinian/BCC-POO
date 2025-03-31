using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class ListaTelefonica
    {
        public List<Contato> telefonica;

        public ListaTelefonica()
        {
            telefonica = new List<Contato>(); 
        }

        public void AdicionarContato (Contato contato)
        {
            telefonica.Add(contato);
        }
        public void ExcluirContato(Contato contato)
        {
            for(int i = 0; i < telefonica.Count; i++)
            {
                if (telefonica[i] == contato)
                {
                    telefonica.Remove(contato);
                }
                else
                {
                    Console.WriteLine("-----------------\nContato {0} não existe nessa lista telefonica");
                }
            }
        }

        public void BuscarContato(Contato contato)
        {
            for (int i = 0; i < telefonica.Count; i++)
            {
                if (telefonica[i] == contato)
                {
                    Console.WriteLine("-----------------\nContato encontrado\nTelefone: {2}", telefonica[i].Nome, telefonica[i].Email, telefonica[i].Telefone);
                }
                else
                {
                    Console.WriteLine("-----------------\nContato {0} não existe nessa lista telefonica");
                }
            }
        }

        public void EditarContato(Contato contato, string nome, string email, string telefone)
        {
            for (int i = 0; i < telefonica.Count; i++)
            {
                if (telefonica[i] == contato)
                {
                    contato.EditarContato(nome, email, telefone);
                }
                else
                {
                    Console.WriteLine("-----------------\nContato {0} não existe nessa lista telefonica");
                }
            }
        }

        public void Listar()
        {
            for (int i = 0; i < telefonica.Count; i++)
            {
                Console.WriteLine("-----------------\nNome: {0}\nEmail: {1}\nTelefone: {2}", telefonica[i].Nome, telefonica[i].Email, telefonica[i].Telefone);
            }
        }
    }
}
