using System;
using System.Collections.Generic;
using System.Linq;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    public class LogsRepository : BaseRepository<Logs>, ILogs
    {
        public LogsRepository(Context context) : base(context)
        {

        }

    }
}
