package com.freights.service;

import java.util.List;

import com.freights.models.User;

public interface IUserService 
{
	public List<User> findAll();
	public User findByUsername(String username);
	public User findById(Integer id);
	public void save(User user);
	public void update(User user);
	public void delete(Integer id);
}
