package com.freights.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.freights.models.User;
import com.freights.repository.IUserRepository;

@Service
public class UserService implements IUserService
{
	@Autowired
	private IUserRepository userRepository;

	@Override
	public List<User> findAll() {
		List<User> list = userRepository.findAll();
		return list;
	}

	@Override
	public User findByUsername(String username) {
		User user = userRepository.findByUsername(username);
		return user;
	}

	@Override
	public void save(User user) {
		userRepository.save(user);		
	}

	@Override
	public void update(User user) {
		userRepository.save(user);
		
	}

	@Override
	public void delete(Integer id) {
		userRepository.delete(id);
		
	}

	@Override
	public User findById(Integer id) {
		User user = userRepository.findOne(id);
		return user;
	}
	
	

}
