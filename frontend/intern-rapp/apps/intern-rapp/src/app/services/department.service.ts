import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { catchError, Observable, of } from 'rxjs';
import {  CreateDepartment } from '../entities/CreateDepartment';
import { PaginationRequest } from '../entities/paginationRequest';
import { DepartmentItem } from '../entities/departmentItem';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  constructor(private http: HttpClient) { }

  getAllSupervisorNamesContaining(name: string|undefined): Observable<string[]>{
    return this.http.get<string[]>(APIConfiguration.baseString+`/api/ApplicationUser/?filterValue=${name}`).pipe(catchError((err,caught)=>caught))
  }
  postDepartment(department: CreateDepartment){
    return this.http.post(APIConfiguration.baseString+`/api/Unit/`,department).pipe(catchError((err,caught)=>caught))
  }
  filter(filterPaginationRequest: PaginationFilterRequest){
    return this.http.get<ResourceItemPagingResponse<DepartmentItem>>(APIConfiguration.baseString+`/api/unit?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`).pipe(catchError((err,caught)=>caught))
  }
  deleteDepartment(id: number|undefined){
return this.http.delete<number>(APIConfiguration.baseString+`/api/Unit?id=${id}`).pipe(catchError((err,caught)=>caught))
}
updateDepartment(itemToBeUpdated: DepartmentItem|undefined){
  return this.http.patch(APIConfiguration.baseString+`/api/Unit`,{
    
      "id": itemToBeUpdated?.id,
      "name": itemToBeUpdated?.name,
      "managerEmails": itemToBeUpdated?.managerEmails
  }).pipe(catchError((err,caught)=>caught))

}

addDepartment(itemToBeAdded: CreateDepartment){

  const body={  "name": itemToBeAdded.name,
    "superVisorEmails": itemToBeAdded.superVisorEmails}
    console.log(body)
  return this.http.post(APIConfiguration.baseString+`/api/Unit`,body).pipe(catchError((err,caught)=>caught))

}

  }

