import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpParams, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FileUploadService {

  constructor(private http: HttpClient) { }

  // file from event.target.files[0]
  uploadFile(url: string, file: File): Observable<HttpEvent<any>> {

    let formData = new FormData();
    formData.append('upload', file);

    let params = new HttpParams();

    const options = {
      params: params,
      reportProgress: true,
    };

    const req = new HttpRequest('POST', url, formData, options);
    return this.http.request(req);
  }
}

  // constructor(private http: HttpClient) { }
  // selectedFile: File | null = null;
  
  // uploadFile(url: string, file: File): Observable<HttpEvent<any>> {

  //   let formData = new FormData();
  //   formData.append('upload', file);

  //   let params = new HttpParams();

  //   const options = {
  //     params: params,
  //     reportProgress: true,
  //   };

  //   const req = new HttpRequest('POST', 'http://localhost:5224/upload', formData, options);
  //   return this.http.request(req);
  // }
  
  // uploadFile(file: File):Observable<any>
  //  { 
  //   const formData = new FormData(); 
  //   formData.append('file', file,file.name);
  //   return this.http.post('http://localhost:5224/upload', formData); 
  //  }

    //Validate file size 
    // const maxSize = 20 * 1024 * 1024;
    //  // 10MB 
    //  if (file.size > maxSize) 
    //  {
    //    return Promise.reject('File size exceeds the maximum limit of 20MB.');
    //    alert("File size exceeds the maximum limit of 20MB.");
    // }
     // Validate file type 
    //const allowedExtensions = ['.xls','.xlsx','.xlsb'];
      //'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet', // XLSX 
    //  'application/vnd.ms-excel', // XLS 
    //  'text/csv', // CSV
    //  'application/vnd.ms-excel.sheet.binary.macroenabled.12'
    
    //  if (!allowedExtensions.includes(file.type))
    //   { 
    //     return Promise.reject('Invalid file type. Only xlsx ,xlsb and xls files are allowed.');
    //    } 
    
    
   

