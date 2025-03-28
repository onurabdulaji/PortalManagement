using Microsoft.AspNetCore.Identity;
using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.IUnitOfWorks;
using PortalManagement.DTO.DTOS.UserDtos;

namespace PortalManagement.Application.IManagement.UserService;

public class UserManagementService : IUserManagementService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserHelperManagementService _userHelperManagementService;
    private readonly UserManager<AppUser> _userManager;

    public UserManagementService(IUnitOfWork unitOfWork, IUserHelperManagementService userHelperManagementService, UserManager<AppUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userHelperManagementService = userHelperManagementService;
        _userManager = userManager;
    }

    public async Task CreateUserAsync(CreateUserDto createUserDto)
    {
        _userHelperManagementService.ValidateUserCreateInput(createUserDto.UserName, createUserDto.Email);
        await _userHelperManagementService.ValidateEmailUniquenessAsync(_userManager, createUserDto.Email);

        var appUser = new AppUser
        {
            UserName = createUserDto.UserName,
            Email = createUserDto.Email,
            PhoneNumber = createUserDto.PhoneNumber
        };

        var result = await _userManager.CreateAsync(appUser, createUserDto.Password);
        if (!result.Succeeded)
        {
            throw new Exception("User creation failed: " + string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        await _unitOfWork.TGetWriteAppUserRepository.CreateUser(appUser);
        await _unitOfWork.SaveAsync();
    }
}


// First, validate user input
// Map CreateUserDto to AppUser entity -- bul care mapper ile mi mapster ile mi maple buni
// Use UserManager to handle user creation and password hashing
// Create the AppUser entity in the database using the repository and save with UnitOfWork
