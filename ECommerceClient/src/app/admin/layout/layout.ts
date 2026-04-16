import { Component, OnInit } from '@angular/core';
import { AlertifyService, MessageType, Position } from '../../services/admin/alertify.service';
import { delay } from 'rxjs';


@Component({
  selector: 'app-layout',
  standalone: false,
  templateUrl: './layout.html',
  styleUrl: './layout.scss',
})
export class Layout implements OnInit{
  // constructor(private alertify: AlertifyService) { }
  ngOnInit(): void {
    // this.alertify.message("Custom Alertify", MessageType.MessageType,Position.BottomLeft); 
    // alertify.success('Success message');
  }
}
