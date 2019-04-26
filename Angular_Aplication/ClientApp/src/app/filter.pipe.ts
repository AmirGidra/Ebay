import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {
  transform(data: any[], param: string, term: string): any[] {
    // Check if the search term is undefined
    if (!data) {
      return [];
    }
    if (!term) {
      return data;
    }

    return data.filter(item => {
      return item[param].toLowerCase().includes(term.toLowerCase());
    });
  }
}
