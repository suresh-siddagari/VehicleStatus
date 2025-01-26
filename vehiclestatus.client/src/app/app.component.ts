import { HttpClient } from '@angular/common/http';
import { Component, OnInit, signal } from '@angular/core';
import { interval, Observable, timer } from 'rxjs';
import { CustomerVehicle } from '../models/ResponseModel';

@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
	public filteredVehicles: CustomerVehicle[] = [];

	public customerFilter: string = '';
	constructor(private http: HttpClient) {}

	ngOnInit() {
		this.getVehicles();
	}

	getVehicles() {
		// call the API to get the vehicles for every 1 minute
		interval(10000).subscribe(() => {
			this.http.get<any[]>('/vehicle').subscribe(
				(result) => {
					const vehicles = result;
					this.filterVehicles(vehicles);
				},
				(error) => {
					console.error(error);
				}
			);
		});
	}

	//filter vehicles
	filterVehicles(vehicles: CustomerVehicle[]) {
		this.filteredVehicles = vehicles.filter((vehicle) => {
			return vehicle.customerName.toLowerCase().includes(this.customerFilter.toLowerCase());
		});
	}

	//start vehicle ping
	startPing() {
		this.http.get<any[]>('/vehicleping').subscribe();
	}

	title = 'vehiclestatus.client';
}
