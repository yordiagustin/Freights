package com.freights.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.freights.models.Order;
import com.freights.repository.IOrderRepository;

@Service
public class OrderService implements IOrderService 
{
	@Autowired
	private IOrderRepository orderRepository;

	@Override
	public List<Order> findAll() {
		List<Order> lista = orderRepository.findAll();
		return lista;
	}
	
	@Override
	public Order findById(Integer id) {
		Order order = orderRepository.findOne(id);
		return order;
	}

	@Override
	public void save(Order order) {
		orderRepository.save(order);
	}

	@Override
	public void update(Order order) {
		orderRepository.save(order);
	}

	@Override
	public void delete(Integer id) {
		orderRepository.delete(id);
	}

	@Override
	public Order findByClientId(Integer id) {
		Order order = orderRepository.findByClientId(id);
		return order;
	}

	@Override
	public Order findByDriverId(Integer id) {
		Order order = orderRepository.findByDriverId(id);
		return order;
	}	

}
