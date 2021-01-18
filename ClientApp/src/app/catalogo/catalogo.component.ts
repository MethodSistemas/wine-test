import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-catalogo',
  templateUrl: './catalogo.component.html'
})
export class CatalogoComponent {
  public wines: Wine[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Wine[]>(baseUrl + 'wine').subscribe(result => {
      this.wines = result;
    }, error => console.error(error));
  }
}

interface Wine {
    name: string;
    vintage: string;
    price: number;
}
