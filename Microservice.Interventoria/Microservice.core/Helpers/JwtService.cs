﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.core.Helpers
{
	public class JwtService
	{
		private string secureKey = "this is a very secure key";
		public string Generate(int id) 
		{
			var symmetricSecurityKey =  new SymmetricSecurityKey( Encoding.UTF8.GetBytes(secureKey));
			var credentials = new SigningCredentials(symmetricSecurityKey, algorithm: SecurityAlgorithms.HmacSha512Signature);
			var header = new JwtHeader(credentials);

			var payload = new JwtPayload(id.ToString(), null, null, null, DateTime.Today.AddDays(1));
			var securityToken = new JwtSecurityToken(header, payload);

			return new JwtSecurityTokenHandler().WriteToken(securityToken);


		}

	}
}
