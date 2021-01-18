import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-novovinho',
  templateUrl: './novovinho.component.html',
  styleUrls: ['./novovinho.component.css']
})
export class NovoVinhoComponent {
    public wine: Wine = { name:'', vintage:'', price:0 };

    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router) {}

    adicionarNovoVinho(){
        if(!this.wine.name || !this.wine.vintage || this.wine.name=='' || this.wine.vintage=='' || this.contadorDeDecimaisNoNumero(this.wine.price)>2){
            alert('Prencha ao menos nome e safra para salvar!');
            return;
        }

        this.http.post<Wine>(this.baseUrl + 'wine', this.wine).subscribe(result => {
            this.router.navigateByUrl('/catalogo');
        }, error => console.error(error));
    }

    contadorDeDecimaisNoNumero(numero: number){
        if(Math.floor(numero.valueOf()) === numero.valueOf()) return 0;
        return numero.toString().split(".")[1].length || 0; 
    }
}

interface Wine {
    name: string;
    vintage: string;
    price: number;
}
