package com.freights.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.freights.models.User;

@Repository
public interface IUserRepository extends JpaRepository<User, Integer>
{
	User findByUsername(String username);
}
