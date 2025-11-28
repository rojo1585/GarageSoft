using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace GarageSoft.Infrastructure.Repository;

public class GenericRepository<T>(GarageSoftContext context) : IGenericRepository<T> where T : class
{
    protected readonly GarageSoftContext _context = context;
    public async Task<IReadOnlyList<T>> GetAllAsync() =>
       await _context.Set<T>()
                            .AsNoTracking()
                            .ToListAsync();

    public async Task<T?> GetByIdAsync(Guid id) =>
        await _context.Set<T>().FindAsync(id);

    public async Task<T> AddAsync(T entity) 
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
