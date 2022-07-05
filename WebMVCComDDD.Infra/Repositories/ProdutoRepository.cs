using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVCComDDD.Data;
using WebMVCComDDD.Domain.Entities;
using WebMVCComDDD.Infra.Interfaces;

namespace WebMVCComDDD.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProdutoRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _applicationDbContext.Produtos.ToList();
        }

        public void Insert(Produto produto)
        {
            _applicationDbContext.Produtos.Add(produto);
            _applicationDbContext.SaveChangesAsync();
        }
    }
}
