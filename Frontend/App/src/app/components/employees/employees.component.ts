import { Component, OnInit } from '@angular/core';
import { Employee } from '../../models/employee';
import { HttpClient } from '@angular/common/http';
import { stringify } from 'querystring';
import { strict } from 'assert';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit 
{
  url: string = 'https://localhost:11223/api/employee';
  employees: Employee[];
  error;

  constructor(private http: HttpClient) { }

  ngOnInit(): void 
  {
    this.getEmployees("");
  }

  getEmployees(idEmployee: string): void 
  {
    let _url : string = this.url;
  
    if (idEmployee) 
    {
      _url = this.url + "/" + Number(idEmployee);
    }
    
    this.http.get<any>(_url).subscribe(data => 
      {
        this.employees = data;
      },
      error => 
        {
          this.error = error; console.log(error)
        });
  }
}