import { Component } from "@angular/core";
import { EmployeeService } from "../services/employee.service";
import { EmployeeResults } from '../interface/EmployeeResults';


@Component({
  selector: "app-login",
  templateUrl: "./employee.component.html",
  providers: [EmployeeService]
})
export class EmployeeComponent {
  msg: string = "";
  results:EmployeeResults={Employees:[],Succeeded:false,Messages:[]};

  constructor(private service: EmployeeService) { }



  find(lastname: string) {
    this.service.Search(lastname).subscribe(
      (res) => {
        if (res != null && res.Succeeded ) {
          this.results = res;
        }
        else {
          this.msg = "not found";
        }

      },
      err => {
        if (err.status == 400) {
          this.msg = "Invalid Username or Password";
        } else {
          console.log(err);
        }
      }
    );
  }
}
