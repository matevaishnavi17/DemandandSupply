import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ServicesService } from '../Services/services.service';

@Component({
  selector: 'app-apply-here',
  templateUrl: './apply-here.component.html',
  styleUrls: ['./apply-here.component.css']
})
export class ApplyHereComponent implements OnInit {

  positionId: any;
  user: any;
  demandData= new FormGroup({
    source: new FormControl(' ')
  })


  constructor(private router: ActivatedRoute, private service: ServicesService ) {  }
  ngOnInit(): void {
   this.positionId = this.router.snapshot.paramMap.get('id');
   this.service.getDataByPositionId(this.positionId).subscribe(
    (result)=>{
      console.log(result)
       this.user=result;
      })
    
    

  }

  onChangeFile(event : any){
    if(event.target.files.length>0){
      const file =event.traget.files[0];
      const formData = new FormData();
      formData.append('file',file);
    } 
    
  }
}
