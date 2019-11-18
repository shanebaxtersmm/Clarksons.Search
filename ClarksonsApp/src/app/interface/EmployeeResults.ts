import { Employee } from './Employee';
import { Item } from './Item';

export interface EmployeeResults {
  Employees: Employee[];
  Succeeded:boolean;
  Messages:Item[];
}
