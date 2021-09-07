import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SharedService {
readonly APIUrl = "https://localhost:5001/api";
readonly PhotoUrl = "https://localhost:5001/Photos";

  constructor(http:) {}
}
