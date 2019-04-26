import { Items } from './../Items';
import { Condition } from './../enums/condition.enum';
import { FilterServisService } from './../filter-servis.service';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { CategoryService } from '../category.service';



@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.css']
})
export class FilterComponent implements OnInit {

@Output() conditionBtn = new EventEmitter<Condition>();
@Output() valuesOfPrices = new EventEmitter<Items>();

  public category = [];
  public filteredItems: CategoryService;
  public priceValues: {};
  public minMoney: number ;
  public maxMoney: number ;
  public isChecked  = false;

  constructor(private categoryService: CategoryService, private filterService: FilterServisService) { }

  ngOnInit() {
    this.categoryService.getCategory()
        .subscribe(data => this.category = data);
  }
  //Check
  checkFields(event: Condition) {
    this.filterService.conditionBtn.emit(event);
  }

  // Select
  selectChange(event: any) {
    this.filterService.category.emit(event.target.value);
  }

  // shipping
  setShipping(value: boolean) {
    this.filterService.freeShipping.emit(value);
  }

   // checkMoney function
   getPrice(val1,val2) {
     this.priceValues = {val1,val2};
     this.filterService.valueOfPrices.emit(this.priceValues);
    }
}
