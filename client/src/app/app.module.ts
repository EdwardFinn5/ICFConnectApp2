import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { StudentsComponent } from './students/students.component';
import { EmployersComponent } from './employers/employers.component';
import { SignupComponent } from './signup/signup.component';
import { AboutComponent } from './about/about.component';
import { ShowDelComponent } from './students/show-del/show-del.component';
import { AddEditComponent } from './students/add-edit/add-edit.component';
import { MajorComponent } from './major/major.component';
import { ShowMajComponent } from './major/show-maj/show-maj.component';
import { AddEditMajComponent } from './major/add-edit-maj/add-edit-maj.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentsComponent,
    EmployersComponent,
    SignupComponent,
    AboutComponent,
    ShowDelComponent,
    AddEditComponent,
    MajorComponent,
    ShowMajComponent,
    AddEditMajComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
