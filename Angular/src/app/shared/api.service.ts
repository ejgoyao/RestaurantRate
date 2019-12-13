import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import Restaurant from './Restaurant';

@Injectable()
export default class ApiService {
	public API = 'http://localhost:8080/api';
	public RESTAURANT_ENDPOINT = `${this.API}/Restaurant`;

	constructor(private http: HttpClient) { }

	getAll(): Observable<Array<Restaurant>> {
		return this.http.get<Array<Restaurant>>(this.RESTAURANT_ENDPOINT);
	}
}
