using Microsoft.AspNetCore.Identity;
using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.IUnitOfWorks;
using PortalManagement.Domain.ViewModels.User;
using PortalManagement.DTO.DTOS.UserDtos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        // First, validate user input
        _userHelperManagementService.ValidateUserCreateInput(createUserDto.UserName, createUserDto.Email);
        await _userHelperManagementService.ValidateEmailUniquenessAsync(_userManager, createUserDto.Email);

        // Map CreateUserDto to AppUser entity
        var appUser = new AppUser
        {
            UserName = createUserDto.UserName,
            Email = createUserDto.Email,
            PhoneNumber = createUserDto.PhoneNumber
        };

        // Use UserManager to handle user creation and password hashing
        var result = await _userManager.CreateAsync(appUser, createUserDto.Password);
        if (!result.Succeeded)
        {
            throw new Exception("User creation failed: " + string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        // Save the AppUser entity in the database using the repository
        await _unitOfWork.TGetWriteAppUserRepository.CreateUser(appUser);
        await _unitOfWork.SaveAsync();
    }
}
