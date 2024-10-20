﻿using AcademiaNet.Shared.Entites;
using AcademiaNet.Shared.Responses;

namespace AcademiaNet.Backend.UnitsOfWork.Interfaces;

public interface IAcademicProgramUnitOfWorks
{
    Task<IEnumerable<AcademicProgram>> GetComboAsync();
    Task<ActionResponse<AcademicProgram>> AddAsync(AcademicProgramDTO academicprogramDTO);
    Task<ActionResponse<AcademicProgram>> UpdateAsync(AcademicProgram academicprogramDTO);
    Task<ActionResponse<AcademicProgram>> GetAsync(int id);
    Task<ActionResponse<IEnumerable<AcademicProgram>>> GetAsync();
}
