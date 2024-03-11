import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { response } from 'express';

@Component({
  selector: 'app-event',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './event.component.html',
  styleUrl: './event.component.scss'
})
export class EventComponent implements OnInit {
  public events: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEvents();
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
  }
  public getEvents(): void{
    this.http.get("https://localhost:5223/Event").subscribe(
      response => this.events = response,
    )
  }

}
