using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Interfaces
{
    public interface ICrypthography
    {
        string Encrypt(string plainText);
    }
}
