package com.freights.models;

import java.time.*;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="ordenes")
public class Order 
{
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private Integer id;
	
	@Column(name="name",length=50, nullable= false)
	private String departureDate;
	
	@Column(name="surname",length=50, nullable= false)
	private String departureTime;
	
	@Column(name="status",length=50, nullable= false)
	private String status;
	
	@Column(name="clientId",length=50, nullable= false)
	private String clientId;
	
	@Column(name="employeeId",length=50, nullable= false)
	private String employeeId;
	
	@Column(name="driverId",length=50, nullable= true)
	private String driverId;
	
	@Column(name="weight",length=50, nullable= false)
	private String weight;
	
	@Column(name="height",length=50, nullable= false)
	private String height;
	
	@Column(name="observations",length=50, nullable= false)
	private String observations;
}
