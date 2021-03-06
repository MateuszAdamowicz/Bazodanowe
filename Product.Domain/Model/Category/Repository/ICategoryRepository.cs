﻿using System.Collections;
using System.Collections.Generic;

namespace Products.Domain.Model.Category.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        int Add(Category category);
        int Delete(int categoryId);
        Category Find(int categoryId);
    }
}