using System;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Service.Abstract;

public interface IAuthService
{
    Task<ResponseDto<????>> LoginAsync(LoginDto loginDto);
}
