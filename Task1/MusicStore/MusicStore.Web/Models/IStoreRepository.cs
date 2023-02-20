﻿namespace MusicStore.Web.Models;

public interface IStoreRepository
{
    IQueryable<Product> Products { get; }
}
