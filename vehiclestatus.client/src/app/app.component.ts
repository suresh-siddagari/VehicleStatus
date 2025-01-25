import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

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
		this.http.get<any[]>('/vehicle').subscribe(
			(result) => {
				this.vehicles = result;
			},
			(error) => {
				console.error(error);
			}
		);
	}

	title = 'vehiclestatus.client';
}
