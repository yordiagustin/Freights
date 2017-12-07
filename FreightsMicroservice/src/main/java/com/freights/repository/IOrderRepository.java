package com.freights.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.freights.models.Order;

@Repository
public interface IOrderRepository extends JpaRepository<Order, Integer> 
{
	public Order findByClientId(Integer clientId);
	public Order findByDriverId(Integer driverId);
}
