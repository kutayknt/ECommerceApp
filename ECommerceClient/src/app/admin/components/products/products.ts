import { Component, OnInit } from '@angular/core';
import { Base, SpinnerType } from '../../../base/base';
import { NgxSpinnerService } from 'ngx-spinner';
import { HttpClientService } from '../../../services/common/http-client-service';
import { Product } from '../../../contracts/product';

@Component({
  selector: 'app-products',
  standalone: false,
  templateUrl: './products.html',
  styleUrl: './products.scss',
})
export class Products extends Base implements OnInit {
  constructor(spinner: NgxSpinnerService, private httpClient : HttpClientService) {
    super(spinner)
  }
  ngOnInit(): void {
    this.showSpinner(SpinnerType.BallAtom)

    this.httpClient.get<Product[]>({
      controller: "product"
    }).subscribe(data => console.log(data[0]));

    // this.httpClient.post({
    //   controller: "product"
    // }, {
    //   name: "Kalem",
    //   stock: 100,
    //   price: 15
    // }).subscribe();

    // this.httpClient.put({
    //   controller:"product"
    // }, {
    //   id: "019def77-e7d2-76ae-99ee-d1cf91dc9dff",
    //   name: "Renkli Kağıt",
    //   stock: 1500,
    //   price: 5.5
    // }).subscribe()

    // this.httpClient.delete({
    //   controller: "product"
    // }, "019def77-e7ca-7dcc-91c8-9776772dc9e2").subscribe()

    // this.httpClient.get({
    //   fullEndPoint: "https://jsonplaceholder.typicode.com/posts"
    // }).subscribe(data => console.log(data))
  }
  }
 
