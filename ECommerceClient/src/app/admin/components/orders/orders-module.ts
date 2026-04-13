import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Orders } from './orders';
import { Router } from 'express';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [Orders],
  imports: [CommonModule, RouterModule.forChild([
    {path:"",component:Orders}
  ])],
})
export class OrdersModule {}
