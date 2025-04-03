using FIAPCloudGames.Application.DTOs;
using FIAPCloudGames.Domain.Entities;
using FIAPCloudGames.Domain.Interfaces;
using BCrypt.Net;

namespace FIAPCloudGames.Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDTO?> RegisterUserAsync(RegisterUserDTO dto)
    {
        var existingUser = (await _userRepository.GetAllAsync()).FirstOrDefault(u => u.Email == dto.Email);
        if (existingUser != null)
        {
            throw new Exception("Email já cadastrado.");
        }

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password);
        var user = new User(dto.Name, dto.Email, hashedPassword, UserRole.User);

        await _userRepository.AddAsync(user);
        return new UserDTO { Name = user.Name, Email = user.Email };
    }

    public async Task<User?> AuthenticateUserAsync(LoginDTO dto)
    {
        var user = (await _userRepository.GetAllAsync()).FirstOrDefault(u => u.Email == dto.Email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
        {
            throw new Exception("Usuário ou senha inválidos.");
        }
        return user;
    }

    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(u => new UserDTO { Name = u.Name, Email = u.Email }).ToList();
    }
}
