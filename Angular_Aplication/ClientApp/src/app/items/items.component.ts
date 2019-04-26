import { Category } from './../models/category.model';
import { FilterServisService } from './../filter-servis.service';
import { Condition } from './../enums/condition.enum';
import { CategoryService } from './../category.service';
import { Component, OnInit, Input } from '@angular/core';
import { Items } from '../Items';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemsComponent implements OnInit {

// tslint:disable-next-line: no-input-rename
  @Input('textInp') searchTextInput: string;
// tslint:disable-next-line: no-input-rename
  @Input('valCondition') conditionFilter: Condition;

  public items: Items[] = [];
  public shipping: boolean;
  public filteredCondition: Condition;
  public filteredItems: Items[] = [];
  public categoryValue: Category;
  public prices = {val1 : 0,val2 : 0};


// const result = strs.filter(s => s.includes('val'));
/* data.filter(item => {item[param].includes(term); */



  constructor( private categoryService: CategoryService, private filterService: FilterServisService ) { }

  ngOnInit() {

    this.categoryService.getItems()
      .subscribe(data => {
        this.items = data;
        this.filteredItems = this.items;
      });
      // function for checking freeshipping functionality
    this.filterService.freeShipping.subscribe(tip => {
      this.shipping = tip;
      this.filteredItems = [];
      this.items.filter(item => {
        if (!this.shipping || item.freeShipping === this.shipping) {
          this.filteredItems.push(item);
        }
      });
    });
    // function for checking category functionality
    this.filterService.category.subscribe(value => {
      this.categoryValue = value;
      this.filteredItems = [];
      this.items.filter(oneItem => {
        if (this.categoryValue == 0 || oneItem.id == this.categoryValue) {
          console.log(oneItem.id);
          this.filteredItems.push(oneItem);
        }
      });
    });
    // function for checking condition functionality
    this.filterService.conditionBtn.subscribe(valCondition => {
        this.filteredCondition = valCondition;
        this.filteredItems = [];
        this.items.filter(condit => {
          if (this.filteredCondition == 0 || this.filteredCondition == condit.condition) {
            this.filteredItems.push(condit);
          }
        });
    });
    // money price checking
    this.filterService.valueOfPrices.subscribe(priceObj => {
      this.prices = priceObj;
      const { val1: min, val2: max  } = this.prices;
      this.filteredItems = this.items.filter(item =>
        item.price >= min && item.price <= max  );
 });
}

}
