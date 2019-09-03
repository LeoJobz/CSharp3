using ByteBankPlus.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankPlus.Sistemas
{
    //interface utilizada para contornar o problema com heranças multiplas
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
        
    }
}
