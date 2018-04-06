import { Injectable } from '@angular/core';
import { Student } from '../models/student.model';
import {Http ,Response} from '@angular/http';
import 'rxjs/add/operator/map'
import {Observable} from 'rxjs/Observable'
import { environment } from '../../environments/environment';

@Injectable()
export class StudentService {
  student:Student;
  constructor( public _http:Http) { }

  getStudentDetails():Observable<Student>{   
    const url = environment.baseUrl+'/Siebel/DevTestMethod';
    return this._http.get(url)
    .map((response: Response)=><Student>response.json())
   }

   getStudentByStudentNumber(studentNumber:number):Observable<Student>
   { 
    const url = `${environment.baseUrl+"/Student/"}?${"studentNumber="+studentNumber}`;
                 return this._http.get(url)
                            .map((response:Response)=> <Student>response.json())
   }

}
