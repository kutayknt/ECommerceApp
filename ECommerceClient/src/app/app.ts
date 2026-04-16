import { Component, OnInit, signal } from '@angular/core';
import e from 'express';
import { ToastrService } from 'ngx-toastr';
import { CustomToastrService, ToastrMessageType, ToastrOptions, ToastrPosition } from './services/ui/custom-toastr.service';
import { MessageType } from './services/admin/alertify.service';
declare var $: any; //Buraya göz at $ is not defined hatası var.


@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.scss'
})
export class App{
  constructor(private customToastr: CustomToastrService ) {
    this.customToastr.message("Sipariş", "Sipariş", {
      messageType: ToastrMessageType.Error,
      position: ToastrPosition.BottomRight
    })
    this.customToastr.message("Sipariş", "Sipariş", {
      messageType: ToastrMessageType.Info,
      position: ToastrPosition.BottomLeft
    })
    this.customToastr.message("Sipariş", "Sipariş", {
      messageType: ToastrMessageType.Success,
      position: ToastrPosition.TopLeft
    })
    this.customToastr.message("Sipariş", "Sipariş", {
      messageType: ToastrMessageType.Warning,
      position: ToastrPosition.TopRight
    })
  }
  protected readonly title = signal('ECommerceClient');

}
// export class App implements OnInit{
  // ngOnInit(): void {
  //   $(document).ready(() => {
  //     alert("Deneme Alarmı")
  //   })
// }
// }






