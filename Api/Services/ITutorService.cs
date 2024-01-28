using Api.Models;

namespace Api.Services;

public interface ITutorService
{
    Task<List<Tutor>> GetAllTutors();
    Task<Tutor> GetTutorById(Guid id);
    Task<Tutor> CreateTutor(Tutor category);
    Task<Tutor> UpdateTutor(Guid id, Tutor tutor);
    Task<bool> DeleteTutor(Guid id);
    
}