using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class AnimalsService : IAnimalsService
{
    private readonly IAnimalsRepository _animalsRepository;

    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        var data = _animalsRepository.GetAnimals(orderBy);
        return data;
    }

    public int CreateAnimal(Animal newAnimal)
    {
        return _animalsRepository.CreateAnimal(newAnimal);
    }

    public int UpdateAnimal(int id, Animal animal)
    {
        return _animalsRepository.UpdateAnimal(id, animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }
}