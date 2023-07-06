import { Component } from '@angular/core';

@Component({
  selector: 'app-fileupload',
  templateUrl: './fileupload.component.html',
  styleUrls: ['./fileupload.component.css']
})
export class FileuploadComponent {
  selectedFile!: File | null;

 

  onFileChange(event: any) {
    this.selectedFile = event.target.files[0];
  }

 

  uploadFile() {
    if (this.selectedFile) {
      // Handle the file upload logic here (e.g., sending it to a server).
      // You can use Angular's HttpClient to send an HTTP request to a backend API for storing the file in the database.
      console.log('Uploading file:', this.selectedFile);
    } else {
      console.log('No file selected.');
    }
  }
}
