import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutModule } from './layout/layout-module';
import { Layout } from './layout/layout';
import { ComponentsModule } from './components/components-module';
import { RouterModule } from '@angular/router';
import { Router } from 'express';

@NgModule({
  declarations: [],
  imports: [CommonModule 
    ,LayoutModule
    , ComponentsModule,
    RouterModule
  ],
  exports: [LayoutModule]
})
export class AdminModule {}
