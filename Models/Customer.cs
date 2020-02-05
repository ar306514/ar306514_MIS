﻿using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	public int customerID { get; set; }
	public string firstName { get; set; }
	public string lastName { get; set; }
	public string email { get; set; }
	public string phone { get; set; }
	public DateTime customerSince { get; set; }

	// add any other fields as appropriate
	// a customer can have any number of orders, a 1:M relationship,
	// We represent this in the model with an ICollection
	// The syntax says we are creating an ICollection of Order objects,
	// (the name inside the <> is the object name),
	// and the local name of the collection will be Order
	// (the object name and the local name do not have to be the same)
	public ICollection<Order> Order { get; set; }
}
}


