﻿using AutoMapper;
using BabyCareProject.Dtos.SubscriberDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;

public class SubscriberManager : ISubscriberService
{
    private readonly IMongoCollection<Subscriber> _subscriberCollection;
    private readonly IMapper _mapper;

    public SubscriberManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
    {
        _mapper = mapper;
        var client = new MongoClient(dataBaseSettings.ConnectionStrings);
        var database = client.GetDatabase(dataBaseSettings.DataBaseName);
        _subscriberCollection = database.GetCollection<Subscriber>(dataBaseSettings.SubscriberCollection);
    }
    public async Task CreateAsync(CreateSubscriberDto subscriberDto)
    {
        var subscriber = _mapper.Map<Subscriber>(subscriberDto);
        await _subscriberCollection.InsertOneAsync(subscriber);
    }

    public async Task DeleteAsync(string id)
    {
        await _subscriberCollection.DeleteOneAsync(s => s.Id == id);
    }

    public async Task<List<ResultSubscriberDto>> GetAllAsync()
    {
        var subscribers = await _subscriberCollection.AsQueryable().ToListAsync();
        return _mapper.Map<List<ResultSubscriberDto>>(subscribers);
    }

    
}
