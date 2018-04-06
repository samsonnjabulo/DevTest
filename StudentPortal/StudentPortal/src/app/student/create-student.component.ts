import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import{Department} from '../models/department.model';
import { DepartmentService } from '../department/department.service';

@Component({
  selector: 'app-create-student',
  templateUrl: './create-student.component.html',
  styleUrls: ['./create-student.component.css']
})
export class CreateStudentComponent implements OnInit {
 departments
  constructor(public _dep:DepartmentService) { }

  ngOnInit() {
    
    this._dep.getDepartment().subscribe((posts)=>
    this.departments = posts)
  }
  saveStudent(stdForm:NgForm):void{
    console.log(stdForm.value)
  }
}
