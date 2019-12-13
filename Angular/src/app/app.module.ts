import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { StarRatingModule } from 'angular-star-rating';

import { AppComponent } from './app.component';
import ApiService from './shared/api.service';
import { StarRatingComponent } from './star-rating/star-rating.component';

@NgModule({
	declarations: [
		AppComponent,
		StarRatingComponent
	],
	imports: [
		HttpClientModule,
		BrowserModule,
		StarRatingModule.forRoot()
	],
	providers: [ApiService],
	bootstrap: [AppComponent]
})
export class AppModule { }
