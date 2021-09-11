import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SharedService {
  readonly APIUrl = 'https://localhost:5001/api';
  readonly PhotoUrl = 'https://localhost:5001/Photos';

  constructor(private http: HttpClient) {}

  getMajorList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/majors');
  }

  addMajor(val: any) {
    return this.http.post(this.APIUrl + '/majors', val);
  }

  updateMajor(val: any) {
    return this.http.put(this.APIUrl + '/majors', val);
  }

  deleteMajor(val: any) {
    return this.http.delete(this.APIUrl + '/majors', val);
  }

  getUserList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + 'users');
  }

  addUser(val: any) {
    return this.http.post(this.APIUrl + '/users', val);
  }

  updateUser(val: any) {
    return this.http.put(this.APIUrl + '/users', val);
  }

  deleteUser(val: any) {
    return this.http.delete(this.APIUrl + '/users/' + val);
  }

  uploadPhoto(val: any) {
    return this.http.post(this.APIUrl + '/users/SaveFile', val);
  }

  getAllMajorNames(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/majors');
  }
}
