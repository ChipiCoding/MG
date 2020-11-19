import { Component, OnInit } from '@angular/core';
import { Employee } from '../../models/employee';
import { HttpClient } from '@angular/common/http';

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
    this.http.get<any>(this.url).subscribe(data => {
      this.employees = data;
   },error => this.error = error);
  }

}
