﻿using AcademiaNet.Backend.Repositories.Interfaces;
using AcademiaNet.Backend.UnitsOfWork.Interfaces;
using AcademiaNet.Shared.Entites;
using AcademiaNet.Shared.Responses;

namespace AcademiaNet.Backend.UnitsOfWork.implementations;

public class AcademicProgramsUnitOfWork : GenericUnitOfWork<AcademicProgram>, IAcademicProgramsUnitOfWorks
{
    private readonly IAcademicprogramsRepository _AcademicprogramsRepository;
    public AcademicProgramsUnitOfWork(IGenericRepository<AcademicProgram> repository, IAcademicprogramsRepository AcademicprogramsRepository) : base(repository)
    {
        _AcademicprogramsRepository  = AcademicprogramsRepository;
    }

    public Task<ActionResponse<AcademicProgram>> AddAsync(AcademicProgramDTO academicprogramDTO)
    {
        throw new NotImplementedException();
    }

    public override async Task<ActionResponse<IEnumerable<AcademicProgram>>> GetAsync() => await
        _AcademicprogramsRepository.GetAsync();

    public override async Task<ActionResponse<AcademicProgram>> GetAsync(int id) => await _AcademicprogramsRepository.GetAsync(id);


    public async Task<IEnumerable<AcademicProgram>> GetComboAsync(int institutionID) => await _AcademicprogramsRepository.GetComboAsync();

    public Task<IEnumerable<AcademicProgram>> GetComboAsync()
    {
        throw new NotImplementedException();
    }
}