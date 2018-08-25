using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Services.Admin
{
    public class AdminFoodServices
    {
        public async Task<TokenResponse> Login(LoginDto loginDto)
        {
            var result = await _tokenProvider.RequestResourceOwnerPasswordAsync(loginDto.Login, loginDto.Password);

            if (!result.IsError)
            {
                UpdateRefreshToken(result.RefreshToken);
                LastAuthenticatedTokenResponse = result;
            }

            return result;
        }
    }
}
