import { Component } from '@angular/core';
import { Condition } from './enums/condition.enum';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public inputText = '';
  public filterCondtition: Condition ;

  conditionFilterData(data) {
    this.filterCondtition = data;
  }

  searchItem(val: HTMLInputElement ) {
    this.inputText = val.value;
  }
}
