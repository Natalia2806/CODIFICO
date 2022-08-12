import { Injectable } from '@angular/core';
import { UserI } from '../models/user.interface'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private url: string = 'https://api.github.com/users/' 

  constructor( private _httpClient:HttpClient) { }

  getUser(userName:string): Observable<UserI>{
    return this._httpClient.get<UserI>(this.url + userName)
  }

}
