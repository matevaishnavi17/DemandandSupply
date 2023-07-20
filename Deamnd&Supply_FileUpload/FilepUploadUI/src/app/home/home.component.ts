import { HttpClient, HttpErrorResponse, HttpEventType, HttpResponse } from '@angular/common/http';
import { AfterViewInit, Component, EventEmitter, OnInit, Output } from '@angular/core';
import Swal from 'sweetalert2';
// import { HttpClient } from '@angular/common/http';
import { FileUploadService } from '../file-upload.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
 file!: File;
 progress:number | undefined;
  message:string | undefined;
  @Output() public onUploadFinished = new EventEmitter();
  constructor(private fileUploadService: FileUploadService,private http:HttpClient) { }
  ngOnInit() {
  }
  allowedExtensions = ['.xlsx', '.xls', '.xlsb'];
  isFileAllowed=true;
  selectedFile: File | undefined;
  
  // selectedFile: File | null = null;
  // errorMessage: string | null = null;
  // showAlert = false;

  onFileSelected(event: any) {
    this.selectedFile=event.target.files[0] as File;
    if(!this.selectedFile){
      console.log('Please select file');
      alert('Please Select File');
      return;
    }
     const fileExtension = this.getFileExtension(this.selectedFile.name);
      if (!this.isExtensionAllowed(fileExtension)) {
        console.log('Invalid file type. Only xlsx, xls, and xlsb files are allowed.');
        alert("Invalid file type. Only xlsx, xls, and xlsb files are allowed.")
        return;
      }
    this.uploadFile(event.target.files);
  }

  uploadFile = (files:FileList) => {
    if (files.length === 0) {
      return;
    }

    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    
    this.http.post('http://localhost:5224/upload', formData, {reportProgress: true, observe: 'events'})
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
  getFileExtension(filename: string): string {
    console.log('getfileextension');
    return '.' + filename.split('.').pop()?.toLowerCase();
   
  }

  isExtensionAllowed(extension: string): boolean {
    console.log('iseextension');
    return this.allowedExtensions.includes(extension);
  }

  onUpload(){
   // Swal.fire('Fil uploaded succesfully!', 'success')  
   alert('File Uploaded Successfully!')
  }
}


//   uploadFile(files: FileList) {
//     if (files.length == 0) {
//       console.log("No file selected!");
//       return

//     }
//     let file: File = files[0];

//     this.fileUploadService.uploadFile( "http://localhost:5224/upload", file)
//       .subscribe(
//         event => {
//           if (event.type == HttpEventType.UploadProgress) {
//             const percentDone = Math.round(100 * (event.loaded || 1 )/ (event.total || 1));
//             console.log(`File is ${percentDone}% loaded.`);
//           } else if (event instanceof HttpResponse) {
//             console.log('File is completely loaded!');
//           }
//         },
//         (err) => {
//           console.log("Upload Error:", err);
//         }, () => {
//           console.log("Upload done");
//         }
//       )
//   }
// }  
    // const files : FileList = event.target.files;
    // //const file:File|undefined
    // // this.errorMessage = null;
    // this.selectedFile = event.target.files[0] as File;
     
    // if(files && files.length > 0){
    //   const fileToUpload = files.item(0);
    //   if (!this.selectedFile) {
    //     console.log('Please select a file.');
    //     alert("Please select file.")
    //     return;
    //   }
    
    //   const fileExtension = this.getFileExtension(this.selectedFile.name);
    //   if (!this.isExtensionAllowed(fileExtension)) {
    //     console.log('Invalid file type. Only xlsx, xls, and xlsb files are allowed.');
    //     alert("Invalid file type. Only xlsx, xls, and xlsb files are allowed.")
    //     return;
    
      //Validate file size 
    //const maxSize = 20 * 1024 * 1024;
    // 10MB 
    //  if (file.size > maxSize) 
    //   {
    //     return Promise.reject('File size exceeds the maximum limit of 20MB.');
        
    //   }
    //   if(fileToUpload){
    // this.fileUploadService.uploadFile(fileToUpload) .then(response => 
    //   { 
    //     console.log('File uploaded successfully:', response); 
    //     // Handle the success response from the server 
    //     alert('File uploaded Successfully');
    //   })
    //      .catch(error => { console.error('Error uploading file:', error); 
    //     // Handle the error response from the server 
    //     alert(error);
    //   });
    // }
  
  //   console.log(this.selectedFile);
    
  // }
  // getFileExtension(filename: string): string {
  //   console.log('getfileextension');
  //   return '.' + filename.split('.').pop()?.toLowerCase();
   
  // }

  // isExtensionAllowed(extension: string): boolean {
  //   console.log('iseextension');
  //   return this.allowedExtensions.includes(extension);
  // }

  // callServiceMethod(file:File){
  //  console.log('callservicemethod');
  //   if(file){
  //     this.fileUploadService.uploadFile('http://localhost:5224/upload',file).subscribe(response=>{
  //       console.log(response);
        

  //     })
  //   }
      // .then(response => 
      //   { 
      //     console.log('File uploaded successfully:', response); 
      //     // Handle the success response from the server 
      //     alert('File uploaded Successfully');
      //   })
      //      .catch(error => { console.error('Error uploading file:', error); 
      //     // Handle the error response from the server 
      //     alert(error);
      //   });
      
  
  // onUpload() {
  //   if (!this.selectedFile) {
  //     console.log('Please select a file.');
  //     alert("Please select file.")
  //     return;
  //   }

  //   const fileExtension = this.getFileExtension(this.selectedFile.name);
  //   if (!this.isExtensionAllowed(fileExtension)) {
  //     console.log('Invalid file type. Only xlsx, xls, and xlsb files are allowed.');
  //     alert("Invalid file type. Only xlsx, xls, and xlsb files are allowed.")
  //     return;
  //   }
  // }
  // uploadFile() {
  //   if (!this.selectedFile) {
  //     this.errorMessage = 'Please select a file.';
  //     return;
  //   }

  //   // File Size Validation
  //   const maxSizeInBytes = 2097152 ; // Maximum file size in bytes (e.g., 1MB)
  //   if (this.selectedFile.size > maxSizeInBytes) {
  //     this.errorMessage = 'File size exceeds the maximum limit.';
  //     return;
  //   }

  //   // File Type Validation
  //   const allowedExtensions = ['xlsx'];
  //   const fileExtension = this.selectedFile.name.split('.').pop()?.toLowerCase();
  //   if (!fileExtension || !allowedExtensions.includes(fileExtension)) {
  //     this.errorMessage = 'Invalid file type. Please upload an Excel file (.xlsx).';
  //     return;
  //   }

  //   // Proceed with file upload logic
  //   console.log(this.selectedFile);
  //   //upload file successful
  //   this.showAlert=true;

  //   // Hide the alert after a certain period (optional)
  //   setTimeout(() => {
  //    this.showAlert = false;
  //    }, 5000);

  // }

  
  

