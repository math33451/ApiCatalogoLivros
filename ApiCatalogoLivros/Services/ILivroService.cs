﻿using ApiCatalogoLivros.InputModel;
using ApiCatalogoLivros.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogoLivros.Services
{
    public interface ILivroService : IDisposable
    {
        Task<List<LivroViewModel>> Obter(int pagina, int quantidade);
        Task<LivroViewModel> Obter(Guid id);
        Task<LivroViewModel> Inserir(LivroInputModel jogo);
        Task Atualizar(Guid id, LivroInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}