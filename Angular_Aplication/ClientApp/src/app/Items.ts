import { Category } from './models/category.model';
import { Condition } from './enums/condition.enum';
export class Items {
  id: number;
  title: string;
  price: number;
  img: string;
  category: Category;
  freeShipping: boolean;
  condition: Condition;

  constructor(id: number, title: string, price: number, img: string, category: Category, freeShipping: boolean, condition: Condition) {
        this.id = id;
        this.title = title;
        this.price = price;
        this.img = img;
        this.category = category;
        this.freeShipping = freeShipping;
        this.condition = condition;
   }
}
