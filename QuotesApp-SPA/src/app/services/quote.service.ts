import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Quote } from '../models/Quote';

const httpOptions = {
  headers: new HttpHeaders({
    Authorization: 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class QuoteService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getQuotes(): Observable<Quote[]> {
    return this.http.get<Quote[]>(this.baseUrl + 'users', httpOptions);
  }
  getQuote(id): Observable<Quote> {
    return this.http.get<Quote>(this.baseUrl + 'users/' + id, httpOptions);
  }
}
