using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projato.Dados;

namespace Projato.Repositorio.Categoria
{
    public class CategoriaRepositorio : IDisposable
    {
        public bool Salvar(string descricao, byte[] imagem)
        {
            try
            {
                using (var contexto = new Model1())
                {
                    //var entidade = new Dados.Categoria();

                    //entidade.DescricaoCategoria = descricao;
                    //entidade.ImagemCategoria = imagem;
                    //contexto.Categoria.Add(entidade);


                    contexto.Categoria.Add(new Dados.Categoria()
                    {
                        DescricaoCategoria = descricao,
                        ImagemCategoria = imagem
                    });
                    return contexto.SaveChanges() > 0;

                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public void Excluir()
        {

        }


        public List<Dados.Categoria> Pesquisar(string descricao)
        {
            using (var contexto = new Model1())
            {
                List<Dados.Categoria> itemBuscado;
                if (string.IsNullOrEmpty(descricao))
                {
                    return contexto.Categoria.ToList();
                }

                itemBuscado = contexto.Categoria.Where(x => x.DescricaoCategoria.ToUpper().Equals(descricao.ToUpper())).ToList();
                if (itemBuscado == null) return null;

                return itemBuscado;
            }
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
