import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EventComponent } from './components/event/event.component';
import { SpeakerComponent } from './components/speaker/speaker.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, EventComponent, SpeakerComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'ProEvents-App';
}
