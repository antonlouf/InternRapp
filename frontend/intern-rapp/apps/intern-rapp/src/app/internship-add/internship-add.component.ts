import { AfterContentInit, AfterViewChecked, ChangeDetectionStrategy, ChangeDetectorRef, Component, DoCheck, OnChanges, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { CommonModule, KeyValue } from '@angular/common';
import { FormGroup, ReactiveFormsModule, FormControl, Validators, FormArray, AbstractControl } from '@angular/forms';
import { MatFormField, MatLabel } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatOptionSelectionChange } from '@angular/material/core';
import { TranslateModule, TranslateService } from '@ngx-translate/core';
import { Subject, Observable, switchMap, tap } from 'rxjs';
import { PaginationRequest } from '../entities/paginationRequest';
import { DepartmentService } from '../services/department.service';
import { DepartmentItem } from '../entities/departmentItem';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { MatAutocompleteModule, MatAutocompleteSelectedEvent } from '@angular/material/autocomplete';
import { DepartementItemWithMinimalData } from '../entities/depItemWithMinimalData';
import { filter, map, shareReplay, startWith, takeUntil } from 'rxjs/operators';
import { TrainingType } from '../enums/trainingType';
import {MatTabsModule} from '@angular/material/tabs';
import { LanguageItem } from '../entities/languageItem';
import { LanguageService } from '../services/language.service';
import{buildFormGroupForTranslations} from '../translation-add-form/formGroupBuilder'
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { LanguagePopupChoiceComponent } from '../language-popup-choice/language-popup-choice.component';
import { TranslationAddFormComponent } from '../translation-add-form/translation-add-form.component';
@Component({
  selector: 'intern-rapp-internship-add',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,MatInputModule,MatDialogModule,TranslationAddFormComponent,MatSelectModule,TranslateModule,MatAutocompleteModule,MatTabsModule,MatIconModule,MatButtonModule],
  templateUrl: './internship-add.component.html',
  styleUrls: ['./internship-add.component.scss'],
 changeDetection:ChangeDetectionStrategy.Default
})
export class InternshipAddComponent implements OnInit{
  public availableTrainingTypes=Object.values(TrainingType).slice(0,Object.values(TrainingType).length/2) 
  
  public addInternshipForm:FormGroup|undefined; 
constructor(private unitService: DepartmentService,
            private languageService:LanguageService,
            private dialog: MatDialog
            ){}

  public unitObs$:Observable<DepartementItemWithMinimalData[]>|undefined
  private languageObs$:Observable<LanguageItem[]>|undefined
  private destrojSubj$=new Subject()
  private  popUpConfig={
    width: '400px',
   closeOnNavigation:true,
   disableClose:false,
   hasBackdrop:true,
   position:{top:'250px',right:'630px'}
  }
  ngOnInit(): void {
    this.addInternshipForm= new FormGroup({
      schoolYear:new FormControl(this.availableDates()[1],[Validators.required]),
      unit:new FormControl('',[Validators.required]),
      maxStudents:new FormControl(0,[Validators.required,Validators.pattern("^[0-9]*$"),Validators.maxLength(10)]),
      currentCountOfStudents:new FormControl(0,[Validators.required,Validators.pattern("^[0-9]*$")]),
      trainingType:new FormControl("0",[Validators.required]),
      translateTabs:new FormArray([])
    })
    this.languageObs$=this.languageService.filterAndPaginateLanguages({filterString:'',pageIndex:1,pageSize:100}).pipe(shareReplay(1),map(data=>data.items))
    
    this.unitObs$=this.addInternshipForm?.controls['unit'].valueChanges.pipe(startWith(''),switchMap(data=>{
      return this.unitService.filterAndPaginateDepartmentsWithMinimalData({pageIndex:1,filterString:'unitName:'+data?.toString()??'',pageSize:100})
    }),map(data=> data.items
      ))
  }
  // compareWith=(o1: any, o2: any)=> o1=== o2;
   
  
  availableDates(){
    const availableDates=[]
    const year=new Date().getFullYear()
    const previousYear=year-1
    for (let i = 0; i <2; i++) {
    availableDates[i]=`${previousYear+i}-${year+i}`;
    }
    return availableDates
  }
  public get tabs(){
    return ((this.addInternshipForm?.controls['translateTabs']) as FormArray).controls
  }
  addLanguage(){
   this.languageObs$?.pipe(
    map(data=>{
      const itemsTobeReturned: LanguageItem[]=[]
      for (let i = 0; i < data.length; i++) {
        let isValid=true
        for (let j = 0; j < this.tabs.length; j++) {
          if(this.tabs[j].getRawValue().languageId===data[i].id){
            isValid=false
            break
          }
             
              
        }
        if(isValid)
          itemsTobeReturned.push(data[i])
      }
      return itemsTobeReturned
    }),
    switchMap(data => 
      {
        console.log(data)
      const dialogRef= this.dialog.open(LanguagePopupChoiceComponent, this.popUpConfig) 
      dialogRef.componentInstance.languageItems=data
      return dialogRef.afterClosed().pipe(
        map(confirm=>confirm ? confirm : undefined),
        filter(data=>!!data),
      tap((data)=>{
        
        const controls=((this.addInternshipForm?.controls['translateTabs']) as FormArray).controls;
       
        controls.push(buildFormGroupForTranslations(undefined,data!==undefined?data.id:undefined,data!==undefined?data.name?.toString():undefined))
      }))}),
    takeUntil(this.destrojSubj$)).subscribe()


    
 
  }
  public getLanguageById(formGroup:FormGroup){
    return this.languageService.getById(formGroup.controls['languageId'].value)
  }
  public getFormGroupOutOfAbstractControl(abstractControl: AbstractControl):FormGroup{
    console.log(this.addInternshipForm?.getRawValue())
    return abstractControl as FormGroup
  }

}
