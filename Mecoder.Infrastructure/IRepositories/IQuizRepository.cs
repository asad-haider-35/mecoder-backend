using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.IRepositories
{
    public interface IQuizRepository
    {
        Quiz Get(int id);
    }
}
