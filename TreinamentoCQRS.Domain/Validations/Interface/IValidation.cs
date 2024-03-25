using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoCQRS.Domain.Validations.Interface
{
    public interface IValidation
    {
        bool IsValid();
    }
}
