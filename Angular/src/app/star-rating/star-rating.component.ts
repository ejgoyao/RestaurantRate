import { Component, OnInit } from '@angular/core';
import { StarRatingModule } from 'angular-star-rating';

@Component({
  selector: 'app-star-rating',
  templateUrl: './star-rating.component.html',
  styleUrls: ['./star-rating.component.scss']
})
export class StarRatingComponent implements OnInit {
	Rating = StarRatingModule;
  constructor() { }

  ngOnInit() {
  }

}
