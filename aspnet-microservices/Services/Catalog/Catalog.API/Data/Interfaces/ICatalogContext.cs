﻿using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data.Interfaces
{
    interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
