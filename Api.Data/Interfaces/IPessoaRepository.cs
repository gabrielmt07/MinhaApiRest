using Api.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Interfaces
{
    public interface IPessoaRepository
    {
        List<Pessoa> Get();
        void Add(Pessoa pessoa);
    }
}
