import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService 
{
  url: string = 'https://localhost:11223/api/employee';

  constructor(private http: HttpClient) { }

  getEmployees(id: string): Observable<Employee[]> 
  {     
    if (id) {
      return this.http.get<Employee[]>(this.url + "/" + Number(id));  
    }
    return this.http.get<Employee[]>(this.url);
  }
}