using Api.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Interfaces
{
    public interface IPessoaRepository
    {
        List<Pessoa> Get();
        Pessoa GetById(int id);
        void Add(Pessoa pessoa);
        void Delete(Pessoa pessoa);
    }
}
