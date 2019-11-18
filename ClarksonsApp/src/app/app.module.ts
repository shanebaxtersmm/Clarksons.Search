import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';




import { CommonModule } from "@angular/common";
import { HttpClientModule} from "@angular/common/http";





import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import{ EmployeeComponent } from './employee/employee.component'
import { EmployeeService } from './services/employee.service';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
