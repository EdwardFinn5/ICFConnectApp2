import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { EmployersComponent } from './employers/employers.component';
import { HomeComponent } from './home/home.component';
import { SignupComponent } from './signup/signup.component';
import { StudentsComponent } from './students/students.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'students', component: StudentsComponent },
  { path: 'employers', component: EmployersComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'about', component: AboutComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
