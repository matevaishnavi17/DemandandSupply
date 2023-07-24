import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class ServicesService {

  baseUrl = "http://localhost:5104/"
  constructor(private http: HttpClient) { }

  getAllData(){
    return this.http.get(  this.baseUrl + "DandSApi/DisplayForAdmin/GetAll");
  }

  getDataByPositionId(positionId: string){
    return this.http.get(  this.baseUrl + "DandSApi/DisplayForAdmin/GetByPositionId/" + positionId)
  }
}
