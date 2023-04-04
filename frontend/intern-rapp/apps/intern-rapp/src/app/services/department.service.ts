import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { catchError, Observable, of } from 'rxjs';
import {  CreateDepartment } from '../entities/CreateDepartment';
import { PaginationRequest } from '../entities/paginationRequest';
import { DepartmentItem } from '../entities/departmentItem';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { DepartementItemWithMinimalData } from '../entities/depItemWithMinimalData';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  constructor(private http: HttpClient) { }
private baseSuffixApi="/api/Unit";
  getAllSupervisorNamesContaining(name: string|undefined): Observable<string[]>{
    return this.http.get<string[]>(APIConfiguration.baseString+`/api/ApplicationUser/?filterValue=${name}`).pipe(catchError((err,caught)=>caught))
  }
  postDepartment(department: CreateDepartment){
    return this.http.post(APIConfiguration.baseString+`${this.baseSuffixApi}`,department).pipe(catchError((err,caught)=>caught))
  }
  filterAndPaginateDepartments(filterPaginationRequest: PaginationFilterRequest){
    return this.http.get<ResourceItemPagingResponse<DepartmentItem>>(APIConfiguration.baseString+`${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`).pipe(catchError((err,caught)=>caught))
  }
  filterAndPaginateDepartmentsWithMinimalData(filterPaginationRequest: PaginationFilterRequest){
    return this.http.get<ResourceItemPagingResponse<DepartementItemWithMinimalData>>(APIConfiguration.baseString+`${this.baseSuffixApi}/getAllWithminimaldata?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`).pipe(catchError((err,caught)=>caught))
  }
  deleteDepartment(id: number|undefined){
return this.http.delete<number>(APIConfiguration.baseString+`${this.baseSuffixApi}?id=${id}`).pipe(catchError((err,caught)=>caught))
}
updateDepartment(itemToBeUpdated: DepartmentItem|undefined){
  return this.http.patch(APIConfiguration.baseString+`${this.baseSuffixApi}`,{
    
      "id": itemToBeUpdated?.id,
      "name": itemToBeUpdated?.name,
      "managerEmails": itemToBeUpdated?.managerEmails
  }).pipe(catchError((err,caught)=>caught))

}

addDepartment(itemToBeAdded: CreateDepartment){

  const body={  "name": itemToBeAdded.name,
    "superVisorEmails": itemToBeAdded.superVisorEmails}
    console.log(body)
  return this.http.post(APIConfiguration.baseString+`${this.baseSuffixApi}`,body).pipe(catchError((err,caught)=>caught))

}

  }

