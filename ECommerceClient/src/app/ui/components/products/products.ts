import { Component, OnInit } from '@angular/core';
import { Base, SpinnerType } from '../../../base/base';
import { NgxSpinner, NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-products',
  standalone: false,
  templateUrl: './products.html',
  styleUrl: './products.scss',
})
export class Products extends Base implements OnInit {
   constructor(spinner: NgxSpinnerService) {
    super(spinner)
  }
  ngOnInit(): void {
   this.showSpinner(SpinnerType.BallScaleMultiple)
  }
}
