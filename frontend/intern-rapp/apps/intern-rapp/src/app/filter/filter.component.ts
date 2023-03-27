import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FilterType } from '../enums/filterType';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { Filter } from '../entities/filter';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { TranslateModule } from '@ngx-translate/core';



@Component({
  selector: 'intern-rapp-filter',
  standalone: true,
  imports: [CommonModule,MatFormFieldModule,ReactiveFormsModule,MatInputModule,MatIconModule,TranslateModule],
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss'],
})
export class FilterComponent implements OnInit{

@Input() filters :Filter[]=[]
@Output() filtered=new EventEmitter<object>()
public filterForm=new FormGroup({})
public filtertype: typeof FilterType
constructor(){
  this.filtertype=FilterType
}
  ngOnInit(): void {
    this.filters.forEach(x=>{
      this.filterForm.addControl(x.name,new FormControl())
    })
  }
  filter(){
   this.filtered.emit(this.filterForm.getRawValue())
  }
}
