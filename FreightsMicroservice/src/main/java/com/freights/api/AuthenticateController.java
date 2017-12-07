package com.freights.api;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.freights.models.User;
import com.freights.service.IUserService;

@RestController
@RequestMapping("/auth")
public class AuthenticateController 
{
	@Autowired
	private IUserService userService;
	
	@PostMapping("/login")
	public ResponseEntity<User> login(@RequestBody String username, @RequestBody String password)
	{
		String usernameAux, passwordAux;
		User user = new User();
		user = userService.findByUsername(username);
		
		usernameAux = user.getUsername();
		passwordAux = user.getPassword();
		
		if(username == usernameAux && password == passwordAux) 
		{
			return new ResponseEntity<>(user, HttpStatus.OK);
		}
		
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}

}
