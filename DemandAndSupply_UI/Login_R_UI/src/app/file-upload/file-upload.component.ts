import { HttpClient, HttpErrorResponse, HttpEventType, HttpResponse } from '@angular/common/http';
import { AfterViewInit, Component, EventEmitter, OnInit, Output } from '@angular/core';
//import Swal from 'sweetalert2';
// import { HttpClient } from '@angular/common/http';
import { FileUploadService } from '../Services/file-upload.service';


@Component({
  selector: 'app-file-upload',
  templateUrl: './file-upload.component.html',
  styleUrls: ['./file-upload.component.css']
})
export class fileuploadComponent implements OnInit {
 file!: File;
 progress:number | undefined;
  message:string | undefined;
  @Output() public onUploadFinished = new EventEmitter();
  constructor(private fileUploadService: FileUploadService,private http:HttpClient) { }
  ngOnInit() {
  }
  //allowedExtensions = ['.xlsx', '.xls', '.xlsb'];
  isFileAllowed=true;
  selectedFile: File | undefined;

  // selectedFile: File | null = null;
  // errorMessage: string | null = null;
  // showAlert = false;

  onFileSelected(event: any) {
    this.uploadFile(event.target.files);
  }

  uploadFile = (files:FileList) => {
    if (files.length === 0) {
      return;
    }

    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);

    this.http.post('http://localhost:5285/api/UploadFile/upload', formData, {reportProgress: true, observe: 'events'})
      .subscribe({
        next: (event) => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * (event.loaded || 1) / (event.total || 1));
        else if (event.type === HttpEventType.Response) {
          this.message = 'Upload success.';
          this.onUploadFinished.emit(event.body);
        }
      },
      error: (err: HttpErrorResponse) => console.log(err)
    });
  }
  onUpload(){
   // Swal.fire('Fil uploaded succesfully!', 'success'
   alert('File Uploaded Successfully!')
  }
}
