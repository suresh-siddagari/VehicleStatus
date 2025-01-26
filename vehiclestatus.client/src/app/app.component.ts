import { HttpClient } from '@angular/common/http';
import { Component, OnInit, signal } from '@angular/core';
import { interval, Observable, timer } from 'rxjs';

interface WeatherForecast {
	date: string;
	temperatureC: number;
	temperatureF: number;
	summary: string;
}

@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
	public forecasts: WeatherForecast[] = [];
	public vehicles: any = [];

	public customerFilter: string = '';
	constructor(private http: HttpClient) {}

	ngOnInit() {
		this.getForecasts();
		this.getVehicles();
	}

	getForecasts() {
		this.http.get<WeatherForecast[]>('/weatherforecast').subscribe(
			(result) => {
				this.forecasts = result;
			},
			(error) => {
				console.error(error);
			}
		);
	}

	getVehicles() {
		// call the API to get the vehicles for every 1 minute
		interval(1000).subscribe(() => {
			this.http.get<any[]>('/vehicle').subscribe(
				(result) => {
					this.vehicles = result;
				},
				(error) => {
					console.error(error);
				}
			);
		});
	}

	//start vehicle ping
	startPing() {
		this.http.get<any[]>('/vehicleping').subscribe();
	}
	filterTextChange(event: any) {
		console.log(event.target.value);
	}

	title = 'vehiclestatus.client';
}
