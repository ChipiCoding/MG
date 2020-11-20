import { ReturnStatement } from '@angular/compiler';
import { error } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Employee } from '../../models/employee';
import { EmployeeService  }  from '../../services/employee.service'

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit 
{  
  employees: Employee[];  

  constructor(private employeeService: EmployeeService) { }

  ngOnInit(): void 
  {    
    this.getEmployees("");
  }

  getEmployees(id: string): void 
  {
    this.employeeService.getEmployees(id).subscribe(employees => 
    {
      this.employees = employees;        
    }, error => 
    {
      alert("Only numbers are allowed for searching");
    });;
  }
}