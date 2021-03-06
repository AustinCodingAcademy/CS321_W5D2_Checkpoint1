﻿using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W5D2_BlogAPI.Core.Models;
using CS321_W5D2_BlogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W5D2_BlogAPI.Infrastructure.Data
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _dbContext;

        public BlogRepository(AppDbContext dbContext) 
        {
            // TODO: inject AppDbContext
        }

        public IEnumerable<Blog> GetAll()
        {
            // TODO: Retrieve all blgs. Include Blog.User.
            throw new NotImplementedException();
        }

        public Blog Get(int id)
        {
            // TODO: Retrieve the blog by id. Include Blog.User.
            throw new NotImplementedException();
        }

        public Blog Add(Blog blog)
        {
            // TODO: Add new blog
            throw new NotImplementedException();
        }

        public Blog Update(Blog updatedItem)
        {
            // TODO: update blog
            throw new NotImplementedException();
            //var existingItem = _dbContext.Find(updatedItem.Id);
            //if (existingItem == null) return null;
            //_dbContext.Entry(existingItem)
            //   .CurrentValues
            //   .SetValues(updatedItem);
            //_dbContext.Blogs.Update(existingItem);
            //_dbContext.SaveChanges();
            //return existingItem;
        }

        public void Remove(int id)
        {
            // TODO: remove blog
            throw new NotImplementedException();
        }
    }
}
