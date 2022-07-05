using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVCComDDD.Application.ViewsModels;

namespace WebMVCComDDD.Application.Interfaces
{
    public interface IProdutoApplication
    {
        IEnumerable<ProdutoViewModel> GetAll();
        void Insert(ProdutoViewModel produtoViewModel);
    }
}
