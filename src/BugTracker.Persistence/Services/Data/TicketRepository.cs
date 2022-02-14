﻿using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<Ticket> AddTicketAsync(Ticket entity, ICollection<string> teamIds)
        {

            await _dbContext.Tickets.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            foreach (var id in teamIds)
            {
                await _dbContext.TicketsTeamMembers.AddAsync(new TicketsTeamMembers { TicketId = entity.Id, UserId = id });
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByProject(Guid id)
        {
            return await _dbContext.Tickets.Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                        .Where(t => t.ProjectId == id)
                        .OrderBy(t => t.CreatedDate)
                        .ToListAsync();
        }
        public async Task<bool> NameIsUnique(string name)
        {
            return await _dbContext.Tickets.AsNoTracking().AnyAsync(t => t.Name == name) == false;
        }
    }
}
