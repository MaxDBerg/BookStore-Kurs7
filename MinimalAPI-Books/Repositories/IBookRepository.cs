﻿using FluentValidation;
using MinimalAPI_Books.Models;

namespace MinimalAPI_Books.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
        Task AddAsync(Book book, int genreId);
        Task UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }

}