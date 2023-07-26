import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DemandDataServiceService {
  baseUrl = "http://localhost:5285/"
  constructor(private http: HttpClient) { }

  getAllData(){
    return this.http.get(  this.baseUrl + "api/DemandDetails/GetAll");
  }

  getDataByPositionId(positionId: string){
    return this.http.get(  this.baseUrl + "DandSApi/DisplayForAdmin/GetByPositionId/" + positionId)
  }
  
}
