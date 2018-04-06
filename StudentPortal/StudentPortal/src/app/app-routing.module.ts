import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StudentComponent } from './student/student.component';
import { CreateStudentComponent } from './student/create-student.component';

const routes: Routes = [
  {path:'list', component:StudentComponent},
  {path:'create',component:CreateStudentComponent},
  {path:'', redirectTo:'/list',pathMatch:'full'},

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
