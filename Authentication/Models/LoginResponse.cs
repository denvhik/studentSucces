﻿namespace AuthenticationWebApi.Models;
public class LoginResponse
{
        public string Token { get; set; }
        public string RefreshToken { get; set; }
}
