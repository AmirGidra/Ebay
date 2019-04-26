import { Injectable, Output, EventEmitter } from '@angular/core';
import { Condition } from './enums/condition.enum';

@Injectable({
  providedIn: 'root'
})
export class FilterServisService {

  // event emiter
  @Output() conditionBtn = new EventEmitter<Condition>();
  @Output() freeShipping = new EventEmitter<boolean>();
  @Output() category = new EventEmitter<any>();
  @Output() valueOfPrices = new EventEmitter<any>();

  constructor() { }
}
