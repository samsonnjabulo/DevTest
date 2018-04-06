import { Injectable } from '@angular/core';
import {Http ,Response} from '@angular/http';
import 'rxjs/add/operator/map'
import {Observable} from 'rxjs/Observable'
import { environment } from '../../environments/environment';
import { Department } from '../models/department.model';
@Injectable()
export class DepartmentService {

  student:Department;
  constructor( public _http:Http) { }

  getDepartment():Observable<Department>{   
    const url = environment.baseUrl+'/Department/GetAllDepartments';
    return this._http.get(url)
    .map((response: Response)=><Department>response.json())
   }


}
