using System;
using System.Collections.Generic;
using System.Linq;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    public class ErrorRepository : BaseRepository<Error>, IError
    {
        public ErrorRepository(Context context) : base(context)
        {

        }

    }
}
