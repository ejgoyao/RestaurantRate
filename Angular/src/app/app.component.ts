import { Component, OnInit } from '@angular/core';

import Restaurant from './shared/Restaurant';
import ApiService from './shared/api.service';

@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
	Restaurants: Array<Restaurant>;
	title = 'Star Rating';
	starList: boolean[] = [true, true, true, true, true];       // create a list which contains status of 5 stars
	rating: number;
	//Create a function which receives the value counting of stars click, 
	//and according to that value we do change the value of that star in list.
	setStar(data: any) {
		this.rating = data + 1;
		for (var i = 0; i <= 4; i++) {
			if (i <= data) {
				this.starList[i] = false;
			}
			else {
				this.starList[i] = true;
			}
		}
	}  


	constructor(private apiService: ApiService) {
	}

	ngOnInit() {
		this.apiService.getAll().subscribe(data => {
			this.Restaurants = data;
		});
	}
}
