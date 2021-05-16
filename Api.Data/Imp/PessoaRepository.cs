using Api.Data.Interfaces;
using Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Data.Imp
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly MainContext _db;

        public PessoaRepository(MainContext db)
        {
            _db = db;
        }

        public void Add(Pessoa pessoa)
        {
            _db.Add(pessoa);
            _db.SaveChanges();
        }

        public List<Pessoa> Get()
        {
            return _db.Pessoas.ToList();
        }
    }
}
