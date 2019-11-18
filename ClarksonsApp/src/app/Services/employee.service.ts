import { Injectable } from "@angular/core";
import { environment } from "../../environments/environment";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { EmployeeResults } from '../interface/EmployeeResults';

@Injectable()
export class EmployeeService {
  readonly baseUrl: string = environment.baseUrl;

  constructor(private http: HttpClient) {}

  Search(lastname: string): Observable<EmployeeResults> {
    return this.http.get<EmployeeResults>(this.baseUrl + "/api/employee/find/"+lastname);
  }

}
