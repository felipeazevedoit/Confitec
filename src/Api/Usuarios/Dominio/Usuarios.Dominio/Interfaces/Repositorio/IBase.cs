﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Dominio.Interfaces.Repositorio
{
    public interface IBase<T> where T: class
    {
        T Adicionar(T obj);
        T Alterar(T obj);
        IEnumerable<T> Listar();
        bool Excluir(int id);
    }
}