package com.freights.api;

import java.util.*;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.freights.models.User;
import com.freights.service.IUserService;

@RestController
@RequestMapping("user")
public class UsersController 
{
	@Autowired
	private IUserService userService;
	
	@GetMapping("/{id}")
	public ResponseEntity<User> findById(@RequestBody Integer id)
	{
		User user = new User();
		user = userService.findById(id);
		return new ResponseEntity<>(user, HttpStatus.OK);
	}
	
	/*Client Methods*/
	
	@GetMapping("/client")
	public ResponseEntity<List<User>> getClients()
	{
		List<User> listaClientes = new ArrayList<User>();
		List<User> listaAux = new ArrayList<User>();
		listaAux = userService.findAll();
		for(User user : listaAux)
		{
			if(user.getRole() == "client")
			{
				listaClientes.add(user);
			}
		}
		return new ResponseEntity<>(listaClientes, HttpStatus.OK);
	}
	
	@PostMapping("/client")
	public ResponseEntity<User> createClient(@RequestBody User user)
	{
		user.setRole("client");
		userService.save(user);
		return new ResponseEntity<>(user,HttpStatus.OK);
	}
	
	@PutMapping("/client")
	public ResponseEntity<User> updateClient(@RequestBody User user)
	{
		userService.update(user);
		return new ResponseEntity<>(user,HttpStatus.OK);
	}
	
	@DeleteMapping("/client/{id}")
	public ResponseEntity<Object> deleteClient(@RequestBody Integer id)
	{
		userService.delete(id);
		return new ResponseEntity<>(HttpStatus.OK);
	}
	
	/*Employees Methods*/
	
	@GetMapping("/employee")
	public ResponseEntity<List<User>> getEmployees()
	{
		List<User> listaClientes = new ArrayList<User>();
		List<User> listaAux = new ArrayList<User>();
		listaAux = userService.findAll();
		for(User user : listaAux)
		{
			if(user.getRole() == "employee")
			{
				listaClientes.add(user);
			}
		}
		return new ResponseEntity<>(listaClientes, HttpStatus.OK);
	}
	
	@PostMapping("/employee")
	public ResponseEntity<User> createEmployee(@RequestBody User user)
	{
		user.setRole("employee");
		userService.save(user);
		return new ResponseEntity<>(user,HttpStatus.OK);
	}
	
	@PutMapping("/employee")
	public ResponseEntity<User> updateEmployee(@RequestBody User user)
	{
		userService.update(user);
		return new ResponseEntity<>(user,HttpStatus.OK);
	}
	
	@DeleteMapping("/employee/{id}")
	public ResponseEntity<Object> deleteEmployee(@RequestBody Integer id)
	{
		userService.delete(id);
		return new ResponseEntity<>(HttpStatus.OK);
	}
	
	
}
