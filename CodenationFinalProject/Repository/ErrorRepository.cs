using System;
using System.Collections.Generic;
using System.Linq;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    // a classe que implementa a interface que será usada na injecao de depencia precisa herdar da classe mae e também a própria interface
    public class ProcessesRepository : BaseRepository<Processes>, IProcesses
    {
        // é importante que no método construtor o context seja passado pra classe mãe por meio de base
        public ProcessesRepository(Context context) : base(context)
        {

        }

    }
}
