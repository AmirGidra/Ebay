import { Category } from './models/category.model';
import { Items } from './Items';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private categoryItemData = '../assets/data/category.json';
  private itemColectionData = '../assets/data/items.json';

  constructor(private http: HttpClient) { }

     getCategory(): Observable<Category[]> {
          return this.http.get<Category[]>(this.categoryItemData);
      }

      getItems(): Observable<Items[]> {
        return this.http.get<Items[]>(this.itemColectionData);
      }

}

