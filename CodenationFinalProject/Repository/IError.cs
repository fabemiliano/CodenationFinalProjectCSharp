using System;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    // a interface será utilizada na injecao de dependencia, porém para evitar repetição de códifo é feito uma herança a partir de uma interface base, como essa interface pode implementar qualquer classe se usa um generics que nesse caso é passado o generics relacionado ao model Process
    public interface IProcesses : IBaseInterface<Processes>
    {
    }
}
