﻿using GraphiteApi.Domain.Commons.DataTransferObjects;

namespace GraphiteApi.User.API.Endpoints.User.Put;

public class UpdateUserRequest
{
	public UserDto? UserDto { get; set; } 
}