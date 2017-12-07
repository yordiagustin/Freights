package com.freights.api;

import java.util.ArrayList;
import java.util.List;

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

import com.freights.models.Order;
import com.freights.service.IOrderService;

@RestController
@RequestMapping("v1")
public class OrderControllers 
{
	@Autowired
	private IOrderService orderService;
	
	
	/*Orders Methods*/
	
	@GetMapping("/order")
	public ResponseEntity<List<Order>> getOrders()
	{
		List<Order> lista = new ArrayList<Order>();
		lista = orderService.findAll();
		return new ResponseEntity<>(lista, HttpStatus.OK);
	}
	
	@GetMapping("/order/driver/{id}")
	public ResponseEntity<Order> getOrderByDriver(@RequestBody Integer id)
	{
		Order order = new Order();
		order = orderService.findByDriverId(id);
		return new ResponseEntity<>(order, HttpStatus.OK);
	}
	
	@GetMapping("/order/client/{id}")
	public ResponseEntity<Order> getOrderByClient(@RequestBody Integer id)
	{
		Order order = new Order();
		order = orderService.findByClientId(id);
		return new ResponseEntity<>(order, HttpStatus.OK);
	}
	
	@PostMapping("/order")
	public ResponseEntity<Order> createClient(@RequestBody Order order)
	{
		orderService.save(order);
		return new ResponseEntity<>(order,HttpStatus.OK);
	}
	
	@PutMapping("/order")
	public ResponseEntity<Order> updateClient(@RequestBody Order order)
	{
		orderService.update(order);
		return new ResponseEntity<>(order,HttpStatus.OK);
	}
	
	@DeleteMapping("/order/{id}")
	public ResponseEntity<Object> deleteClient(@RequestBody Integer id)
	{
		orderService.delete(id);
		return new ResponseEntity<>(HttpStatus.OK);
	}
}
