import { Component, OnInit } from '@angular/core';
import { AlertifyOptions, AlertifyService, MessageType, Position } from '../../../services/admin/alertify.service';
import { toUSVString } from 'util';
import { delay } from 'rxjs';
import { posix } from 'path';
import { NgxSpinnerService } from 'ngx-spinner';
import { Base, SpinnerType } from '../../../base/base';

@Component({
  selector: 'app-dashboard',
  standalone: false,
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.scss',
})
// export class Dashboard{}

export class Dashboard extends Base implements OnInit{
  constructor(private alertify: AlertifyService, spinner: NgxSpinnerService) {
    super(spinner)
  }
  ngOnInit(): void { 
    this.showSpinner(SpinnerType.BallAtom);
  }
  m() {
    this.alertify.message("Custom Alertify", {
      delay: 3,
      dismissOthers: true,
      messageType: MessageType.Error,
      position: Position.BottomRight
    }); 
  }
  d() {
    this.alertify.dismiss();
  }

    
}
