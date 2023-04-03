import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaselistComponent } from '../baselist/baselist.component';
import { BaseList } from '../baselist/baseList';
import { filter, map, Observable, Subject, switchMap } from 'rxjs';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { CreateLocation } from '../entities/createLocation';
import { LocationItem } from '../entities/locationItem';
import { LocationService } from '../services/location.service';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { FilterType } from '../enums/filterType';
import { DeletePopupComponent } from '../delete-popup/delete-popup.component';
import { LocationUpdatePopupComponent } from '../location-update-popup/location-update-popup.component';
import { LocationAddPopupComponent } from '../location-add-popup/location-add-popup.component';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { TranslateModule } from '@ngx-translate/core';
import { ItemsTmplDirective } from '../items-tmpl.directive';

@Component({
  selector: 'intern-rapp-location-list',
  standalone: true,
  imports: [CommonModule, BaselistComponent,MatIconModule, MatDividerModule, MatListModule, MatDialogModule, TranslateModule, ItemsTmplDirective],
  templateUrl: './location-list.component.html',
  styleUrls: ['./location-list.component.scss'],
})
export class LocationListComponent extends BaseList<LocationItem> {
  public deleteSubject = new Subject<number>();
  public addSubject = new Subject<CreateLocation | undefined>();
  public updateSubject = new Subject<LocationItem>();

  constructor(private LocationService: LocationService, public dialog: MatDialog){
    super()
  }

  private  popUpConfig={
    width: '400px',
   closeOnNavigation:true,
   disableClose:false,
   hasBackdrop:true,
   position:{top:'150px',right:'500px'}
  }

  //Locations ophalen met filter 
  protected getGridItems$(paginationFilterRequest: PaginationFilterRequest): Observable<ResourceItemPagingResponse<LocationItem>> {
    return this.LocationService.filterAndPaginateLocations$(paginationFilterRequest)
  }

  ngOnInit(): void {
    this.filters=[{label:"location name",name:"filterValue",type:FilterType.Text,observable:undefined}];
    const delete$=this.configureDelete$();
    const update$=this.configureUpdate$();
    const add$=this.configureAdd$();
    this.configureItems([delete$,update$,add$])
  }
  
  private configureAdd$() {
    return this.addSubject.pipe(switchMap(data => 
      {
      const dialogRef= this.dialog.open(LocationAddPopupComponent, this.popUpConfig) 
      return dialogRef.afterClosed().pipe(map(confirm=> confirm!==undefined ? confirm : undefined
         )
    )})
    ,filter(id => !!id)
    ,switchMap(locItem => 
      {
      return  this.LocationService.addLocation$(locItem)
      }))
    }

  private configureUpdate$() {
    return this.updateSubject.pipe(switchMap(data => 
      {
        //open een dialog popup en geef de geklikte location door aan update popup component
        //zodat de data ervan getoond kan worden
      const dialogRef= this.dialog.open(LocationUpdatePopupComponent, this.popUpConfig) 
      dialogRef.componentInstance.data=data
      return dialogRef.afterClosed().pipe(map(confirm=>confirm ? data : undefined )
    )})
    ,filter(id => !!id) //Is Id weldegelijk een bekend Id
    ,switchMap(locationItem=>{ // nadien geupdate ingevulde data in uit form doorsturen naar service handler 
      console.log(locationItem)
      return this.LocationService.updateLocation$(locationItem)
      }))
  }

  private configureDelete$() {
    //return/stuur de observable verder als combinatie van filter en switchmap operaties?
    return this.deleteSubject.pipe(switchMap(id => 
      {
        //open popup en geef id van te verwijderen locatie door
      const dialogRef= this.dialog.open(DeletePopupComponent, this.popUpConfig) 
      dialogRef.componentInstance.title="location" //why?
      return dialogRef.afterClosed().pipe(map(confirm=>confirm ? id : undefined )
    )})
    ,filter(id => !!id)
    ,switchMap(id =>  this.LocationService.deleteLocation$(id)))
  }

   //filter nog niet begrepen----
  filterUpdating(filter: {}){
    let filterString=""
    const record=filter as Record<string,never>
     this.filters?.forEach(x=>{
       filterString+=`unit:${record[x.name]},`
     })
     filterString = filterString.slice(0,filterString.length-1)
     this.filterUpdated(filterString)
  }

  //Wanneer geklikt wordt op addLocation dan worden de gepredefinieerde observers uitgevoerd
  addLocation(){
    this.addSubject.next(undefined)
    }
  updateLocation=(item: LocationItem)=>{
  this.updateSubject.next(item)
  }
  delete(id: number){ 
     this.deleteSubject.next(id)
  }
}
