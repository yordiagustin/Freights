package com.freights.service;

import java.util.List;

import com.freights.models.Order;

public interface IOrderService 
{
	public List<Order> findAll();
	public Order findById(Integer id);
	public Order findByClientId(Integer id);
	public Order findByDriverId(Integer id);
	public void save(Order order);
	public void update(Order order);
	public void delete(Integer id);
}
