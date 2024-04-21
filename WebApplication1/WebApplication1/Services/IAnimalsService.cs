﻿using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(int id, Animal animal);
    int DeleteAnimal(int idAnimal);
}