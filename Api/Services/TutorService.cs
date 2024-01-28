using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Services;

public class TutorService : ITutorService
{
    private readonly ApplicationDbContext _context;

    public TutorService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Tutor>> GetAllTutors()
    {
        return await _context.Tutors.ToListAsync();
    }


    public async Task<Tutor> GetTutorById(Guid id)
    {
        return await _context.Tutors.FindAsync(id);
    }

    public async Task<Tutor> CreateTutor(Tutor category)
    {
        _context.Tutors.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Tutor> UpdateTutor(Guid id, Tutor tutor)
    {
        if (id != tutor.Id)
        {
            // Id fornecido não corresponde ao Id do Tutor
            return null;
        }

        var existingTutor = await _context.Tutors.FindAsync(id);
        if (existingTutor == null)
        {
            // Tutor não encontrado
            return null;
        }

        existingTutor.Name = tutor.Name;

        // Adicione validações adicionais conforme necessário

        await _context.SaveChangesAsync();
        return existingTutor;
    }


    public async Task<bool> DeleteTutor(Guid id)
    {
        var tutor = await _context.Tutors.FindAsync(id);

        if (tutor == null)
        {
            return false;
        }

        _context.Tutors.Remove(tutor);
        await _context.SaveChangesAsync();
        return true;
    }
}