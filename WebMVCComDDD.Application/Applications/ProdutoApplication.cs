using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVCComDDD.Application.Interfaces;
using WebMVCComDDD.Application.ViewsModels;
using WebMVCComDDD.Domain.Entities;
using WebMVCComDDD.Infra.Interfaces;

namespace WebMVCComDDD.Application.Applications
{
    public class ProdutoApplication : IProdutoApplication
    {
        IProdutoRepository _produtoRepository;

        public ProdutoApplication(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var produtos = _produtoRepository.GetAll();
            var produtosViewModel = produtos.Select(produto => new ProdutoViewModel
            {
                Nome = produto.Nome,
                Marca = produto.Marca,
                Id = produto.Id
            });
            return produtosViewModel;
        }

        public void Insert(ProdutoViewModel produtoViewModel)
        {
                var produto = new Produto
                {
                    Nome = produtoViewModel.Nome,
                    Marca = produtoViewModel.Marca,
                };

            _produtoRepository.Insert(produto);
                     
        }
    }
}
