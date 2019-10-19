import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../models/Customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  customers: any;
  selectedCustomer: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCustomers();
  }
  getCustomers() {
    this.http.get('http://localhost:5000/api/customers')
    .subscribe(response => {
      this.customers = response;
    }, error => {
      console.log(error);
    });
  }
}
