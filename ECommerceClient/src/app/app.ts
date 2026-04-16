import { Component, OnInit, signal } from '@angular/core';
import e from 'express';
declare var $: any; //Buraya göz at $ is not defined hatası var.


@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.scss'
})
export class App{
  protected readonly title = signal('ECommerceClient');
}
// export class App implements OnInit{
  // ngOnInit(): void {
  //   $(document).ready(() => {
  //     alert("Deneme Alarmı")
  //   })
// }
// }






